using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    /// <summary>
    /// Custom Exceptions class to display custom error messages
    /// </summary>
    public class CustomException : System.Exception
    {
        public CustomException()
        {

        }

        /// <summary>
        /// Set the custom error message
        /// </summary>
        /// <param name="msg"></param>
        public CustomException(string msg) : base(msg)
        {

        }
    }

    public class Program
    {
        /// <summary>
        /// To store the result of operation, for testing purposes
        /// </summary>
        public int ResultSum { get; set; }

        static void Main(string[] args)
        {
            Program p = new Program();

            p.BootStrapper(args);

        }


        /// <summary>
        /// To implement test driven approach, this Bootstrapper method has been created
        /// </summary>
        /// <param name="args"></param>
        public void BootStrapper(string[] args )
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

                if (type == "sum" || type == "add")
                {

                    string[] num_list = param.Split(',');

                    foreach (string item in num_list)
                    {
                        input_list.Add(Convert.ToInt32(item));
                    }

                    if (input_list.Count > 2)
                    {
                        throw new CustomException("Input numbers limit exceeded. Max input limit is 2.");
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
                // to represent failed operation result at time of testing
                ResultSum = -1;
                Console.WriteLine("\n" + cexp.Message);
            }
            catch (Exception ex)
            {
                // to represent failed operation result at time of testing
                ResultSum = -1;
                Console.WriteLine("\n" + ex.Message);
            }
        }
    }
}
