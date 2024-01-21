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

    public static List<int> getMax(List<string> operations)
    {
        Queue<int> data = new Queue<int>();
        List<int> res = new List<int>();
        foreach (var x in operations)
        {
            var m = x[0];
            if (m == '1')
            {
                var toadd = int.Parse(x.Split(' ')[1]);
                data.Enqueue(toadd);
            }
            else if (m == '2')
            {
                data.Dequeue();
            }
            else if (m == '3')
            {
                var h = data.Peek();
                res.Add(h);
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

        List<int> res = Result.getMax(ops);
        foreach (var item in res)
        {
            Console.WriteLine(item); ;
        }
    }
}

