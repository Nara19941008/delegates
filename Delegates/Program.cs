using System;
using System.Collections.Generic;

namespace Delegates
{
    class Program
    {


        //public delegate void ChangeString(string str);

        //public delegate string StringLength(string str,int m);


        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };

            //Console.WriteLine(Sum(CheckOdd,arr));

            //Console.WriteLine(Sum(CheckEven,arr));

            //Console.WriteLine(Sum(CheckMoreThanFive,arr));


            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = numbers.FindAll(m => m > 6 && m < 9);

            //var result2 = numbers.FindAll(CheckMoreThanFive);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //Test(StringToUpper, "Cavid");




            //ChangeString change = StringToUpper;
            //change += StringToLower;

            //change += delegate (string s)
            //{
            //      Console.WriteLine(s.ToLower());
            //};

            //change += s => Console.WriteLine(s.ToLower());
            //change("Orxan");


            //Action<string,int,string> action = StringToUpper;

            //action += StringToLower;

            //action += delegate (string s, int m, string c)
            //  {
            //      Console.WriteLine(s.ToLower() + "-" + m + c);
            //  };

            //action("Orxan",55,"P130");



            //Console.WriteLine(Test(StrLength, "Mirsamir", 22));

        //    Func<string, int, string> func = StrLength;

        //    Console.WriteLine(func("Emil",17));

        //}

        //public static string StrLength(string str, int m)
        //{
        //    return str.Length.ToString() + "-Age:"+ m;
        //}

        //public static string Test(StringLength func,string str,int m)
        //{
        //    return func(str, m);
        //}

        //public static void Test() => Console.WriteLine("Tested");
        


        //public static void StringToUpper(string str,int n,string t)
        //{
        //    Console.WriteLine(str.ToUpper()+"-"+n+t);
        //}


        //public static void StringToLower(string str, int n,string t)
        //{
        //    Console.WriteLine(str.ToLower() + "-" + n+t);
        //}

        //public static void Test(ChangeString func,string str)
        //{
        //    func(str);
        //}



        //public static bool CheckOdd(int number)
        //{
        //    return number % 2 != 0;
        //}


        //public static bool CheckEven(int number)
        //{
        //    return number % 2 == 0;
        //}

        //public static bool CheckMoreThanFive(int number)
        //{
        //    return number > 6;
        //}




        //public static int Sum(Predicate<int>predicate, int[] nums)
        //{
        //    var sum = 0;

        //    foreach (var item in nums)
        //    {
        //        if (predicate(item))
        //        {
        //            sum += item;
        //        }


        //    }

        //    return sum;
        //}



        //public static int SumEven(int[] nums)
        //{
        //    var sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (item % 2 == 0)
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}




        //public static int SumMoreThanFive(int[] nums)
        //{
        //    var sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (item > 5)
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}

    }
}
