﻿using System.CodeDom.Compiler;
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
     * Complete the 'birthdayCakeCandles' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY candles as parameter.
     */

    public static int birthdayCakeCandles(List<int> candles)
    {
        int longest = 0;
        int sol = 0;
        for (int i = 0; i < candles.Count(); i++)
        {
            if (candles[i] > longest)
                longest = candles[i];
        }
        for (int i = 0; i < candles.Count(); i++)
        {
            if (longest == candles[i])
                sol = sol + 1;
        }
        return sol;

    }

}

class Solution
{
    public static void Main(string[] args)
    {

        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

        int result = Result.birthdayCakeCandles(candles);
        Console.WriteLine(result);
    }
}
