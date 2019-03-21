/*
 * ProjectA
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

namespace ProjectA
{
    public static class DistanceConversion
    {     /// <summary>
         /// The Convert method within the DistanceConversion class
         /// , modified so any method call it attempts calls a stub instead.
         /// call ModifyInputStub and GetMultiplierStub
         /// </summary>
         
        //class variables
        public static double result;
        //method to convert the value
        public static double Convert(double value, string convertFrom, string convertTo)
        {
            convertFrom = ModifyInputStub(convertFrom);
            convertTo = ModifyInputStub(convertTo);
            return value * GetMultiplierStub(convertFrom, convertTo);
        }
        //method to check the convertion units
        private static string ModifyInputStub(string input)
        {
            return "meters";
        }
        //method to return the multiplyer value
        private static double GetMultiplierStub(string convertFrom, string convertTo)
        {

            return 2;
        }
    }
}
