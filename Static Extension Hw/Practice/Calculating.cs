using System;
using System.Collections.Generic;
using System.Text;

namespace sdadasd_ad
{
    class Calculating : İCalculating
    {
        public double Calculate(int num1, int num2, string operation)
        {
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;



                case "-":
                    result = num1 - num2;
                    break;


                case "/":

                    result = num1 / num2;
                    break;


                case "*":
                    result = num1 * num2;
                    break;

                default:
                    
                    break;


            }

            return result;
            Console.WriteLine(result);
        }
    }
}
