using System;
using System.Collections.Generic;

namespace Anagram
{
    public class AnagramChecker
    {   
         int[] characterCount = new int[256]; 
        public bool CheckAllZerosInArray(string word1, string word2)
        {
            for(int charInInputString=0;charInInputString<256;charInInputString++)
            {
                if( characterCount[charInInputString]!=0)
                return false;
            }
            return true;
        }
        public bool WordPairIsAnagram(string word1, string word2)
         {
             for(int charInInputString =0 ;charInInputString<word1.Length;charInInputString++)
             {
                characterCount[word1[charInInputString]]++;
                characterCount[word2[charInInputString]]--;
             }
             if(word1.Length!=word2.Length )
             return false;
            return CheckAllZerosInArray(word1,word2);     
          
        }
    }
}