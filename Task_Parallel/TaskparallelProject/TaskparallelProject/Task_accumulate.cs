using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskparallelProject
{
    class Task_accumulate
    {
                   private static int accumulator = 0;
            static void Main(string[] args)
            {
                for (int i = 0; i < 100; i++)
                {
                    AddToAccumulator(i);
                }
                Console.WriteLine("Accumulator is {0} ", accumulator);
                 Console.ReadKey();
        }
            private static void AddToAccumulator(int data)
            {
                if ((accumulator % 2) == 0)
                {
                    accumulator += data;
                }
                else
                {
                    accumulator -= data;
                }
            }
        }
    }

