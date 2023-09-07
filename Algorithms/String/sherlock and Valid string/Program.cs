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
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        var counted = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (!counted.ContainsKey(s[i]))
            {
                counted.Add(s[i], 1);
            }
            else
            {
                counted[s[i]] += 1;
            }
        }
        var dist = new Dictionary<int, int>();
        foreach (var c in counted.Values)
        {
            if (!dist.ContainsKey(c))
            {
                dist.Add(c, 1);
            }
            else
            {
                dist[c] += 1;
            }
        }
        if(dist.Count > 2) { return "NO"; }
        else if(dist.Count ==2)
        {
            if(dist.First().Value != 1 && dist.Last().Value != 1)
            {
                return "NO";
            }
        }
        return "YES";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the string to be checked!");
        string s = Console.ReadLine();

        string result = Result.isValid(s);
        Console.WriteLine(result);
    }
}
