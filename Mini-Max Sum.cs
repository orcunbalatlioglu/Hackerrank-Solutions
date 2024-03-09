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
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        List<int> mins = new List<int>(arr);
        List<int> maxs = new List<int>(arr);

        long sumMin = 0;
        long sumMax = 0;
        
        mins.RemoveAt(mins.IndexOf(mins.Max()));
        foreach(var i in mins){
            sumMin += i; 
        }
        
        maxs.RemoveAt(maxs.IndexOf(maxs.Min()));
        foreach(var k in maxs){
            sumMax += k; 
        }
        
        Console.WriteLine(System.Convert.ToString(sumMin)+" "+System.Convert.ToString(sumMax));
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}