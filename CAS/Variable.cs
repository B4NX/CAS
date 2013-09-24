using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAS
{
    class Variable:Element
    {
        char name;
        private Variable(char c)
        {
            if (char.IsLetter(c.ToString(),0))
            {
                name = c;
            }else name=' ';
        }

        public static bool TryParseVariable(char c, out Variable e)
        {
            Variable temp = new Variable(c);

            if (temp.name == ' ')
            {
                e = null;
                return false;
            }
            e = temp;
            return true;
        }

        public override string ToString()
        {
            return this.name.ToString();
        }
    }
}
