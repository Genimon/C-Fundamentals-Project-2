using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    public class Control_Flow_Exercises
    {
        public static string Multiples()
        {
            // Exercise 2a

            var factorsOf3 = new List<Int32> ();

            for ( var i = 1; i <= 100; i++ )
            {
                if ( i % 3 == 0 )
                {
                    factorsOf3.Add (i);
                }
            }

            return $"The number of factors of 3 between 1 - 100 is equal to {factorsOf3.Count.ToString ()} factors";
            //Console.WriteLine();


        }

        public static string Summation()
        {
            // Exercise 2b



            var Total = 0;

            while ( true )
            {

                var userInput = Console.ReadLine ();

                if ( userInput != "ok" )
                {
                    Total += Convert.ToInt32 (userInput);
                    Console.WriteLine ("Enter another number of your choice or ok to calculete the sum and exit the program ");
                    //userInput = Console.ReadLine();

                }
                else
                {
                    return $"The summation of numbers you entered is = {Total} ";
                    //Console.WriteLine();

                }


                //Console.ReadLine();
            }


        }

        public static string Factorial()
        {
            // Exercise 2c

            // Factorial Calculator

            //Console.WriteLine("Enter a number to compute its factorial ");

            var numberFactorial = Convert.ToDouble (Console.ReadLine ());

            double factorial = 1;

            for ( var i = numberFactorial; i > 0; i-- )
            {
                factorial *= i;
            }

            return $"The factorial of {numberFactorial} is {factorial}.";
            //Console.WriteLine();


        }


        public static string RandomNumber()
        {
            // Exercise 2d

            // Random Generator


            //var prediction = 0;
            //for (var i = 0; i < 10; i++)

            var randomNumber = new Random ();
            var prediction = randomNumber.Next (1, 10);

            for ( var i = 0; i <= 3; i++ )
            {
                //Console.WriteLine("Guess a number between between 1 to 10, you have 4 chances to guess the number");

                var guessNumber = Convert.ToInt32 (Console.ReadLine ());

                if ( guessNumber == prediction )
                {
                    return "You guessed the number correctly!";
                    //Console.WriteLine();
                }

                else if ( guessNumber != prediction && i < 3 )
                {

                    Console.WriteLine ($"You lost, but you can have another chance at the guess!");
                }

                else
                {
                    Console.WriteLine ("You lost, you have used up your lifeline!");
                }

            }
            return " The chosen number is " + prediction;
            //Console.WriteLine();

        }


        public static string Maximum()
        {
            // Exercise 2e
            // Maximum Number of a  series

            //Console.WriteLine("Enter a series of numbers separated by comma ");

            var nums = Console.ReadLine ();

            var seriesNum = nums.Split (',');

            var maxNum = Convert.ToInt32 (seriesNum[0]);

            //Console.WriteLine(maxNum);

            foreach ( var n in seriesNum )
            {
                var maxNumber = Convert.ToInt32 (n);

                if ( maxNumber > maxNum )
                {
                    maxNum = maxNumber;
                }

            }

            return $"The maximum number of the series ({nums}) is {maxNum}";
            //Console.WriteLine();


        }
    }
}
