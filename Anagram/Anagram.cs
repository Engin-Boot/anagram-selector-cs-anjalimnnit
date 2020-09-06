using System;
using System.Collections.Generic;

namespace Anagram
{
    public class AnagramSelector
    {
        public bool WordPairIsAnagram(string word1, string word2) {
            if(word1.Length!=word2.Length)
            return false;
            int[] characterCount = new int[256]; 
            for(int charInInputString =0;charInInputString<word1.Length;charInInputString++)
            {
                characterCount[word1[charInInputString]]++;
                characterCount[word2[charInInputString]]--;
            }
            
            for(int charInInputString=0;charInInputString<256;charInInputString++)
            {
                if(characterCount[charInInputString]!=0)
                return false;
            }
            return true;
        }
        public List<string> SelectAnagrams(string word, List<string> candidates) {
            for(int i=0;i<candidates.Count;i++)
            {
            if(!WordPairIsAnagram(candidates[i],word))
            candidates.Remove(candidates[i]);
            }
            return candidates;
        }
    }
}
