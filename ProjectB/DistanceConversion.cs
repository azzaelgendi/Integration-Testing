/*
 * Project B
 * Integration testing
 * Prog2070
 * Revision History
 * Azza Elgendy
 * Created March 16,2019
 * Distance Conversion Class
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB
{
    public static class DistanceConversion
    {
        /// <summary>
        /// The Convert method within the DIstanceConversion class, 
        /// modified so its attempt to call GetMultiplier calls a stub instead.
        /// call GetMultiplierStub.
        /// </summary>
         

        //class variables
        public static double result;
        //method to convert the value
        public static double Convert(double value, string convertFrom, string convertTo)
        {
            convertFrom = ModifyInput(convertFrom);
            convertTo = ModifyInput(convertTo);
            return value * GetMultiplierStub(convertFrom, convertTo);
        }
        //method to check the convertion units
        private static string ModifyInput(string input)
        {
            switch (input)
            {
                case "y":
                case "Y":
                case "yards":
                case "Yards":
                    input = "yards";
                    break;
                case "m":
                case "M":
                case "meters":
                case "Meters":
                    input = "meters";
                    break;
                case "f":
                case "F":
                case "feet":
                case "Feet":
                    input = "feet";
                    break;
                case "r":
                case "R":
                case "rods":
                case "Rods":
                    input = "rods";
                    break;
                default:
                    throw new ArgumentException
                    ("Incorrect unit");
            }
            return input;
        }
        //method to return the multiplyer value
        private static double GetMultiplierStub(string convertFrom, string convertTo)
        {
            return 16.5;
        }
    }
}
