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
        int tal1 { get; set; }
        int tal2 { get; set; }
        string para { get; set; }


        public Calculate(int tal1, string para,int tal2)
        {
            this.result = result;
            this.tal1 = tal1;
            this.tal2 = tal2;
            this.para = para;
        }

        public int UdregnFaktorer(int tal1, string para, int tal2)
        {
            int result = 0;

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

            return result;
        }

       
}
}