using ClassDelegate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using static ClassDelegate.Program;

namespace ClassDelegate
{
    class Program
    {
        // public delegate bool CheckNums(int num);

        //public delegate void ChangeString(string str, int age);

        //public delegate int StringLenght(string str);

        static void Main(string[] args)
        {


            #region Predicate
            //int[] arr = { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine(Sum(CheckGraterThankFour, arr));

            //List<int> list = new List<int> { 9, 14, 21, 16, 5, 6, 7,42, 9 };
            //var result = SumOfNumbersDividedBy3And7(CheckNumbersDividedBy3And7, list);
            //Console.WriteLine(result);

            //var result = nums.FindAll(m => m%2==0 && m>3);
            //Console.WriteLine(result.Count);

            //Console.WriteLine(list.FindAll(m => m % 3 == 0 && m % 7 == 0).Sum(m => m));
            #endregion


            //string name = "Nihad";

            // ShowString(StringToUpper, name, 20);

            //ChangeString func = StringToUpper;

            //func += delegate (string str, int age)
            //{
            //    Console.WriteLine(str.ToLower() + "-Age:" + age);
            //};

            //func += (str, age) => Console.WriteLine(str.ToLower() + "-Age:" + age);
            //func.Invoke("Anar", 35);

            //Action<string, int> action = StringToLower;
            //action.Invoke("Orxan", 66);

            //string name = "Nihad";

            //ShowString(StringToUpper, name, 20);

            //Action action = Test;
            ////action.Invoke();
            //action();

            //PowerOfNumber(CalculatePower, 3, 2);
            //Action<int, int> action = CalculatePower;
            // action.Invoke(4, 2);

            //var result = ShowStringLength(GetStringLength, "Gultac");
            //Console.WriteLine(result);

            //Func<string, int> func = GetStringLength;

            //var res = func("Lale");

            //Console.WriteLine(res);

            //ShowFatorial(GetFactorial, 5);

        }



        //public static int GetFactorial(int num)
        //{
        //    int res = 1;
        //    while (num != 1)
        //    {
        //        res = res * num;
        //        num = num - 1;
        //    }
        //    return res;
        //}
         
        //public static void ShowFatorial(Func<int,int>function, int num)
        //{
        //    Console.WriteLine(function(num));
        //}

        
        //public static int GetStringLength(string str)
        //{
        //    return str.Length;   
        //}


        //public static int ShowStringLength(Func<string,int> func, string word)
        //{
        //    return func(word);
        //}
        //public static void CalculatePower(int number, int power)
        //{
        //    Console.WriteLine(Math.Pow(number, power));
        //}

        //public static void PowerOfNumber(Action<int,int> func, int num,int pow)
        //{
        //    func(num, pow);
        //}




        //public static void Test()
        //{
        //    Console.WriteLine("test");
        //}
        //public static void StringToLower(string str, int age)
        //{
        //    Console.WriteLine(str.ToLower() + "- Age :" + age);
        //}

        //public static void StringToUpper(string str, int age)
        //{
        //    Console.WriteLine(str.ToUpper() + "- Age:" + age);
        //}

        //public static void ShowString(Action<string,int> func, string str, int age)
        //{
        //    func(str, age);
        //}




        //public static bool CheckNumbersDividedBy3And7(int num)
        //{
        //    return num % 3 == 0 && num % 7 == 0;
        //}
        //public static int SumOfNumbersDividedBy3And7(Predicate<int> predicate, List<int> list)
        //{
        //    int sum = 0;

        //    foreach (var item in list)
        //    {
        //        if (predicate(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}


        //public static bool CheckGraterThankFour(int number)
        //{
        //    return number >= 4;
        //}


        //public static bool CheckOddNums(int number)
        //{
        //    return number % 2 != 0;
        //}

        //public static bool CheckEvenNums(int number)
        //{
        //    return number % 2 == 0;
        //}




        //public static int Sum(Predicate<int> predicate, int[]arr)
        //{
        //    int sum = 0;
        //    foreach (var item in arr)
        //    {
        //        if (predicate(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}






    }
}
