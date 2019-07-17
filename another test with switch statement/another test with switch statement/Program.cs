using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace another_test_with_switch_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // in this basic program i have attempted to make a simple console based calculator, with accountin for basic exceptions and errors.
            // I have chosen to use methods for each process for flexability and ease of reading and modifying.

            string selectorinput = "", endbutton = "";
            
            Console.WriteLine("Welcome to this program, we shall develop a Simple Calculator");
            Console.ReadKey();


            do
            {
                Console.WriteLine("Please Select the Operation by typing the Number that preceides it");
                Console.WriteLine("1-Add \n2-subtract \n3-multiply \n4-divide");
                selectorinput = Console.ReadLine();
                if (selectorinput == "1" || selectorinput == "add")
                {
                    AddingMethod();
                    Console.WriteLine("Would you like to end the application? Y/y for yes anything else for no");
                    endbutton=Console.ReadLine();
                }
                else if (selectorinput == "2" || selectorinput == "subtract")
                {
                    SubtractionMethod();
                    Console.WriteLine("Would you like to end the application? Y/y for yes anything else for no");
                    endbutton = Console.ReadLine();

                }
                else if (selectorinput == "3" || selectorinput == "multiply")
                {
                    MultiplicationMethod();
                    Console.WriteLine("Would you like to end the application? Y/y for yes anything else for no");
                    endbutton = Console.ReadLine();

                }
                else if (selectorinput == "4" || selectorinput == "divide")
                {
                    DivisionMethod();
                    Console.WriteLine("Would you like to end the application? Y/y for yes anything else for no");
                    endbutton = Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("You did not select any of the proper numbers!!");
                    Console.WriteLine("Would you like to end the application? Y/y for yes anything else for no");
                    endbutton = Console.ReadLine();

                }

            } while (endbutton != "Y" && endbutton != "y");

            Console.WriteLine("Thank you for using this quick and basic practice application");
            Console.Read();

        }
        public static void AddingMethod()
        {
            double number1=0, number2=0,result;
            string number1input, numberinput2; 
            Console.WriteLine("You have Selected Addition");
           

            try
            {
                Console.WriteLine("Please Input the First number");
                number1input = Console.ReadLine();
                number1 = Convert.ToDouble(number1input);

            }
            catch (Exception)
            {
                Console.WriteLine("YOU DID NOT INPUT A PROPER NUMBER!!");
                
            }
            try
            {
                Console.WriteLine("please input the second number");
                numberinput2 = Console.ReadLine();
                number2 = Convert.ToDouble(numberinput2);

            }
            catch (Exception)
            {
                Console.WriteLine("YOU DID NOT INPUT A PROPER NUMBER!!");
            }
            
            result = number1 + number2;
            Console.WriteLine("The Sum of the two Numbers is {0}",result);

        }
        public static void SubtractionMethod()
        {

            double number1 = 0, number2 = 0, result;
            string number1input, numberinput2;
            Console.WriteLine("You have Selected Subtraction");


            try
            {
                Console.WriteLine("Please Input the First number");
                number1input = Console.ReadLine();
                number1 = Convert.ToDouble(number1input);

            }
            catch (Exception)
            {
                Console.WriteLine("YOU DID NOT INPUT A PROPER NUMBER!!");

            }
            try
            {
                Console.WriteLine("please input the second number");
                numberinput2 = Console.ReadLine();
                number2 = Convert.ToDouble(numberinput2);

            }
            catch (Exception)
            {
                Console.WriteLine("YOU DID NOT INPUT A PROPER NUMBER!!");
            }

            result = number1 - number2;
            Console.WriteLine("The Difference of the two Numbers is {0}", result);

        }

        public static void MultiplicationMethod()
        {

            double number1 = 0, number2 = 0, result;
            string number1input, numberinput2;
            Console.WriteLine("You have Selected Multiplication");


            try
            {
                Console.WriteLine("Please Input the First number");
                number1input = Console.ReadLine();
                number1 = Convert.ToDouble(number1input);

            }
            catch (Exception)
            {
                Console.WriteLine("YOU DID NOT INPUT A PROPER NUMBER!!");

            }
            try
            {
                Console.WriteLine("please input the second number");
                numberinput2 = Console.ReadLine();
                number2 = Convert.ToDouble(numberinput2);

            }
            catch (Exception)
            {
                Console.WriteLine("YOU DID NOT INPUT A PROPER NUMBER!!");
            }

            result = number1 * number2;
            Console.WriteLine("The Multiplication of the two Numbers is {0}", result);

        }

       public static void DivisionMethod()
       {

            double number1 = 0, number2 = 0, result;
            string number1input, numberinput2;
            Console.WriteLine("You have Selected Division");


            try
            {
                Console.WriteLine("Please Input the First number");
                number1input = Console.ReadLine();
                number1 = Convert.ToDouble(number1input);

            }
            catch (Exception)
            {
                Console.WriteLine("YOU DID NOT INPUT A PROPER NUMBER!!");

            }
            try
            {
                Console.WriteLine("please input the second number");
                numberinput2 = Console.ReadLine();
                number2 = Convert.ToDouble(numberinput2);
                

            }
            catch (Exception)
            {
                Console.WriteLine("YOU DID NOT INPUT A PROPER NUMBER!!");
            }
            if (number2 == 0) { Console.WriteLine("You may Not divide by Zero!!"); }
            else
            {
                result = number1 / number2;
                Console.WriteLine("The division of the two Numbers is {0}", result);
            }

            




        }
    }
}


