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
     * Complete the 'icecreamParlor' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER m
     *  2. INTEGER_ARRAY arr
     */

    public static List<int> icecreamParlor(int m, List<int> arr)
    {
        List<int> response = new List<int>();
        for (int i = 0; i < arr.Count(); i++)
        {
            for (int j = i + 1; j < arr.Count(); j++)
            {
                if ((arr[i] + arr[j]) == m)
                {
                    response.Add(i + 1);
                    response.Add(j + 1);
                }
            }
        }
        return response;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        var arr = new List<int>();
        Console.WriteLine("Enter the length of the icecream price array");
        int t = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the peices");
        for(int i =0; i< t; i++)
        {
            int f = int.Parse(Console.ReadLine());
            arr.Add(f);
        }
        Console.WriteLine("Enter the total amount kids have");
        int m = int.Parse(Console.ReadLine());
        var res = Result.icecreamParlor(m, arr);
        for(int j=0; j<res.Count; j++)
        {
            Console.WriteLine(res[j]);
        }
    }
}
