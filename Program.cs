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
        }
    }
}
