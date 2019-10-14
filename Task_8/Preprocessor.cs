using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Task_1;

namespace Task_8
{
    static class Preprocessor
    {
        /// <summary>
        /// Preprocessor method that processes the input parameters string to find out the input numbers list 
        /// </summary>
        /// <param name="param"></param>
        /// <returns name="result"></returns>
        public static List<int> InputProcessor(string param)
        {
            List<int> result = new List<int>();

            try
            {

                List<int> input_list = new List<int>();
                string[] num_list;

                if (param.Contains(@"\\"))
                {
                    string[] inp_list = Regex.Split(param, @"\\");

                    char[] seperators = inp_list[2].ToCharArray();

                    num_list = inp_list[4].Split(seperators, StringSplitOptions.RemoveEmptyEntries);

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

                }
                else if (param.Contains(@"\n"))
                {
                    string[] seperators = new string[] { ",", "\\n" };

                    num_list = param.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

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
                }
                else
                {
                    num_list = param.Split(',');

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
                }

                result = input_list;

            }
            catch (CustomException cexp)
            {
                throw cexp;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
    }
}
