using System;

namespace Fromatob
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();

            int a = int.Parse(inputs[0]);

            int b = int.Parse(inputs[1]);
            
            int count = 0;

            while (a != b)
            {
                if (a < b)
                {
                    a++;
                    count++;
                   }
                    if (a > b)
                    {
                        if (a%2 == 0)
                        {
                            a = a / 2;
                            count++;
                        }
                        else 
                        {
                            
                            a = (a + 1) / 2;
                            count += 2;
                        }
                    }

                }
                Console.WriteLine(count);
            }
        }
    }
