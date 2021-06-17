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
     * Complete the 'beautifulTriplets' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER d
     *  2. INTEGER_ARRAY arr
     */

    public static int beautifulTriplets(int d, int[] a)
    {
        var begin = 0;
            var end = 0;
            var found = 0;
            var cnt = 0;
            while (begin < a.Length)
            {
                end++;
                if (end < a.Length)
                {
                    if (found == 1 && a[end] - a[begin] == 2 *d || found == 0 && a[end] - a[begin] == d)
                    {
                        if (found == 1)
                        {
                            cnt++;
                            found = 0;
                            begin++;
                            end = begin;
                        }
                        else
                        {
                            found++;
                        }
                    }
                }
                else
                {
                    begin++;
                    end = begin;
                    found = 0;
                }
            }

            return cnt;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int d = Convert.ToInt32(firstMultipleInput[1]);

        int[] arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToArray();

        int result = Result.beautifulTriplets(d, arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
