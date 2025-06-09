using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {


        static int CalculateArea(int leght, int winght)
        {
            for (int i = 0; i < winght; i++)
            {
                if (i == 0 || i == winght - 1)
                {
                    Console.WriteLine(new string('+', leght));



                }
                else
                {
                    Console.WriteLine("*" + new string('+', leght - 2) + "*");
                }

            }
            return leght * winght;


        }
        static void Main(string[] args)
        {

            Console.WriteLine("Ведите ширину : ");
            int winght = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длинну : ");
            int leght = int.Parse(Console.ReadLine());

            int heli = CalculateArea(leght, winght);

            Console.WriteLine($"Площадь прямоугольника равна : {heli}");





        }

    }

}

