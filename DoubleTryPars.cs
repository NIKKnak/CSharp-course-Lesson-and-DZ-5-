using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    public class DoubleTryPars
    {

        public double DoubleTryParse(string input)
        {

            try
            {
                double result = double.Parse(input);
                if (result >= 0)
                {
                    return result;

                }
                else
                {
                    Console.WriteLine("число отрицательное и будет = 0");
                    result = 0;
                    return result;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Это не число");
                return 0;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }

}
