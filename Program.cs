using System;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Задача 2
            /*
            Console.WriteLine("Программа определяет максимальное и минимальное число");
            Console.Write("Введите первое число ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2){
                Console.WriteLine("Максимальное число: " + num1);
                Console.WriteLine("Минимальное число: " + num2);
            }
            else{
                Console.WriteLine("Максимальное число: " + num2);
                Console.WriteLine("Минимальное число: " + num1);
            }
            */


            // Задача 4
            /*
            Console.WriteLine("Программа определяет максимальное число из трех");
            Console.Write("Введите первое число ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int max;

            if(num1 > num2){
                max = num1;
            }
                else{
                max = num2;
            }

            if(num3 > max){
                Console.Write("Максимальное число: " + num3);
            }
            else{
                Console.Write("Максимальное число: " + max);
            }
            */


            // Задача 6
            /*
            Console.WriteLine("Программа определят число четное или нечетное");
            Console.Write("Введите число ");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num % 2 == 0) Console.Write("Число четное");
            else Console.Write("Число нечетное");
            */


            // Задача 8
            Console.WriteLine("Программа выдает все четные числа от 1 до числа N");
            Console.Write("Введите число ");
            int num = Convert.ToInt32(Console.ReadLine());
            int current = 0;

            if(num > 0)
                while(current <= num)
                {
                    if(current % 2 == 0)
                        Console.Write(current + " ");
                        current++;
                }
            else Console.Write("Введите положительное число!");

        }
    }
}
