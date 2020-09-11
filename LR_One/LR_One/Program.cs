using System;
using System.Dynamic;
using System.Linq.Expressions;

namespace LR_One
{
    class Program
    {
        static void Main(string[] args)
        {
            bool console = true;
            int Ind_Zadanie;
            while (console = true)
            {
                Console.Write("Введите число {0} или {1} для выполнения работы. Для выхода из консольного приложения введите число {2}: ", 1, 2, 0);
                Ind_Zadanie = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Clear();
                if (Ind_Zadanie == 1)
                {
                    Console.WriteLine("Лабораторная работа №1. Разработка консольного приложения");
                    Console.WriteLine("Свидницкий Алексей Дмитриевич");
                    Console.WriteLine("Информационные системы и технологии, ИНС-б-о-18-2");
                    Console.WriteLine("Город Надым, Ямало-Ненецкий автономный округ");
                    Console.WriteLine("Информатика");
                    Console.WriteLine("Занимаюсь активным спортом - волейбол, занимаюсь программированием, но хочется заняться основой Unity, но мне нужна книга, для дальнейшего изучения.");
                    Console.WriteLine();
                }
                if (Ind_Zadanie==2)
                {
                    bool l = true;
                    while (l == true)
                    {
                        Console.WriteLine("Вариант задания: 27");
                        double Zze, dd, y;
                        Console.WriteLine();
                        Console.WriteLine("Дано задание: Zze = (35/dd) + y * dd - ((dd + y)/(4 * y))");
                        Console.WriteLine();
                        Console.Write("Введите число для dd: ");
                        dd = Convert.ToInt32(Console.ReadLine());
                        while (dd == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Произошла ошибка!!!");
                            Console.WriteLine("Похоже вы ввели цифру 0, введите еще раз правильно");
                            Console.WriteLine();
                            Console.Write("Введите число для dd: ");
                            dd = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine();
                        Console.Write("Введите число для y: ");
                        y = Convert.ToInt32(Console.ReadLine());
                        while (y == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Произошла ошибка!!!");
                            Console.WriteLine("Похоже вы ввели цифру 0, введите еще раз правильно");
                            Console.WriteLine();
                            Console.Write("Введите число для y: ");
                            y = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine();
                        Zze = (35 / dd) + y * dd - ((dd + y) / (4 * y));
                        Console.WriteLine("Ответ Zze: {0:N5}", Zze);
                        Console.WriteLine();
                        l = false;
                    }
                    l = true;
                }
                if (Ind_Zadanie == 0)
                {
                    Console.WriteLine("Выполняется выход из консольного приложения");
                    break;
                }
            }
        }
    }
}
