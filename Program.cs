using System;
using System.Collections.Generic;
using Lab.cerber;

namespace Lab
{   
    class Program
    {
        static void Main(string[] args)
        {
            MyLog.Instance().Log("Начало программы.");

            float a = 0;
            float b = 0;
            float c = 0;

            while (true)
            {
                Console.WriteLine("Введите коэффициенты:");

                try
                {
                    a = float.Parse(Console.ReadLine());
                    b = float.Parse(Console.ReadLine());
                    c = float.Parse(Console.ReadLine());

                    break;
                }
                catch (Exception ex)
                {                    
                    Console.WriteLine("Коэффициент введен неверно. Попробуйте еще раз\n");
                    MyLog.Instance().Log("Введен неверный коэффициент. Исключение: " + ex.Message);
                }                
            }

            MyLog.Instance().Log("Введены коэффициенты: a = " + a.ToString() + ", b = " + b.ToString() + ", c = " + c.ToString());

            Quadratic solver = new Quadratic();
            try
            {
                List<float> roots = solver.Solve(a, b, c);

                string resultString = "";
                foreach (float root in roots)
                {
                    resultString += root.ToString() + " ";
                }

                MyLog.Instance().Log("Корни найдены. Результат: " + resultString);
            }
            catch (CerberException ex)
            {
                MyLog.Instance().Log("Ошибка: " + ex.Message);
            }

            MyLog.Instance().Write();
            
            Console.ReadKey();
        }
    }
}