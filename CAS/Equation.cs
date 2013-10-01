using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAS
{
    public class Equation
    {
        private List<Element> x;

        public Equation(List<Element> fx){
            this.x = fx;
        }

        public override string ToString()
        {
            string temp = "";
            foreach (Element e in this.x)
            {
                temp += e.ToString();
            }
            return temp;
        }

        public static Equation operator +(Equation fx, Equation gx)
        {

            return null;
        }
    }
}
