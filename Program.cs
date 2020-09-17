using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Conditional_Statements_Project_2b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your expected grade in ISM 4300 (integer value)... ");
            //asking for user input
            
            string input = Console.ReadLine();

            int grade_input = int.Parse(input);

            try
            {   

                if (grade_input < 60) 
                {
                    Console.WriteLine("You have entered " + grade_input.ToString() + " Your grade would be " + "F");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grade_input <= 62) && (grade_input >= 60))
                {
                    Console.WriteLine("You have entered " + grade_input.ToString() + " Your grade would be " + "D-");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grade_input <= 66) && (grade_input >= 63))
                {
                    Console.WriteLine("You have entered " + grade_input.ToString() + " Your grade would be " + "D");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grade_input <= 69) && (grade_input >= 667))
                {
                    Console.WriteLine("You have entered " + grade_input.ToString() + " Your grade would be " + "D+");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grade_input <= 72) && (grade_input >= 70))
                {
                    Console.WriteLine("You have entered " + grade_input.ToString() + " Your grade would be " + "C-");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grade_input <= 76) && (grade_input >= 73))
                {
                    Console.WriteLine("You have entered " + grade_input.ToString() + " Your grade would be " + "C");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grade_input <= 79) && (grade_input >= 77))
                {
                    Console.WriteLine("You have entered " + grade_input.ToString() + " Your grade would be " + "C+");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grade_input <= 82) && (grade_input >= 80))
                {
                    Console.WriteLine("You have entered " + grade_input.ToString() + " Your grade would be " + "B-");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grade_input <= 86) && (grade_input >= 83))
                {
                    Console.WriteLine("You have entered " + grade_input.ToString() + " Your grade would be " + "B");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grade_input <= 89) && (grade_input >= 87))
                {
                    Console.WriteLine("You have entered " + grade_input.ToString() + " Your grade would be " + "B+");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grade_input <= 92) && (grade_input >= 90))
                {
                    Console.WriteLine("You have entered " + grade_input.ToString() + " Your grade would be " + "A-");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grade_input <= 100) && (grade_input >= 93))
                {
                    Console.WriteLine("You have entered " + grade_input.ToString() + " Your grade would be " + "A");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Error please enter integer value between 0-100 is not valid");
                    Console.WriteLine("Press any key to exit and try again...");
                    Console.ReadKey(true);

                }
                //end of if else statements

            }//end of try
            catch
            {
                Console.WriteLine("Please enter and integer value and try running the program again...");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }//end of catch
        }
    }
}
