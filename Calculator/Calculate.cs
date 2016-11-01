using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculate
    {
        double result { get; set; }
        double tal1 { get; set; }
        double tal2 { get; set; }
        string para { get; set; }


        public Calculate(double tal1, string para,double tal2)
        {
            this.result = result;
            this.tal1 = tal1;
            this.tal2 = tal2;
            this.para = para;
        }

        public double UdregnFaktorer(double tal1, string para, double tal2)
        {
            double result = 0;

            if (para == "+")
            {

                result = tal1 + tal2;
            }

            else if (para == "-")
            {
                result = tal1 - tal2;
            }

            else if (para == "*")
            {
                result = tal1 * tal2;
            }

            else if (para == "/")
            {
                result = tal1 / tal2;
            }

            else if (para == "^")
            {
                result = tal1;
                for (int i = 1; i < tal2; i++)
                {
                    result = result * tal1;
                }
                return result;
            }


            return result;
        }

       
}
}