using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToAsyncProgramming.Tests
{
    public class StringTests
    {
        [Test]
        public void ShortenShouldReturnXWordsFollowedByEllipses()
        {
            // ARRANGE
            string blog = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras faucibus iaculis mauris, nec vehicula risus feugiat a. Suspendisse elementum facilisis consectetur. Suspendisse semper arcu id sem dapibus, vel cursus turpis malesuada. Duis ac eleifend ante. In semper luctus dui, id eleifend ante sagittis ut. Donec maximus leo vitae massa efficitur aliquet. Proin luctus, leo in aliquam porttitor, libero risus pharetra orci, a mollis metus nisi at lorem.                                    Phasellus massa erat, volutpat quis porta at, iaculis at mauris. Donec lacinia nibh id enim ullamcorper, sed vehicula sapien semper. Cras vestibulum a sapien sit amet consequat. Nam sit amet lobortis elit. Nunc convallis venenatis erat sed faucibus. Donec arcu tortor, viverra id ornare nec, maximus in risus. Aliquam erat volutpat. Mauris erat nisl, vulputate vitae molestie nec, tempor at nisl. Cras commodo, nibh ac dignissim rutrum, elit enim gravida lorem, eget accumsan sapien turpis at velit.                                    Fusce quis libero sed neque faucibus pulvinar. Donec varius metus quis massa tristique, sed sodales erat iaculis. Phasellus urna erat, aliquet non nunc eget, ultricies venenatis libero. Ut molestie arcu quis quam congue, a gravida lacus ornare. Mauris eget varius lacus. Etiam in elementum enim. Etiam rhoncus at augue vel facilisis. Duis lacinia enim eu nisi dapibus, a mattis odio commodo. Nullam dictum fringilla orci ac cursus. Fusce nec tempus metus. Maecenas consectetur sapien tempor malesuada lobortis. Vivamus vel cursus metus, a semper enim. Donec varius arcu a ipsum lacinia mattis eget at risus. Sed a augue lectus. Mauris vitae ultricies sapien. Morbi fringilla nec dolor ac lobortis.";
            var classUnderTest = new ExtensionMethodsPrimer();
            string expected = "Lorem ipsum dolor sit amet,...";

            // ACT
            classUnderTest.ShortenArticles();


            // ASSERT
            //Assert.AreEqual(expected, result);
        }
    }
}
