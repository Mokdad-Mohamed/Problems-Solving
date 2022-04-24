using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'pangrams' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string pangrams(string s)
    {
        var alphabets = Enumerable.Range('a', 'z'-'a' + 1).ToList();
        var majAlphabets = Enumerable.Range('A', 'Z'-'A'+1).ToList();
        
        int alphabetCount = alphabets.Count();
        char[] charArray = s.ToCharArray();
        int count =26;
        int[] verified = new int[26];
        foreach(char a in charArray){
            if(alphabets.Contains((int)a)){
                int arrayIndex = alphabets.IndexOf((int)a);
                if(verified[arrayIndex]== 0){
                    alphabetCount--;
                    verified[arrayIndex] =1;
                }
            }
            if(majAlphabets.Contains((int)a)){
                int arrayIndex = majAlphabets.IndexOf((int)a);
                if(verified[arrayIndex]== 0){
                    alphabetCount--;
                    verified[arrayIndex] =1;
                }
            }
            if(alphabetCount == 0)
            break;
            
        }
        if (alphabetCount > 0)
            return "not pangram";
        else
            return "pangram";
        
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.pangrams(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
