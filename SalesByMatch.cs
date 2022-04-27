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
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int sockMerchant(int n, List<int> ar)
    {
        /* Solution 1
        int pairs = 0;
        Dictionary<int, int> groupedar = new Dictionary<int, int>();
        for(int i=0;i<n;i++){
            if(groupedar.ContainsKey(ar[i])){
                groupedar[ar[i]]++;
            }else{
                groupedar.Add(ar[i], 1);
            }
        }
        foreach(int element in groupedar.Values){
            pairs += element /2;
        }*/
        /* Solution 2 */
        int pairs =0;
        List<int> odds = new List<int>();
        for(int i=0; i<n; i++){
            if(!odds.Contains(ar[i])){
                odds.Add(ar[i]);
            }else{
                pairs ++;
                odds.Remove(ar[i]);
            }
        }
        return pairs;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
