using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{

    public class Calculator
    {
        /// <summary>
        /// The result of the calculation
        /// </summary>
        private int result;

        /// <summary>
        /// Function to add numbers in a number list
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns name="result"></returns>
        public virtual int Add( List<int> numbers )
        {
            this.result = 0;

            foreach (int item in numbers)
            {
                this.result += item;
            }

            return this.result;
        }

        /// <summary>
        /// Function to multiply numbers in a number list
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns name="result"></returns>
        public virtual int Multiply(List<int> numbers)
        {
            this.result = 1;

            foreach (int item in numbers)
            {
                this.result *= item;
            }

            return this.result;
        }

    }
}
