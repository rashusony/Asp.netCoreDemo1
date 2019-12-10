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

class Solution
{

    // Complete the compareTriplets function below.
    static List<int> compareTriplets(List<int> a, List<int> b)
    {

        int[] alice = new int[a.Count];

        int[] bob = new int[b.Count];

        int sum_a = 0;
        int sum_b = 0;

        List<int> result = new List<int>();

        int j = 1, k = 1;

        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] <= 100 && a[i] >= 1 || b[i] <= 100 && b[i] >= 1)
            {
                if (a[i] > b[i])
                {
                    alice[i] = j;

                }

                else if (b[i] > a[i])
                {
                    bob[i] = k;

                }

                else if (a[i] == b[i])
                    continue;
            }

        }

        for (int i = 0; i < alice.Length; i++)
        {
            sum_a += alice[i];
        }

        for (int i = 0; i < bob.Length; i++)
        {
            sum_b += bob[i];
        }
        result.Add(sum_a);
        result.Add(sum_b);

        return result;

    }

    static void Main(string[] args)
    {

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = compareTriplets(a, b);

        Console.WriteLine(String.Join(" ", result));

       
    }
}
