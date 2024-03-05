using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //int number = 10;

            //if(number > 0)
            //{
            //    Console.WriteLine($"{number} positive number");
            //}
            //else if( number == 0)
            //{
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine($"{number} negative number");
            //}

            //int num1 = -3;


            //if (num1 > 0)
            //{
            //    Console.WriteLine($"{num1} positive number");
            //}
            //else if (num1 == 0)
            //{
            //    Console.WriteLine(num1);
            //}
            //else
            //{
            //    Console.WriteLine($"{num1} negative number");
            //}
            //isPositive(10);
            //isPositive(-3);

            //Console.WriteLine(Sum(5, 3));

            //int[] nums = { 10, 15, 20, 25 };

            //Console.WriteLine(Sum(15,20,25,30));

            //Iki string(name, surname) parametrinin xosgelmisen mesajini qaytaran metodu yazin

            //string name = "Onur";
            //string surname = "Ismailov";

            //sayWelcome("Onur", "Ismailov");

            //sayWelcome("Onur","Abdullayev");

            Console.WriteLine(FindSpace("     "));



        }


        //Gonderilmish string parametrinde neche dene boshlug oldugunu tapan methodu yazin.

        static int FindSpace(string word)
        {
            int count = 0;
            for(int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                {
                    count++;
                }
            }
            return count;
        }

        //static string reverseWord(string word)
        //{
        //    string result = "";

        //    for(int i = word.Length-1; i>=0; i--)
        //    {
        //        result += word[i];
        //    }
        //    return result;
        //}

        //static void SayWelcome(string name, string surname="Ismailov")
        //{
        //    Console.WriteLine($"{name} {surname} xosh gelmisiniz");
        //}

        static void isPositive(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"{number} positive number");
            }
            else if (number == 0)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine($"{number} negative number");
            }
        }

        //static int Sum(int a, int b)
        //{
        //    return a + b;
        //}

        //static int Sum(double number1, int number2)
        //{
        //    return 0;
        //}

        //static int Sum(params int[] nums)
        //{
        //    int sum = 0;

        //    foreach (int num in nums)
        //    {
        //        sum += num;
        //    }
        //    return sum;
        //}

        //Pascal Case
        //camel Case
        // sneake Case
        // full_name;
        // Kebab Case
        // full-name-surname;

        //stat

    }
}
