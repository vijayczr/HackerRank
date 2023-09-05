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
     * Complete the 'pairs' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY arr
     */

    public static int pairs(int k, List<int> arr)
    {
        int count = 0;
        HashSet<int> unq = new HashSet<int>();
        for (int i = 0; i < arr.Count(); i++)
        {
            if (unq.Contains(arr[i] - k))
            {
                count++;
            }
            if (unq.Contains(arr[i] + k))
            {
                count++;
            }
            unq.Add(arr[i]);
        }
        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        int k = Convert.ToInt32(Console.ReadLine());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.pairs(k, arr);
        Console.WriteLine(result);
    }
}