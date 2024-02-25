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
     * Complete the 'balancedSums' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static string balancedSums(List<int> arr)
    {

        int totalsum = arr.Sum();
        if (totalsum - arr[0] == 0)
        {
            return "YES";
        }
        int leftsum = arr[0];
        int rightsum = totalsum - arr[0] - arr[1];
        if (arr.Count() == 1)
        {
            return "YES";
        }
        if (arr.Count() == 2)
        {
            return "NO";
        }
        if (leftsum == rightsum)
        {
            return "YES";
        }
        else
        {
            int i = 2;
            for (; i < arr.Count(); i++)
            {
                leftsum += arr[i - 1];
                rightsum -= arr[i];
                if (leftsum == rightsum)
                {
                    return "YES";
                }
            }
            if (i == arr.Count())
            {
                return "NO";
            }
        }
        return "NO";

    }


}

class Solution
{
    public static void Main(string[] args)
    {

        int T = Convert.ToInt32(Console.ReadLine().Trim()); 
        List<string> res = new List<string>();

        for (int TItr = 0; TItr < T; TItr++) 
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            string result = Result.balancedSums(arr);
            res.Add(result);
        }
        foreach (string s in res)
        {
            Console.WriteLine(s);  
        }
    }
}
