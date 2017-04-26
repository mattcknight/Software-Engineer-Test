using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Software_Engineer_Test
{
    public class Palindrome
    {
        public static void Main(string[] args)
        {

            string[] myArgs = {"pop", "not a type writer", @"Ah, Satan sees Natasha", "1ab1"};
            for(int i=0 ; i < myArgs.Length; i++)
            {
                string input = myArgs[i];
                string text = Regex.Replace(input.ToLower(), @"[^\w]", ""); 

                string reverseText = new string(text.Reverse().ToArray());
                string result = text.Equals(reverseText) ? "YES" : "NO";
                Console.WriteLine(result);    
            }

        }


    }
}