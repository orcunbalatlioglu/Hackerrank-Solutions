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
        StringBuilder newString = new StringBuilder(s);
        string temp = ((newString[0]-48)*10 + newString[1]-48).ToString();
        
        if (s[s.Length-2] == 'P' && (temp != "12")) {
            int time = 10 * (Convert.ToInt32(s[0])-48);
            time += Convert.ToInt32(s[1])- 48;
            time = time + 12;
            string clock = time.ToString();
            newString[0] = clock[0];
            newString[1] = clock[1];
        }
        else if (s[s.Length - 2] == 'A' && (temp == "12"))
        {
            newString[0] = '0';
            newString[1] = '0';
        }
        newString.Remove(newString.Length - 2,2);
        string result = newString.ToString();
        return result;
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
