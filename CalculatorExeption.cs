using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
   public class CalculatorExeption : Exception
    {
        public CalculatorExeption()
        {
        
        }
        public CalculatorExeption(string error) : base(error)
        {

        }
        
    }

}
