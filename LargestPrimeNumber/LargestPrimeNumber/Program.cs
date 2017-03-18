using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 600851475143;
            long primeFactor = 600851475142;
            bool run = true;
            long i = 2;
            long factor = 600851475143 / 2;

            for (; factor > 1; factor--)
            {

                if (number % factor == 0)
                {
                    bool is_primeFactor = true;
                    for (; i < factor / 2; i++)
                    {
                        
                      
                            if (factor % i == 0)
                            {
                                is_primeFactor = false;
                                break;
                            }
                            
                        
                    }
                    if (is_primeFactor)
                    {
                        primeFactor = factor;
                        break;
                    }

                   
                }
                //if number = 20, output = 5
                //if number = 5609, output = 79
                
            }
            Console.WriteLine(primeFactor);
            Console.Read();
            
         }      
    }
}
