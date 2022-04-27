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
     * Complete the 'caesarCipher' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static string caesarCipher(string s, int k)
    {
        char[] result = new char[s.Length];
        List<char> alphabets = Enumerable.Range('a', 'z' - 'a'+1)               .Select(x => (char)x).ToList();
        int i = 0;
        while(i < s.Length){
            
            int index = alphabets.IndexOf(Char.ToLower(s[i]));
            if(index >= 0){
                result[i] = Char.IsUpper(s[i])? Char.ToUpper(alphabets[(index+k)%26]) : alphabets[(index+k)%26];
            }
            else{
                result[i] = s[i];
            }
            i++;
        }
        return new string(result);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.caesarCipher(s, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
