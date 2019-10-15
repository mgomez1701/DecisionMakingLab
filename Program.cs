using System;

namespace DecisionMakingLab
{
    class Program
    {
        static void Main(string[] args)
           
        {
            bool redo = true;
            string answer = "Y";
            while (redo)
            {



                //The application prompts to the user to enter an integer between 1 and 100.
                // The application displays the associated result based on the integer range entered.
                // 1 Point: Use if/else statements to make different actions depending on user input


                // 1 Point: If the integer entered is even and in the inclusive range of 26 to 60,


                //○ 1 Point: If the integer entered is odd and greater than 60, print the number entered and “Odd

                //// input ////
                Console.WriteLine("Hello, please share with me your name");
                string name = Console.ReadLine();

                Console.WriteLine("Please choose a number between 1 and 100");

                /// Declaring input & changing string to double in the same move ///

                int choosenNumber = int.Parse(Console.ReadLine());

                ///processing if statements ////

                if (choosenNumber % 2 != 0)
                {
                    // If the integer is odd, print the number entered and “Odd.” //

                    Console.WriteLine($"{name},The number {choosenNumber} you entered is odd");

                }

                else if (choosenNumber <= 25 && choosenNumber >= 2 && choosenNumber % 2 == 0)
                {
                    //If the integer entered is even and in the inclusive range of 2 to 25, print “Even and less than 25.”

                    Console.WriteLine($"{name}, the number you choose is Even and less than 25.");

                }
                else if (choosenNumber <= 60 && choosenNumber >= 26 && choosenNumber % 2 == 0)
                {
                    //1 Point: If the integer entered is even and in the inclusive range of 26 to 60, print “Even.”//
                    Console.WriteLine($"{name}, this is Even");


                }
                else if (choosenNumber >= 60 && choosenNumber % 2 == 0)
                {
                    Console.WriteLine($"{name} the number {choosenNumber} is Even");
                }
                else if (choosenNumber <= 60  && choosenNumber % 2 != 0)
                {
                    //: If the integer entered is odd and greater than 60, print the number  entered and “Odd.”

                    Console.WriteLine($"{name} the number {choosenNumber} is Odd");
                }

                else

                    Console.WriteLine($"You have choosen a number outside 1-100, {name}! Please try again. ");

              
                
               
            }
            Console.WriteLine("Do you want to try again? Y/N"); 



        }
    }
}
