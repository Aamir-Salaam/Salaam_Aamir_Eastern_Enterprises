using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1;
using System.Text.RegularExpressions;

namespace Task_8
{
    public class Program
    {
        /// <summary>
        /// to store result of operation
        /// </summary>
        public int ResultProduct { get; set; }


        /// <summary>
        /// To implement test driven approach, this Bootstrapper method has been created
        /// </summary>
        /// <param name="args"></param>
        public void BootStrapper(string[] args)
        {
            try
            {
                List<int> numbers_list = new List<int>();

                Calculator calc = new Calculator();

                int product = 0;

                string type, param;

                if (args.Length <= 0)
                {
                    throw new CustomException("Invalid Input !!");
                }
                else if (args.Length == 1)
                {
                    type = args[0];
                    param = "0";
                }
                else
                {
                    type = args[0];
                    param = args[1];
                }

                // preprocessor function called to process the input paramaters
                numbers_list = Preprocessor.InputProcessor(param);

                if (type == "multiply")
                {
                    product = calc.Multiply(numbers_list);

                    Console.Write("\nThe product of the numbers is : ");

                    Console.WriteLine(product);

                    ResultProduct = product;
                }

            }
            catch (CustomException ce)
            {
                ResultProduct = -1;
                Console.WriteLine("\n" + ce.Message);
            }
            catch (Exception ex)
            {
                ResultProduct = -1;
                Console.WriteLine("\n" + ex.Message);
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            p.BootStrapper(args);

        }
    }
}
