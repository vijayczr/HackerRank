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
    public static string isBalanced(string s)
    {
        Stack<char> data = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '{')
            {
                data.Push('}');
            }
            else if (s[i] == '[')
            {
                data.Push(']');
            }
            else if (s[i] == '(')
            {
                data.Push(')');
            }
            else
            {
                if (data.Count() == 0 || s[i] != data.Peek())
                {
                    return "NO";
                }
                else
                {
                    data.Pop();
                }
            }

        }
        if (data.Count() == 0)
        {
            return "YES";
        }
        else { return "NO"; }
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string s = Console.ReadLine();

            string result = Result.isBalanced(s);

            Console.WriteLine(result);
        }
    }
}
