using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1;

namespace Task_2
{
    public class Program
    {
        /// <summary>
        /// property created to store the result of operation
        /// </summary>
        public int ResultSum { get; set; }


        /// <summary>
        /// To implement test driven approach, this Bootstrapper method has been created
        /// </summary>
        /// <param name="args"></param>
        public void BootStrapper( string[] args)
        {
            try
            {
                List<int> input_list = new List<int>();
                int sum = 0;

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

                Calculator calc = new Calculator();

                if (type == "add" || type == "sum")
                {

                    string[] num_list = param.Split(',');

                    foreach (string item in num_list)
                    {
                        input_list.Add(Convert.ToInt32(item));
                    }

                    sum = calc.Add(input_list);

                    Console.Write("\nThe sum of the numbers is : ");

                    Console.WriteLine(sum);

                    ResultSum = sum;

                }
                else
                {
                    throw new CustomException("Invalid Operation type.");
                }

            }
            catch (CustomException cexp)
            {
                ResultSum = -1;
                Console.WriteLine("\n" + cexp.Message);
            }
            catch (Exception ex)
            {
                ResultSum = -1;
                Console.WriteLine("\n" + ex.Message);
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            p.BootStrapper( args );
        }
    }
}
