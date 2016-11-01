using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculate
    {
        int result { get; set; }



        public Calculate(int result)
        {
            this.result = result;
        }

        public int udregnfaktorer(int tal1, string para, int tal2)
        {


            if (para == "+")
            {
                int result = tal1 + tal2;
            }

            else if (para == "-")
            {
                int result = tal1 - tal2;
            }

            else if (para == "*")
            {
                int result = tal1 * tal2;
            }

            else if (para == "/")
            {
                int result = tal1 / tal2;
            }

            return result;
        }

       
}
}