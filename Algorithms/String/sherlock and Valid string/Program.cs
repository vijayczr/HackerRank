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
        var x = counted.OrderBy(u => u.Value);
        int count = 0;
        int y = 0;
        foreach (var dat in x)
        {
            if (y == 0)
            {
                y = dat.Value;
                continue;
            }
            if (dat.Value != y)
            {
                count += dat.Value - y;
                y = dat.Value;
            }

        }
        if (count > 1)
        {
            return "NO";
        }
        else
        {
            return "YES";
        }
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
