using System;
using System.Collections.Generic;

namespace Anagram
{
    public class AnagramSelector
    {
        AnagramChecker checker = new AnagramChecker();
        public List<string> SelectAnagrams(string word, List<string> candidates) {
            for(int i=0;i<candidates.Count;i++)
            {
            if(!checker.WordPairIsAnagram(candidates[i],word))
            {
            candidates.Remove(candidates[i]);
            i--;
            }
            }
            
            return candidates;
        }
    }
}
