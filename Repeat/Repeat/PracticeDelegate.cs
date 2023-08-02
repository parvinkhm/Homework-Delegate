using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat
{
    internal class PracticeDelegate
    {
        //public delegate bool CheckNums(int num);

        //public delegate void ChangeStr(string str);

        //public delegate int CheckLenght(string str);


        //public void StrToLower(string str)
        //{
        //    Console.WriteLine(str.ToLower());
        //}

        //public void StrToUpper(string str)
        //{
        //    Console.WriteLine(str.ToUpper());
        //}


        public int GetLength(string text, int num)
        {
            return text.Length + num;
        }


        //public bool CheckOddNums(int number)
        //{
        //    return number % 2 == 1;
        //}


        //public bool CheckEvenNums(int number)
        //{
        //    return number % 2 == 0;
        //}

        //public bool CheckGreaterFiveNums(int number)
        //{
        //    return number > 5;
        //}

        //public bool CheckOddNums(int number)
        //{
        //    return number % 2 == 1;
        //}



        public void ExecuteMethod()
        {
            /*SumNumbers(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12 }, m => m%2 == 1)*/;
            //SumNumbers(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12 }, CheckOddNums);
            //SumNumbers(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12 }, CheckEvenNums);
            //SumNumbers(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12 }, CheckGreaterFiveNums);
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 9, 12 };

            //var result = numbers.Where(m => m%2 == 1). Sum(m => m);

            //var data = numbers.FirstOrDefault(m => m > 5);

            //Console.WriteLine(result);


            //GetString("Salam", StrToLower);

            //Action<string> func = new Action<string>(StrToUpper);

            //func.Invoke("Salamlar");


            //Action<string> func = StrToUpper;

            //func += StrToLower;

            //func.Invoke("Salamlar");

            //GetStringLength("salam", GetLength);

            Func<string, int, int> func = GetLength;

            Console.WriteLine(func.Invoke("salam", 100));

        }


        //private void GetStringLength(string str, Func<string, int, int> func)
        //{
        //    Console.WriteLine(func(str, 12));
        //}




        //private void GetStringLength(string str, CheckLenght func)
        //{
        //    Console.WriteLine(func(str));
        //}



        //private void GetString(string str, Action<string> func)
        //{
        //    func(str);
        //}




        //private void GetString(string str, ChangeStr func)
        //{
        //    func(str);
        //}





        //private void SumNumbers(List<int> numbers, Predicate<int> func)
        //{
        //    int sum = 0;
        //    foreach (int number in numbers)
        //    {
        //        if (func(number))
        //        {
        //            sum += number;
        //        }
        //    }

        //    Console.WriteLine(sum);
        //}



        //private void SumNumbers(List<int> numbers, CheckNums func)
        //{
        //   int sum = 0;
        //   foreach (int number in numbers)
        //   {
        //     if (func(number))
        //     {
        //       sum += number;
        //     }
        //   }

        //   Console.WriteLine(sum);
        //}

    }


    //private void SumOfEvenNumbers(List<int> numbers)
    //{
    //    int sum = 0;
    //    foreach (int number in numbers)
    //    {
    //        if (number % 2 != 1)
    //        {
    //            sum += number;
    //        }
    //    }

    //    Console.WriteLine(sum);
    //}



    //private void SumOfGreaterFourNumbers(List<int> numbers)
    //{
    //    int sum = 0;

    //    foreach (int number in numbers)
    //    {
    //        if (number > 4)
    //        {
    //            sum += number;
    //        }
    //    }

    //    Console.WriteLine(sum);
    //}


}
