using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second
{
    class Program
    {
        static void Main(string[] args)
        {
            long previous = 1;
            long prePrevius = 1;
            long curr = 0;
            long sum = 0;

            while (curr < 4000000)
            {
                if ((curr % 2) == 0)
                {
                    sum +=curr;
                }

                curr = previous + prePrevius;
                prePrevius = previous;
                previous = curr;
            }
            Console.WriteLine($" The sum is {sum}");
            /*long num = 600851475143;
            for (long i = 2; i < num; i++)
            {
                while (num % i == 0)
                {
                    num = num / i;
                }
               
            }
            if (num > 2)
            {
                Console.WriteLine($"The largest prime factor is {num}");
            }

            */
            /*
             int sum = 0;
            foreach (int value in Enumerable.Range(0,1000))
            {
                if (value % 3 == 0 || value % 5 == 0)
                {
                   sum = sum + value;
                }
                Console.WriteLine($" The sum is {sum}");
            }
             */


            /*
             int SumOfMultiples(int NN, int F)
            {
              int NumberOfMultiples = (NN-1) / F;
              int FirstMultiple = F;
              int LastMultiple = NumberOfMultiples * F;

              return NumberOfMultiples * (FirstMultiple + LastMultiple) / 2;
            }
           int N = 1000;
           int sum = SumOfMultiples(N, 3) + SumOfMultiples(N, 5) - SumOfMultiples(N, 3*5);
           Console.WriteLine($"Sum = {sum}");
             */



            // /*

            //  */

        }

    }

    // program for 8 stone puzzle
    /*class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N stone puzzle");

            // no.of stones from user
            Console.Write("Enter no.of stones : ");
            int no_of_stones = Convert.ToInt32(Console.ReadLine());

            //each stones weight from user
            List<int> weight_list = new List<int>();
            
            for (int i = 0; i < no_of_stones; i++)
            {
                Console.Write($"A{i + 1} : ");
                weight_list.Add(Convert.ToInt32(Console.ReadLine()));
            }
            if(no_of_stones < 2)
            {
                Console.WriteLine("invalid input");
                
            }
            else {
                weight_list.Sort();
                int less_weight = weight_list[0];
                int first_high_weight = weight_list[1];
                int high_weight = weight_list[no_of_stones - 1];
                int flag = 0;
                if (first_high_weight == high_weight)
                {
                    if (less_weight < first_high_weight)
                    {
                        Console.WriteLine("Less weight  =  {0}", less_weight);
                        flag++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

                for (int i = 1; i < 10; i++)
                {
                    if (no_of_stones <= Math.Pow(3, i) && flag > 0)
                    {
                        Console.WriteLine("minimum no of load balance check required is {0}", i);
                        break;
                    }
                }


            }
        }
            
    }*/
}
