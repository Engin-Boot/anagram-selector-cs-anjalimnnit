using System;
using System.Collections.Generic;

namespace Anagram
{
    public class AnagramChecker
    {
        public bool WordPairIsAnagram(string word1, string word2) {

            int[] characterCount = new int[256]; 
            for(int charInInputString =0;charInInputString<word1.Length;charInInputString++)
            {
                characterCount[word1[charInInputString]]++;
                characterCount[word2[charInInputString]]--;
            }
            
            for(int charInInputString=0;charInInputString<256;charInInputString++)
            {
                if(word1.Length!=word2.Length || characterCount[charInInputString]!=0)
                return false;
            }
            
            return true;
        }
    }
}