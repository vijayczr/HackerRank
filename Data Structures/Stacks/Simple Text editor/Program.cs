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
     * Complete the 'getMax' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts STRING_ARRAY operations as parameter.
     */

    public static List<string> getMax(List<string> operations)
    {
        Stack<string> undoed = new Stack<string>();
        StringBuilder str = new StringBuilder();
        List<string> res = new List<string>();
        for (int i = 0; i < operations.Count(); i++)
        {
            var data = operations[i].Split(" ");
            var len = str.Length;
            if (data[0] == "1")
            {
                if (len == 0)
                {
                    undoed.Push("");
                }
                else { undoed.Push(str.ToString()); }
                str.Append(data[1]);
            }
            else if (data[0] == "2")
            {
                undoed.Push(str.ToString());
                str.Remove(len - int.Parse(data[1]), int.Parse(data[1]));
            }
            else if (data[0] == "3")
            {
                res.Add(str[int.Parse(data[1]) - 1].ToString());
            }
            else if (data[0] == "4")
            {
                str.Clear();
                str.Append(undoed.Pop());
            }
        }
        return res;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> ops = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string opsItem = Console.ReadLine();
            ops.Add(opsItem);
        }

        List<string> res = Result.getMax(ops);
        foreach (string opsItem in res)
        {
            Console.WriteLine(opsItem);
        }
    }
}
