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
     * Complete the 'flippingBits' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */

    public static long flippingBits(long n)
    {
        string binary = Convert.ToString(n, 2);
        //binary.PadLeft(32,'1');
        char[] binChar = binary.ToCharArray();
        for(int i=0;i<binChar.Length;i++){
            if(binChar[i]=='0')
                binChar[i]='1';
            else
                binChar[i]='0';
        }
        binary = (new string(binChar)).PadLeft(32,'1');
        long result = Convert.ToInt64(binary, 2);
        return result;
    }
    
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Result.flippingBits(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
