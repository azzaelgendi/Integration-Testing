/*
 * Project C
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

namespace ProjectC
{
    public static class DistanceConversion
    {
        //class variables
        public static double result;
        //method to convert the value
        public static double Convert(double value, string convertFrom, string convertTo)
        {
            convertFrom = ModifyInput(convertFrom);
            convertTo = ModifyInput(convertTo);
            return value * GetMultiplier(convertFrom, convertTo);
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
        private static double GetMultiplier(string convertFrom, string convertTo)
        {
            if (convertFrom == "yards" && convertTo == "meters")
            {
                result = 0.9144;
            }
            else if (convertFrom == "meters" && convertTo == "yards")
            {
                result = 1.093613;
            }
            else if (convertFrom == "meters" && convertTo == "feet")
            {
                result = 3.280833;
            }
            else if (convertFrom == "feet" && convertTo == "meters")
            {
                result = 0.304801;
            }
            else if (convertFrom == "feet" && convertTo == "yards")
            {
                result = 0.333334;
            }
            else if (convertFrom == "yards" && convertTo == "feet")
            {
                result = 2.999994;
            }
            else if (convertFrom == "rods" && convertTo == "yards")
            {
                result = 5.5;
            }
            else if (convertFrom == "yards" && convertTo == "rods")
            {
                result = 1 / 5.5;
            }
            else if (convertFrom == "rods" && convertTo == "meters")
            {
                result = 5.0292100584201;
            }
            else if (convertFrom == "meters" && convertTo == "rods")
            {
                result = 0.198838782;
            }
            else if (convertFrom == "rods" && convertTo == "feet")
            {
                result = 16.5;
            }
            else if (convertFrom == "feet" && convertTo == "rods")
            {
                result = 0.06060606060606061;
            }
            else
            {
                result = 1;
            }
            return result;
        }
    }
}
