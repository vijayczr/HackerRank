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
     * Complete the 'weightedUniformStrings' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER_ARRAY queries
     */

    public static List<string> weightedUniformStrings(string s, List<int> queries)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>
        {
            {'a',1},{'b',2},{'c',3},{'d',4},{'e',5},{'f',6},{'g',7},{'h',8},{'i',9},{'j',10},{'k',11},{'l',12},{'m',13},{'n',14},{'o',15},{'p',16},{'q',17},{'r',18},{'s',19},{'t',20},{'u',21},{'v',22},{'w',23},{'x',24},{'y',25},{'z',26}
        };
        List<int> res = new List<int>();
        int curVal = dict[s[0]];
        res.Add(curVal);
        for(int i =1; i < s.Length; i++)
        {
            if (s[i] == s[i-1])
            {
                curVal += dict[s[i]];
            }
            else
            {
                curVal = dict[s[i]];
            }
            res.Add(curVal);
        }
        List<string> list = new List<string>();
        foreach(var data in queries)
        {
            if (res.Contains(data))
            {
                list.Add("Yes");
            }
            else
            {
                list.Add("No");
            }
        }
        return list;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the string");
        var s  = Console.ReadLine();
        Console.WriteLine("Enter the amount of queries you have");
        int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());
        Console.WriteLine("Enter the queries");
        List<int> queries = new List<int>();

        for (int i = 0; i < queriesCount; i++)
        {
            int queriesItem = Convert.ToInt32(Console.ReadLine().Trim());
            queries.Add(queriesItem);
        }

        List<string> result = Result.weightedUniformStrings(s, queries);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}