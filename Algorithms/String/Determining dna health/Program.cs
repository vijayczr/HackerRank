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

public class Result
{
    public int Health(int first ,int Last, List<string> genes ,List<int> health,string d)
    {
        int value = 0;
        for(int i = first; i <= Last; i++)
        {
            int m = genes[i].Length;
            for (int j = 0; j < d.Length-m+1; j++)
            {
                if (genes[i] == d.Substring(j, m))
                {
                    value += health[i];
                }
            }
        }
        return value;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> genes = Console.ReadLine().TrimEnd().Split(' ').ToList();

        List<int> health = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(healthTemp => Convert.ToInt32(healthTemp)).ToList();

        int s = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> and = new List<int>();
        Result result = new Result();

        for (int sItr = 0; sItr < s; sItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int first = Convert.ToInt32(firstMultipleInput[0]);

            int last = Convert.ToInt32(firstMultipleInput[1]);

            string d = firstMultipleInput[2];

            int z = result.Health(first, last, genes, health,d);
            and.Add(z);
        }
        Console.WriteLine(and.Min() + " " + and.Max());
    }
}