using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
   public class CalculateOperationCauseOverflowException : CalculatorExeption
    {
        public CalculateOperationCauseOverflowException()
        {
        
        }
        public CalculateOperationCauseOverflowException(string error) : base(error)
        {

        }
        
    }

}
