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

class Solution {

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {
        var positive=0;
        var negative=0;
        var zero=0;
       foreach(var arrvalue in arr)
        {
            if(arrvalue>0)
            {
                positive++;
            }
            else if(arrvalue <0)
            {
                negative++;
            }
            else
            {
                zero++;
            }
 
        }
Console.WriteLine(string.Format("{0:0.000000}",(decimal)positive/arr.Count()));
Console.WriteLine(string.Format("{0:0.000000}",(decimal)negative/arr.Count()));
Console.WriteLine(string.Format("{0:0.000000}",(decimal)zero/arr.Count()));

    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
