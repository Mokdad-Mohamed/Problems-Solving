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
     * Complete the 'isValid' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string isValid(string s)
    {
        Dictionary<char, int> frequincies = new Dictionary<char, int>();
        
        foreach(var c in s){
            if(frequincies.ContainsKey(c)){
                frequincies[c]+=1;
            }else {
                frequincies.Add(c, 1);
            }
        }
        frequincies = frequincies.OrderBy(x =>x.Value).ToDictionary(x => x.Key,x => x.Value);
        
        int count = frequincies.Count;
        if(count == 1)
        return "YES";
        int first = frequincies.Values.ElementAt(0);
        int second = frequincies.Values.ElementAt(1);
        int secondLast = frequincies.Values.ElementAt(count -2);
        int last = frequincies.Values.ElementAt(count -1);
        if((first == last)||(first == secondLast && last == secondLast +1) || (first ==1  && second == last))
        return "YES";
        return "NO";
        
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.isValid(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
