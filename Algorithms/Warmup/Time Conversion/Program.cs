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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        var amorpm = s.Substring(8);
        var houres = s.Substring(0, 2);
        var remaintime = s.Substring(2, 6);
        if (houres == "12" && amorpm == "AM")
        { houres = "00"; }
        else if (amorpm == "PM")
        {
            var intehours = int.Parse(houres);
            if (intehours != 12)
            { houres = Convert.ToString(intehours + 12); }
        }
        return houres + remaintime;
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        Console.WriteLine(result);
    }
}
