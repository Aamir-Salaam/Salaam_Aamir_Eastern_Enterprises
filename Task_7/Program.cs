using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1;
using System.Text.RegularExpressions;

namespace Task_7
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

                if (type == "sum" || type == "add")
                {

                    string[] inp_list = Regex.Split(param, @"\\");


                    char[] seperators = inp_list[2].ToCharArray();

                    string[] num_list = inp_list[4].Split(seperators, StringSplitOptions.RemoveEmptyEntries);

                    int neg_flag = 0;
                    List<int> neg_list = new List<int>();

                    foreach (string item in num_list)
                    {
                        int num = Convert.ToInt32(item);
                        if (num < 0)
                        {
                            neg_flag = 1;
                            neg_list.Add(num);
                        }

                        // numbers greater than 1000 not added to input numbers list
                        if (num <= 1000)
                        {
                            input_list.Add(num);
                        }
                    }

                    if (neg_flag == 1)
                    {
                        string neg_nums = "(" + string.Join(",", neg_list.ToArray()) + ")";
                        throw new CustomException("Error: Negative numbers " + neg_nums + " not allowed.");
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
