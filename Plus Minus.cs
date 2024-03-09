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
        var plusNumbers=0;
        var zeros =0;
        var negativeNumbers = 0;
        double counter = 0;
        
        foreach(var i in arr){
            counter++;
            if(i > 0)
                plusNumbers++;
 
            else if(i < 0)
                negativeNumbers++;

            else if(i == 0)
                zeros++;
        }
        var plusRatio = plusNumbers/counter;
        var negativeRatio = negativeNumbers/counter;
        var zerosRatio = zeros/counter;

        Console.WriteLine(System.Convert.ToString(plusRatio));
        Console.WriteLine(System.Convert.ToString(negativeRatio));
        Console.WriteLine(System.Convert.ToString(zerosRatio)); 
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
