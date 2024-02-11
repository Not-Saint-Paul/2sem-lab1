using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of task: ");
            int Task = Convert.ToInt32(Console.ReadLine());

            if (Task == 1)
            {
                Console.Write("Enter a: ");
                int A = Convert.ToInt32(Console.ReadLine());
                int ADoppelganger = A;
                Console.Write("Enter n: ");
                int N = Convert.ToInt32(Console.ReadLine());
                for (int Power = 1; Power < N; ++Power)
                {
                    ADoppelganger *= A;
                }
                Console.WriteLine($"a^n= " + ADoppelganger);
                Console.ReadKey();
            }
            else if (Task == 2)
            {
                int ValueOfArray = 10;
                int[] ArrayOfX = new int[ValueOfArray]; //ArrayOfX состоит из цифр числа X, записанных начиная с цифры 0-го разряда
                int[] ArrayOfN = new int[ValueOfArray]; //ArrayOfN состоит из цифр числа N, записанных начиная с цифры 0-го разряда
                Console.Write("Enter x (x >= 100): ");
                int X = Convert.ToInt32(Console.ReadLine());

                if (X < 100)
                {
                    Console.Write("X is small! \nPlease enter x again (x >= 100): ");
                    X = Convert.ToInt32(Console.ReadLine());
                }
                if (X < 100)
                {
                    Console.Write("!!!WARNING!!! x >= 100!!! \nEnter x again: ");
                    X = Convert.ToInt32(Console.ReadLine());
                }
                if (X >= 100)
                {
                    for (int Index = 0; Index < ValueOfArray; ++Index)
                    {
                        if (ValueOfArray < Index)
                        {
                            ValueOfArray = Index + 1;
                        }
                        ArrayOfX[Index] = X % 10;
                        X /= 10;
                    }

                    for (int Index = 0; Index < ValueOfArray - 1; ++Index)
                    {
                        if (Index == 0)
                        {
                            ArrayOfN[0] = ArrayOfX[ValueOfArray - 1];
                        }
                        else if (Index < ValueOfArray - 1)
                        {
                            ArrayOfN[Index] = ArrayOfX[Index + 1];
                        }
                        else
                        {
                            ArrayOfN[Index + 1] = ArrayOfX[ValueOfArray];
                        }
                    }

                    Console.Write("n = ");
                    for (int Index = ValueOfArray - 1; Index > 0; --Index)
                    {
                        Console.Write(ArrayOfN[Index]);
                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.Write("Uhh... I said x is not large enough!!! Try in next time.");
                    Console.ReadKey();
                }

            }
            else
            {
                Console.Write("Number of task is wrong!!!");
                Console.ReadKey();
            }
        }
    }
}
