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

        long maxval = 0;
        long totalsum = 0;
        long minval = arr.Max();
        for (int i = 0; i < arr.Count(); i++)
        {
            totalsum += arr[i];
            if (arr[i] < minval)
                minval = arr[i];
            if (arr[i] > maxval)
                maxval = arr[i];
        }
        Console.WriteLine("{0} {1}", totalsum - maxval, totalsum - minval);

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
