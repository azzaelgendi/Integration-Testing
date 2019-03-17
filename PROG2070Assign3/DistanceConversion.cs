/*
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

namespace PROG2070Assign3
{
    public static class DistanceConversion
    {


        public static double result;


        public static double Convert(double value, string convertFrom, string convertTo)
        {
            return value * GetMultiplier(convertFrom, convertTo);
        }

        private static string ModifyInput(string input)
        {
            switch (input)
            {
                case "y":
                    input = "yards";
                    break;
                case "Y":
                    input = "yards";
                    break;
                case "yards":
                    input = "yards";
                    break;
                case "Yards":
                    input = "yards";
                    break;
                case "m":
                    input = "meters";
                    break;
                case "M":
                    input = "meters";
                    break;
                case "meters":
                    input = "meters";
                    break;
                case "Meters":
                    input = "meters";
                    break;
                case "f":
                    input = "feet";
                    break;
                case "F":
                    input = "feet";
                    break;
                case "feet":
                    input = "feet";
                    break;
                case "Feet":
                    input = "feet";
                    break;
                case "r":
                    input = "rods";
                    break;
                case "R":
                    input = "rods";
                    break;
                case "rods":
                    input = "rods";
                    break;
                case "Rods":
                    input = "rods";
                    break;
                default:
                    throw new ArgumentException
                    (String.Format("{0} Incorrect unit", input),
                                      "input");

            }
            return input;
        }

        private static double GetMultiplier(string convertFrom, string convertTo)
        {

            convertFrom = ModifyInput(convertFrom);
            convertTo = ModifyInput(convertTo);

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
            return result;
        }
    }
}
