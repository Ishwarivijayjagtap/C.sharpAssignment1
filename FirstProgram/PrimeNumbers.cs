using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    internal class PrimeNumbers
    {
   
        static void Main(string[] args)
        {
           

            for (int i = 2; i <= 100; i++)
            {
                int counter = 0;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }
                
                if (counter == 0 && i != 1)
                {
                    Console.WriteLine(i);
                }    
            }
            Console.WriteLine();
        }
    }
}
            
    
