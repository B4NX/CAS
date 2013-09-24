using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAS
{
    class Operator:Element
    {
        public enum basicOperators
        {
            ADD,
            SUBTRACT,
            MULTIPLY,
            DIVIDE,
            NONE
        };
        basicOperators oper;

        private Operator(char op)
        {
            switch (op)
            {
                case '+':
                    this.oper = basicOperators.ADD;
                    break;
                case '-':
                    this.oper = basicOperators.SUBTRACT;
                    break;
                case '*':
                    this.oper = basicOperators.MULTIPLY;
                    break;
                case '/':
                    this.oper = basicOperators.DIVIDE;
                    break;
                default:
                    this.oper = basicOperators.NONE;
                    break;
            }
        }
        public static bool TryParseOperator(char op, out Operator oper)
        {
            Operator temp = new Operator(op);

            if (temp.oper == basicOperators.NONE)
            {
                oper = null;
                return false;
            }
            oper = temp;
            return true;
        }

        public override string ToString()
        {
            switch (this.oper){
                case basicOperators.ADD:
                return "+";

                case basicOperators.SUBTRACT:
                return "-";

                case basicOperators.MULTIPLY:
                return "*";

                case basicOperators.DIVIDE:
                return "/";

                default:
                return " ";
            }
        }
    }
}
