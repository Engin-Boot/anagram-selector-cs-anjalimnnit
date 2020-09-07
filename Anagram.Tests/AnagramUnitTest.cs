using System;
using Xunit;
using Anagram;
using System.Collections.Generic;
using System.Linq;

namespace Anagram.Tests
{
    public class AnagramUnitTest
    {
        [Fact]
        public void RecognizesShuffledAlphabetsAsAnagrams()
        {
            AnagramChecker checker= new AnagramChecker();
            Assert.True(checker.WordPairIsAnagram("restful", "fluster"));
            Assert.True(checker.WordPairIsAnagram("forty five", "over fifty"));
        }
        [Fact]
        public void ReportsNonAnagrams()
        {
            AnagramChecker checker= new AnagramChecker();
            Assert.False(checker.WordPairIsAnagram("something", "else"));
        }
        [Fact]
        public void SelectsAnagramsOfAWord()
        {
            AnagramSelector selector = new AnagramSelector();
            var selection = selector.SelectAnagrams("master",
                new List<string>{"stream", "something", "maters"});

            Assert.True(selection.SequenceEqual(
                new List<string>{"stream", "maters"}));
        }
        [Fact]
        public void DisplayEmptyListWhenNoAnagramIsPresentInTheList()
        {
            AnagramSelector selector = new AnagramSelector();
            var selection = selector.SelectAnagrams("listen",
                new List<string>{"list", "help", "sit"});
            Assert.True(selection.SequenceEqual(
                new List<string>{}));

        }

    }
}
