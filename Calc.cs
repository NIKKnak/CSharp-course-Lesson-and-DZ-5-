using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    internal class Calc : ICalc
    {
        public double Result { get; set; } = 0D;
        private Stack<double> LastResult { get; set; } = new Stack<double>();

        public event EventHandler<EventArgs> MyEventHandler;
        private void PrintResult()
        {
            MyEventHandler?.Invoke(this, new EventArgs());
        }

        public void Divide(double x, double y)
        {
            if (y != 0)
            {
                Result = x / y;
            }
            else
            {
                throw new CalculatorDivideByZeroException();
                Console.WriteLine("Ошибка: деление на ноль");
            }
            PrintResult();
        }

        public void Multy(double x, double y)
        {
            Result = x * y;
            PrintResult();
        }

        public void Sub(double x, double y)
        {
            Result = x - y;
            PrintResult();
        }

        public void Sum(double x, double y)
        {
            Result = x + y;
            PrintResult();
        }

        public void CancelLast()
        {
            if (LastResult.TryPop(out double res))
            {
                Result = res;
                Console.WriteLine("Последнее действие отменено, результат равен: ");
                PrintResult();
            }
            else
            {
                Console.WriteLine("Невозможно отменить последнее действие");
            }
        }

    }
}
