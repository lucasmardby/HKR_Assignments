namespace Console_App
{
    //Assignment 1: Console Application, by Lucas Mårdby
    internal class Program
    {
        static void Main(string[] args)
        {
            //methods for all the tasks

            TaskOne();

            TaskTwo();

            TaskThree();

            TaskFour();

            TaskFive();

            TaskSix();

            TaskSeven();
            TaskSevenTwo();

            TaskEight();

            WarmUp();
        }

        public static void TaskOne()
        {
            //take user input
            Console.WriteLine("---TASK 1---");
            Console.WriteLine();
            Console.WriteLine("Please enter a first name for the first string:");
            var firstName = Console.ReadLine();

            Console.WriteLine($"The family name of {firstName} is");
            Console.WriteLine("Please enter a family name for the second string:");
            var lastName = Console.ReadLine();

            Console.WriteLine($"The family name of {firstName} is {lastName}");
            HelperMethods.ConfirmationButton();
        }
        public static void TaskTwo()
        {
            Console.WriteLine("---TASK 2---");
            Console.WriteLine();
            Console.WriteLine("Enter a whole number to determine if it's even or odd.");

            //check for valid user input
            int number = 0;
            bool validInput = false;
            do
            {
                var readResult = Console.ReadLine();
                if (int.TryParse(readResult, out _))
                {
                    validInput = true;
                    number = Convert.ToInt32(readResult);
                }
                else
                {
                    Console.WriteLine("Try again. Enter a proper number to determine if it's even or odd.");
                }
            } while (validInput == false);

            //check if even or odd with modulus if-statement
            if (number % 2 == 0)
            {
                Console.WriteLine($"Your number, {number}, is even!");
            }
            else 
            {
                Console.WriteLine($"Your number, {number}, is odd!");
            }
            HelperMethods.ConfirmationButton();
        }
        public static void TaskThree()
        {
            Console.WriteLine("---TASK 3---");
            Console.WriteLine();

            //take user input
            Console.WriteLine("Please enter three numbers to be displayed.");
            Console.WriteLine("Enter the first number:");
            decimal firstNumber = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            decimal secondNumber = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            decimal thirdNumber = Convert.ToDecimal(Console.ReadLine());

            //print numbers
            Console.WriteLine("Your numbers are:");
            Console.WriteLine($"{firstNumber}\t{secondNumber}\t{thirdNumber}");
            HelperMethods.ConfirmationButton();
        }
        public static void TaskFour()
        {
            Console.WriteLine("---TASK 4--");

            //Writes initials 'LM', for Lucas Mårdby
            Console.WriteLine();
            Console.WriteLine(" \tL");
            Console.WriteLine(" \tL");
            Console.WriteLine(" \tL");
            Console.WriteLine(" \tL");
            Console.WriteLine(" \tLLLLLLL");
            Console.WriteLine();
            Console.WriteLine("\tM\tM");
            Console.WriteLine("\tMM     MM");
            Console.WriteLine("\tM M   M\tM");
            Console.WriteLine("\tM  M M\tM");
            Console.WriteLine("\tM   M\tM");

            HelperMethods.ConfirmationButton();
        }
        public static void TaskFive()
        {
            Console.WriteLine("---TASK 5--");

            Console.WriteLine("Enter two whole numbers, x and y, to compute their sum, difference, product, division, and remainder.");
            Console.WriteLine();

            int firstNumber = 0;
            int secondNumber = 0;

            //check for valid user input in two loops
            bool validInput = false;
            Console.WriteLine("Enter your first number for x:");
            do
            {
                var readResult = Console.ReadLine();
                if (int.TryParse(readResult, out _))
                {
                    validInput = true;
                    firstNumber = Convert.ToInt32(readResult);
                }
                else
                {
                    Console.WriteLine("Try again. Enter a proper whole number.");
                }
            } while (validInput == false);

            validInput = false;
            Console.WriteLine("Enter your second number for y:");
            do
            {
                var readResult = Console.ReadLine();
                if (int.TryParse(readResult, out _))
                {
                    validInput = true;
                    secondNumber = Convert.ToInt32(readResult);
                }
                else
                {
                    Console.WriteLine("Try again. Enter a proper whole number.");
                }
            } while (validInput == false);

            //Calculations of the two user inputed numbers
            Console.WriteLine();
            Console.WriteLine($"The sum of x({firstNumber}) and y({secondNumber}) is {firstNumber + secondNumber}");
            Console.WriteLine($"The difference of x({firstNumber}) and y({secondNumber}) is {firstNumber - secondNumber}");
            Console.WriteLine($"The product of x({firstNumber}) and y({secondNumber}) is {firstNumber * secondNumber}");
            Console.WriteLine($"The division of x({firstNumber}) and y({secondNumber}) is {firstNumber / secondNumber}");
            Console.WriteLine($"The remainder of x({firstNumber}) and y({secondNumber}) is {firstNumber % secondNumber}");

            HelperMethods.ConfirmationButton();
        }
        public static void TaskSix()
        {
            Console.WriteLine("---TASK 6--");
            Console.WriteLine();

            Console.WriteLine("Enter the radius of a circle to calculate its diameter, circumference, and area.");
            int radius = Convert.ToInt32(Console.ReadLine()); //user input radius

            //circle calculations
            var diameter = radius * 2;
            var circumference = diameter * Math.PI;
            var area = Math.PI * Math.Pow(radius, 2);

            //display result
            Console.WriteLine($"A circle with a radius of {radius} will have:");
            Console.WriteLine($"Diameter: \t{diameter}\nCircumference: \t{circumference}\nArea: \t\t{area}");

            HelperMethods.ConfirmationButton();
        }
        public static void TaskSeven() 
        {
            Console.WriteLine("---TASK 7--");
            Console.WriteLine();

            Console.WriteLine("Enter a four digit number to be separated from one another.");
            int fourDigitNumber = 0;

            bool validInput = false;
            //check for valid user input four digit integer
            do
            {
                var readResult = Console.ReadLine();
                if (int.TryParse(readResult, out _) && readResult.Trim().Length == 4)
                {
                    fourDigitNumber = Convert.ToInt32(readResult);
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Try again. Enter a four digit number for separation.");
                }
            } while (validInput == false);

            //calculations to pick out the four digits with division and modulus
            int firstDigit = fourDigitNumber / 1000;
            fourDigitNumber = fourDigitNumber % 1000;

            int secondDigit = fourDigitNumber / 100;
            fourDigitNumber = fourDigitNumber % 100;

            int thirdDigit = fourDigitNumber / 10;
            fourDigitNumber = fourDigitNumber % 10;

            int fourthDigit = fourDigitNumber;

            Console.WriteLine($"{firstDigit}\t{secondDigit}\t{thirdDigit}\t{fourthDigit}");
            HelperMethods.ConfirmationButton();
        }
        public static void TaskSevenTwo()
        {
            //My first solution and a second variant of this Task, without integer division and modulus operator

            Console.WriteLine("---TASK 7.2--");
            Console.WriteLine();

            Console.WriteLine("Enter a four digit number to be separated from one another.");
            int fourDigitNumber = 0;
            bool validInput = false;

            do //check for valid user input four digit integer
            {
                var readResult = Console.ReadLine();
                if (int.TryParse(readResult, out _) && readResult.Trim().Length == 4)
                {
                    fourDigitNumber = Convert.ToInt32(readResult);
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Try again. Enter a four digit number for separation.");
                }
            } while (validInput == false);

            //turn numbers integer into char array, and then join the four numbers back with tabs, inside of a result string.
            char[] numbersArray = fourDigitNumber.ToString().ToCharArray();
            string result = String.Join("\t", numbersArray);
            Console.WriteLine(result);
            HelperMethods.ConfirmationButton();
        }
        public static void TaskEight()
        {
            Console.WriteLine("---TASK 8--");
            Console.WriteLine();

            Console.WriteLine("Enter a number to be squared and cubed.");
            int number = 0;
            bool validInput = false;
            
            do //check for valid user input four digit integer
            {
                var readResult = Console.ReadLine();
                if (int.TryParse(readResult, out _))
                {
                    number = Convert.ToInt32(readResult);
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Try again. Enter a four digit number for separation.");
                }
            } while (validInput == false);

            //calculations for square and root
            var squaredNumber = Math.Pow(number, 2);
            var cubedNumber = Math.Pow(number, 3);

            Console.WriteLine($"Number\tSquare\tCube\n{number}\t{squaredNumber}\t{cubedNumber}");

            HelperMethods.ConfirmationButton();
        }

        public static void WarmUp() 
        {
            //warm-up before doing all the tasks
            Console.WriteLine("Please enter a number to be calculated.");
            float result1 = 0.00F, result2 = 0.00F, result3 = 0.00F;
            string userInput = Console.ReadLine();

            float inputValue = float.Parse(userInput);
            result1 = inputValue * 2.20F;
            result2 = inputValue * 3.50F;
            result3 = inputValue * 4.75F;

            Console.WriteLine($"The rates are : 2,20\t 3.50\t 4,75\nThe output is : {result1}\t{result2}\t{result3}");
        }
    }
}