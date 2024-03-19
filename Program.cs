using System;

namespace ifStatements
{
    class MainExercisePage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 1: 'Equals to' calculator ");
            Console.WriteLine("Exercise 2: 'Even or odd' program ");
            Console.WriteLine("Exercise 3: 'Positive or negative number' calculator ");
            Console.WriteLine("Exercise 4: 'Leap year' calculator ");
            Console.WriteLine("Exercise 5: 'Government bench' checker ");
            Console.WriteLine("Exercise 6: 'Height' program ");
            Console.WriteLine("Exercise 7: 'Biggest number' calculator ");
            Console.WriteLine("Exercise 8: 'College qualification' checker ");
            Console.WriteLine("Exercise 9: 'Weather describer' program ");
            Console.WriteLine("Exercise 10: 'Triangle inequality theorem' calculator ");
            Console.WriteLine("Exercise 11: 'Grade' swapper ");
            Console.WriteLine("Exercise 12: 'Day of the week' program ");
            Console.WriteLine("Exercise 13: 'Basic calculator' app ");
            Console.WriteLine("Choose your exercise: (number)");

            int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            ExerciseQ.exercise1();
                            break;
                        case 2:
                            ExerciseQ.exercise2();
                            break;
                        case 3:
                            ExerciseQ.exercise3();
                            break;
                        case 4:
                            ExerciseQ.exercise4();
                            break;
                        case 5:
                            ExerciseQ.exercise5();
                            break;
                        case 6:
                            ExerciseQ.exercise6();
                            break;
                        case 7:
                            ExerciseQ.exercise7();
                            break;
                        case 8:
                            ExerciseQ.exercise8();
                            break;
                        case 9:
                            ExerciseQ.exercise9();
                            break;
                        case 10:
                            ExerciseQ.exercise10();
                            break;
                        case 11:
                            ExerciseQ.exercise11();
                            break;
                        case 12:
                            ExerciseQ.exercise12();
                            break;
                        case 13:
                            ExerciseQ.exercise13();
                            break;
                        default:
                            Console.WriteLine("Not a valid exercise option.");
                        break;
                    }
        }
    }
    public class ExerciseQ
    {
        public static void exercise1()
        {
            Console.WriteLine("Equals to calculator: (x = y)");
            Console.WriteLine("Enter value for x: ");
            int inputUserX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for y: ");
            int inputUserY = Convert.ToInt32(Console.ReadLine());
            if (inputUserX == inputUserY)
            {
                Console.WriteLine($"No. {0} and no. {1} are equal.", inputUserX, inputUserY);
            }
            else
            {
                Console.WriteLine("Not equal.");
            }
        }
        public static void exercise2()
        {
            Console.WriteLine("Even odd program:");
            Console.WriteLine("Enter value to check: ");
            int evenOdd = Convert.ToInt32(Console.ReadLine());

            if (evenOdd % 2 == 1)
            {
                Console.WriteLine("Your inputted number is odd.");
            }
            else
            {
                Console.WriteLine("Your inputted number is even.");
            };
        }
        public static void exercise3()
        {
            Console.WriteLine("Positive or negative number calculator: (x<0 or x>0)");
            Console.WriteLine("Enter value to check: ");
            int posNegNum = Convert.ToInt32(Console.ReadLine());

            if (posNegNum > 0)
            {
                Console.WriteLine("Your number is positive.");
            }
            else if (posNegNum < 0)
            {
                Console.WriteLine("Your number is negative.");
            }
            else
            {
                Console.WriteLine("Your number is neither positive or negative.");
            };
        }
        public static void exercise4()
        {
            Console.WriteLine("Leap year calculator: ");
            Console.WriteLine("Input year to check: ");
            int leapYear = Convert.ToInt32(Console.ReadLine());

            if (leapYear % 4 == 0)
            {
                Console.WriteLine("Your year is a leap year.");
            }
            else
            {
                Console.WriteLine("Your year isn't a leap year.");
            };
        }
        public static void exercise5()
        {
            Console.WriteLine("Government position checker: ");
            Console.WriteLine("Enter your age to check what you can run for: ");
            int personsAge = Convert.ToInt32(Console.ReadLine());

            if (personsAge >= 35)
            {
                Console.WriteLine("You are old enough to run for MP, Prime Minister, Senator & President.");
            }
            else if (personsAge >= 30)
            {
                Console.WriteLine("You are old enough to run for MP, Senator & Prime Minister.");
            }
            else if (personsAge >= 21)
            {
                Console.WriteLine("You are old enough to run for MP & Prime Minister.");
            }
            else
            {
                Console.WriteLine("You aren't old enough to run for any position.");
            }
        }
        public static void exercise6()
        {
            Console.WriteLine("Height checker: ");
            Console.WriteLine("Enter your height to see what you're considered: ");
            int height = Convert.ToInt32(Console.ReadLine());

            if (height >= 195)
            {
                Console.WriteLine("You are a giant.");
            }
            else if (height >= 177)
            {
                Console.WriteLine("You are tall.");
            }
            else if (height >= 165)
            {
                Console.WriteLine("You are medium height.");
            }
            else if (height >= 148)
            {
                Console.WriteLine("You are short.");
            }
            else if (height <= 120)
            {
                Console.WriteLine("You must still be growing.");
            }
            else
            {
                Console.WriteLine("You are a dwarf.");
            }
        }
        public static void exercise7()
        {
            Console.WriteLine("Enter 3 numbers and see which is the biggest. ");
            Console.WriteLine("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2 && num1 > num3)
                {
                Console.WriteLine("Biggest number is: " + num1);
                }
                else if(num2 > num1 && num2 > num3)
                    {
                Console.WriteLine("Biggest number is: " + num2);
                    }
                else 
                    {
                Console.WriteLine("Biggest number is: " + num3);
                    }
        }
        public static void exercise8()
        {
            Console.WriteLine("Enter the results of your finals. ");
            Console.WriteLine("Enter the mathematics finals results: ");
            int mathsResult = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the physics finals results: ");
            int physicsResult = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the chemistry finals results: ");
            int chemistryResult = Convert.ToInt32(Console.ReadLine());

            if (mathsResult > 70 && physicsResult > 55 && chemistryResult > 45 && mathsResult + physicsResult + chemistryResult > 180)
            {
                Console.WriteLine("You are able to recruit for college! ");
            }else if (mathsResult + physicsResult > 150 || mathsResult + chemistryResult > 150)
            {
                Console.WriteLine("You are able to recruit for college! ");
            }
            else
            {
                Console.WriteLine("You are not able to recruit for college. :( ");
            }
        }
        public static void exercise9()
        {
            Console.WriteLine("Enter the temperature of the weather outside to see how you can describe it. ");
            Console.WriteLine("Enter the temperature outside: ");
            int temperatureDegrees = Convert.ToInt32(Console.ReadLine());

            if(temperatureDegrees < 0)
            {
                Console.WriteLine("Cold as hell. Have fun if you have to go out.");
            }
            else if (temperatureDegrees < 11)
            {
                Console.WriteLine("Cold. Wear a coat.");
            }
            else if (temperatureDegrees < 21)
            {
                Console.WriteLine("Ideal. Nice & warm.");
            }
            else if (temperatureDegrees < 31)
            {
                Console.WriteLine("Perfect. Go hit the beach.");
            }
            else if (temperatureDegrees < 40)
            {
                Console.WriteLine("Getting a bit hot.");
            }
            else if (temperatureDegrees >= 40)
            {
                Console.WriteLine("Have you watched Snowpiercer?");
            }
        }
        public static void exercise10()
        {
            Console.WriteLine("Enter 3 sides of your triangle to see if its a valid triangle. ");
            Console.WriteLine("Enter the length of side A: ");
            int sideA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of side B: ");
            int sideB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of side C: ");
            int sideC = Convert.ToInt32(Console.ReadLine());

            if (sideA + sideB > sideC || sideA + sideC > sideB || sideB + sideC > sideA)
            {
                Console.WriteLine("Your 3 sides make a valid triangle.");
            }
            else
            {
                Console.WriteLine("Your 3 sides don't make a valid triangle.");
            }
        }
        public static void exercise11()
        {
            Console.WriteLine("Enter the grade you want to swap into the word version of it: ");
            int userGrade = Convert.ToInt32(Console.ReadLine());
            if(userGrade == 6)
            {
                Console.WriteLine("Ocena celująca");
            }
            else if(userGrade == 5)
            {
                Console.WriteLine("Ocena bardzo dobra");
            }
            else if(userGrade == 4)
            {
                Console.WriteLine("Ocena dobra");
            }
            else if(userGrade == 3)
            {
                Console.WriteLine("Ocena dostateczna");
            }
            else if (userGrade == 2)
            {
                Console.WriteLine("Ocena dopuszczająca");
            }
            else if (userGrade == 1)
            {
                Console.WriteLine("Ocena niedostateczna");
            }
            else
            {
                Console.WriteLine("Not a valid number for a grade.");
            }
        }
        public static void exercise12()
        {
            Console.WriteLine("Enter a number to see what day of the week it is: ");
            int userNumberOfTheDay = Convert.ToInt32(Console.ReadLine());
            if (userNumberOfTheDay == 7)
            {
                Console.WriteLine("Sunday");
            }
            else if (userNumberOfTheDay == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (userNumberOfTheDay == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (userNumberOfTheDay == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (userNumberOfTheDay == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (userNumberOfTheDay == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (userNumberOfTheDay == 1)
            {
                Console.WriteLine("Monday");
            }
            else
            {
                Console.WriteLine("Not a valid number for a day of the week.");
            }
        }
        public static void exercise13()
        {
            Console.WriteLine("Basic calculator.");
            Console.WriteLine("Enter the operator you want to use: +, -, *, /");
            String mathSymbol = Console.ReadLine();
            Console.WriteLine("Enter the 1st operand: ");
            double operandOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the 2nd operand: ");
            double operandTwo = Convert.ToDouble(Console.ReadLine());
            double answer;
            if (mathSymbol == "+")
            {
                answer = operandOne + operandTwo;
                Console.WriteLine("The sum of "+operandOne+" and "+operandTwo+" is: "+answer);
            }
            else if(mathSymbol == "-")
            {
                answer = operandOne - operandTwo;
                Console.WriteLine("The difference of " + operandOne + " and " + operandTwo + " is: " + answer);
            }
            else if (mathSymbol == "*")
            {
                answer = operandOne * operandTwo;
                Console.WriteLine("The product of " + operandOne + " and " + operandTwo + " is: " + answer);
            }
            else if (mathSymbol == "/")
            {
                if (operandTwo == 0)
                {
                    Console.WriteLine("Zero can't be a divisor.");
                }
                else 
                {
                    answer = operandOne / operandTwo;
                    Console.WriteLine("The quotient of " + operandOne + " and " + operandTwo + " is: " + answer);
                }
            }
            else
            {
                Console.WriteLine("Something went wrong. Invalid operator or operands. Try again.");
            }
        }
    }
}