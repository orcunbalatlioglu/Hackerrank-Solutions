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
     * Complete the 'hourglassSum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int hourglassSum(List<List<int>> arr)
    {
        List<int> hourGlasses = new List<int>();
        
        for(int i = 0; i < arr.Count - 2; i++){
            for(int j = 0; j < arr[i].Count - 2; j++){
                int totalGlass = 0; 
                for(int k = 0; k < 3; k++){
                    if(k == 1){
                        totalGlass += arr[i+1][j+1];
                        continue;
                    }
                    for(int m = 0; m < 3; m++){
                        totalGlass += arr[i+k][j+m];
                    } 
                }
                hourGlasses.Add(totalGlass); 
            }
               
        }
        return hourGlasses.Max();

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
