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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        var count = arr.Count();
     
        double nullCount = 0;
        double positiveCount = 0;
        double negativeCount =0;
        foreach(var element in arr){
            if(element > 0){
                positiveCount++;
            }else if(element < 0){
                negativeCount ++;
            }else{
                nullCount ++;
            }
        }
        Console.WriteLine((positiveCount/count).ToString("0.000000"));
        Console.WriteLine((negativeCount/count).ToString("0.000000"));
        Console.WriteLine((nullCount/count).ToString("0.000000"));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
    
}
