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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        var splitted = s.Split(':');
        var hours = splitted[0];
        var minutes = splitted[1];
        var seconds = splitted[2].Substring(0,2);
        var prefix = splitted[2].Substring(2);
        int numericHours = int.Parse(hours);
        if(prefix.Equals("PM")){
            if(numericHours != 12)
                numericHours = numericHours + 12;
            hours = numericHours.ToString();
        }else if(numericHours == 12)
                hours = "00";
        
        return $"{hours}:{minutes}:{seconds}";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
