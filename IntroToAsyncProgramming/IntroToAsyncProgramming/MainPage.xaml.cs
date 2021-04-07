using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IntroToAsyncProgramming
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnSyncClicked(object sender, EventArgs e)
        {
            ClearScreen();
            Stopwatch watch = Stopwatch.StartNew();

            Method1();
            Method2();
            Method3();
            Method4();

            EnergizerBunny bunny = GetBunny();
            TxtResult.Text += bunny.ToString();
            TxtResult.Text += $"{Environment.NewLine}Elapsed time: {watch.ElapsedMilliseconds}";
        }



        // An event is the only type of void that can be async
        private async void BtnAsyncClicked(object sender, EventArgs e)
        {
            ClearScreen();
            Stopwatch watch = Stopwatch.StartNew();

            await Method1Async();
            await Method2Async();
            await Method3Async();
            await Method4Async();

            EnergizerBunny bunny = await GetBunnyAsync();

            TxtResult.Text += bunny.ToString();
            TxtResult.Text += $"{Environment.NewLine}Elapsed time: {watch.ElapsedMilliseconds}";
        }

        // Parallel runs multiple async independent methods at the same time
        private async void BtnParallellClicked(object sender, EventArgs e)
        {
            ClearScreen();
            Stopwatch watch = Stopwatch.StartNew();

            List<Task> tasks = new List<Task>
            {
                Method1Async(),
                Method2Async(),
                Method3Async(),
                Method4Async()
            };

            await Task.WhenAll(tasks);

            TxtResult.Text += $"{Environment.NewLine}Elapsed time: {watch.ElapsedMilliseconds}";
        }

        private void Method1()
        {
            Thread.Sleep(4000);
            ReportToUser(nameof(Method1));
        }

        // When using async, we use Task instead of void
        private async Task Method1Async()
        {
            await Task.Run(() => Thread.Sleep(4000));
            ReportToUser(nameof(Method1Async));
        }

        private void Method2()
        {
            Thread.Sleep(2000);
            ReportToUser(nameof(Method2));
        }

        private async Task Method2Async()
        {
            await Task.Run(() => Thread.Sleep(2000));
            ReportToUser(nameof(Method2Async));
        }

        private void Method3()
        {
            Thread.Sleep(3500);
            ReportToUser(nameof(Method3));
        }

        private async Task Method3Async()
        {
            await Task.Run(() => Thread.Sleep(3500));
            ReportToUser(nameof(Method3Async));
        }

        private void Method4()
        {
            Thread.Sleep(1000);
            ReportToUser(nameof(Method4));
        }

        private async Task Method4Async()
        {
            await Task.Run(() => Thread.Sleep(1000));
            ReportToUser(nameof(Method4Async));
        }

        private void ReportToUser(string method)
        {
            TxtResult.Text += $"Method {method} has been completed.{Environment.NewLine}";
        }

        private void ClearScreen()
        {
            TxtResult.Text = string.Empty;
        }

        private EnergizerBunny GetBunny()
        {
            Thread.Sleep(3000);
            return new EnergizerBunny();
        }

        private async Task<EnergizerBunny> GetBunnyAsync()
        {
            await Task.Run(() => Thread.Sleep(3000));
            return new EnergizerBunny();
        }

        
    }
}
