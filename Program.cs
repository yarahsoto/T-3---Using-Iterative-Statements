/* 
 Author: Yarah Soto
 Date: 2/10/2022
 Comments: This C# Console application code is for the T-3 - Using Iterative Statement Program assignment
*/

using System;

namespace T_3___Using_Iterative_Statements__SotoY
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask Customer to input integer increment between 5 and 25
            Console.WriteLine("Please enter and integer increment between 5 and 25");

            //Using try catch to validate the user input

            try
            {
                //String will store user input
                
                string input = Console.ReadLine();
                //Conversion value is a decimal so input will be stored as a decimal
                int inputdollar = int.Parse(input);
                
                //Determination of values
                decimal CAD = 0m; //Candaian dollar output
                decimal USD = 0m; // American dollar output
                decimal ConversionValue = 0.792367m; //Conversion number given in text
               
                if ((inputdollar >= 5) && (inputdollar <= 25)) //if/else statement if integer is between 5 and 25, using a While Loop
                {
                    Console.WriteLine("To convert USD to CAD the conversion value is 0.792367"); //This statement is displayed to User
                    Console.WriteLine("CAD" + inputdollar.ToString() + "USD"); //This is what should convert the input
                    
                    //While Loop starts here
                    while (CAD <= 200) //Cannot exceed $200 CAD
                    {
                        Console.WriteLine("$" + CAD.ToString(),"", "$" + USD.ToString()); // What appears as the conversion table to the user
                        CAD = (CAD + ConversionValue);
                        CAD += inputdollar; //this was input by VisualStudio as a debugging method
                        USD = decimal.Multiply(CAD, ConversionValue); //USD = decimal *USD and conversion result should be given
                    } //while ends
                    
                } //if ends
                else 
                {
                    Console.WriteLine("Please enter an integer between 5 and 25 - then try again.");
                }//else ends

            }//catch starts
            catch
            {
                Console.WriteLine("Please enter a integer value between 5 and 25 and run program again...");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            } //Catch ends
        } //Static void
    } //Class Program
} //namespace