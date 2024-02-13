using System;

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
                
                Console.Write("Enter x (x >= 100): ");
                string X = Convert.ToString(Console.ReadLine());

                if (int.Parse(X) < 100)
                {
                    Console.Write("X is small! \nPlease enter x again (x >= 100): ");
                    X = Convert.ToString(Console.ReadLine());
                }
                if (int.Parse(X) < 100)
                {
                    Console.Write("!!!WARNING!!! x >= 100!!! \nEnter x again: ");
                    X = Convert.ToString(Console.ReadLine());
                }
                if (int.Parse(X) >= 100)
                {
                    X = X.Remove(1, 1) + X[1];

                    Console.Write("n = ");
                    
                    Console.Write(X);
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
