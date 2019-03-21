using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program Variables
            string output = "";
            double input = 0;
            string fromUnit = "";
            string toUnit = "";
            bool exit = false;
            int menu = 0;
            do
            {
                //Show the  Main Menu
                Console.WriteLine("            ");
                Console.WriteLine("Convertor Program");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Please select from the menu");
                Console.WriteLine("1-To convert a value press 1");
                Console.WriteLine("2-To Exit the program Press 2");
                Console.WriteLine("----------------------------------------");
                //Read menu input
                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    //input error
                    Console.WriteLine("Your input wasnot in the correct format ");
                    //Console.WriteLine("Please Type  1 or 2 and press enter" );
                }
                if (menu == 1 || menu == 2)
                {
                    switch (menu)
                    {
                        case 1:
                            //take user input
                            try
                            {
                                Console.WriteLine("Please Enter value to convert");
                                input = Convert.ToDouble(Console.ReadLine());
                            }
                            catch (Exception)
                            {

                                Console.WriteLine("Your input wasnot in the correct format " +
                                    "Please enter a valid value");
                            }
                            Console.WriteLine("Please Enter the unit to convert");
                            fromUnit = Console.ReadLine();
                            Console.WriteLine("Please Enter desired convert to unit");
                            toUnit = Console.ReadLine();
                            try
                            {
                                DistanceConversion.Convert(input, fromUnit, toUnit);
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                                break;
                            }
                            //convert the input
                            output = "The conversion result is :   " + DistanceConversion.Convert(input, fromUnit, toUnit).ToString();
                            Console.WriteLine(output);
                            break;
                        case 2:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Please Type  1 or 2 and press enter");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please Type  1 or 2 and press enter");
                }
            } while (exit == false);
        }
    }
}
