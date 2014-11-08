using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_50.Class
{
    class Calculator    
    {
        public decimal Add(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public decimal Subtract(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public decimal Multiply(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber * secondNumber;
        }
        public decimal Divide(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
