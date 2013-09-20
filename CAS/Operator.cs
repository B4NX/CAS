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

        public Operator(char op)
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
    }
}
