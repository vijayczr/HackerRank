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
     * Complete the 'matchingStrings' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. STRING_ARRAY stringList
     *  2. STRING_ARRAY queries
     */

    public static List<int> matchingStrings(List<string> stringList, List<string> queries)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < queries.Count(); i++)
        {
            int x = 0;
            for (int j = 0; j < stringList.Count(); j++)
            {
                if (string.Equals(stringList[j], queries[i]))
                {
                    x++;
                }
            }
            result.Add(x);
        }
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the arrays!");

        int stringListCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> stringList = new List<string>();

        for (int i = 0; i < stringListCount; i++)
        {
            string stringListItem = Console.ReadLine();
            stringList.Add(stringListItem);
        }

        int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> queries = new List<string>();

        for (int i = 0; i < queriesCount; i++)
        {
            string queriesItem = Console.ReadLine();
            queries.Add(queriesItem);
        }

        List<int> res = Result.matchingStrings(stringList, queries);
        foreach (int i in res)
        {
            Console.WriteLine(i);
        }
    }
}
