using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Calculo.Calculator.Library
{
    public class Calculator
    {
        public static string Calculate(string sum)
        {
            return new NCalc.Expression(sum).Evaluate().ToString();
        }
    }

}
