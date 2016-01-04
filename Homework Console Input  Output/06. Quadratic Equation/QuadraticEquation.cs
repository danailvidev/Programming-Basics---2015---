using System;

namespace _06.Quadratic_Equation
{
    class QuadraticEquation
    {
        //Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it(prints its real roots).
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double D = (b * b) - 4 * a * c;  //D = b2 - 4ac
            
            if (D < 0)                                                  //Ako D < 0, квадратното уравнение няма реални корени
            {
                Console.WriteLine("no roots");
            }
            else if (D == 0)                                            //Ako D = 0, уравнението има 1 реален корен x=−b2a
            {
                Console.WriteLine(-b / (2 * a) + ":one root");
            }
            else                                                        //Ako D > 0, квадратното уравнение има 2 реални корена.
            {
                double x1 = (-b + Math.Sqrt(D)) / 2 * a;
                double x2 = (-b - Math.Sqrt(D)) / 2 * a;              
                Console.WriteLine($"root1: {x1}\nroot2:{x2}");
                /*2	5	-3	x1=-3; x2=0.5 има грешка в заданието(отговорите). скъса ми нервите тая задача докато го открия това :))*/
            }
        }
    }
}
