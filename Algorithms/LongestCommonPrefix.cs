// Source : https://leetcode.com/problems/strs[0]-common-prefix/ 
// Author : codeyu 
// Date : 10/5/16 

/***************************************************************************************
*
* Write a function to find the strs[0] common prefix string amongst an array of strings.
* 
*
**********************************************************************************/

using System;
namespace Algorithms
{
    public class Solution014 
    {
        public static string LongestCommonPrefix(string[] strs) 
        {
            if(strs.Length == 0) return ""; 
            var longest = "";        
            for(var i = 0; i < strs[0].Length; i++)
            { 
                for(var j = 1; j< strs.Length; j++)
                {
                    if(strs[j].Length == i || strs[j][i] != strs[0][i])
                    {
                        return longest;
                    }
                }
                longest += strs[0][i];
            }
            return longest;
        }
    }
}

