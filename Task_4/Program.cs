using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Task_1;

namespace Task_4
{
    public class Program
    {
        /// <summary>
        /// to store result of operation
        /// </summary>
        public int ResultSum { get; set; }

        /// <summary>
        /// To implement test driven approach, this Bootstrapper method has been created
        /// </summary>
        /// <param name="args"></param>
        public void BootStrapper( string[] args )
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
                    // splitting on \\ to find the seperators list and numbers list
                    string[] inp_list = Regex.Split(param, @"\\");

                    // creating seperators list as character array
                    char[] seperators = inp_list[2].ToCharArray();

                    // splitting on the seperators array to get the numbers
                    string[] num_list = inp_list[4].Split(seperators, StringSplitOptions.RemoveEmptyEntries);

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

            p.BootStrapper(args);
            
        }
    }
}
