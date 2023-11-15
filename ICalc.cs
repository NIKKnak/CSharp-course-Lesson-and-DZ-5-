using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    public interface ICalc
    {
        double Result { get; set; }
        void Sum(double x, double y);
        void Sub(double x, double y);
        void Multy(double x, double y);
        void Divide(double x, double y);
        void CancelLast();
        event EventHandler<EventArgs> MyEventHandler;

    }
}
