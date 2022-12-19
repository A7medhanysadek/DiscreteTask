using System.Collections.Generic;
using System.Numerics;

namespace HelloWorldApplication
{
    class HelloWorld
    {
        static void Main(string[] args)
        {   
            double n1, n2, r , factors_sum = 0;
            // the next code will take the first number from the user and assign the value to the "n1" variable
            Console.WriteLine("enter the first number");
            n1 = double.Parse(Console.ReadLine());
            //the next code will take the last number from the user and assign the value to the "n2" variable
            Console.WriteLine("enter the last number");
            n2 = double.Parse(Console.ReadLine());
            /* Here the code will do a nested loop to calculate the remainder of the division between the first number "n1"(i) (entered by the user) and all of the numbers from "z"=1 to the last number "n2" (entered by the user).
             * If the remainder of the division is 0 (this means that z is a factor of "n1") and "n1"(i) is not equal to 1 the code will check if z = i (nested if), if the condition value is true the code will skip to the next division (means that we will ignore "z" value if it is equal to "n1"(i) value because we want to add "n1" factors without "n1" value) else the code will add "z" value (factor of n1) to "factors_sum" variable else the code will skip to the next division.
             * after the inner loop is finesh the code will check if "factors_sum" value = "n1"(i) value (check if "n1" is prime number or not), if the condition value is true, the code will print "n1"(i) value else the code will set "factors_sum" to 0.*/
            for (double i = n1; i <= n2; i++)
            {
                for (double z = 1; z <= n2; z++)
                {
                    if ((i % z == 0) & (i != 1))
                    {
                        if (z == i)
                        {
                            continue;
                        }
                        else
                        factors_sum += z;
                    }
                    else
                        continue;
                }
                if (factors_sum == i)
                {
                    Console.WriteLine(i);
                }
                else
                factors_sum = 0;
            }


        }
    }
}
