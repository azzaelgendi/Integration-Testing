using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assign3
{
    class Program
    {
        static void Main(string[] args)
        {
            string output ="The conversion result is :   ";
            double input = 0;
            string fromUnit = "";
            string toUnit = "";

            try
            {
                Console.WriteLine("Please Enter value to convert");
                input = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Enter the unit to convert");
                fromUnit = Console.ReadLine();
                Console.WriteLine("Please Enter desired convert to unit");
                toUnit = Console.ReadLine();
                output +=DistanceConversion.Convert(input, fromUnit, toUnit).ToString();
                Console.WriteLine(output);
            }
            catch(FormatException lx)
            {
                Console.WriteLine("Unit input wasnot in the correct format "+
                    "Please enter a valid Number  "+ lx.Message);
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
