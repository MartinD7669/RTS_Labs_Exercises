// Author: Martin Davis
// Date: 3/4/21
// Description: Three exercises for RTS Labs.

using System;

namespace RTS_Labs_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /**********************
             Exercise 1
             **********************/

            static void AboveBelow(int[] array, int input)
            {
                //initialize above/below counters
                int above_count = 0;
                int below_count = 0;

                //iterate through array and compare to input value
                for(int i = 0; i < array.Length; i++)
                {
                    if (array[i] > input) {
                        above_count++;
                    } else if (array[i] < input) {
                        below_count++;
                    } else {
                        continue;
                    }
                }
                //generate output
                Console.WriteLine("above: " + above_count + ", " + "below: " + below_count);
            }

            //testing AboveBelow method
            int[] array1 = new int[5] { 1, 5, 2, 1, 10 };
            int input1 = 6;

            int[] array2 = new int[10] { 9, 6, 2, 10, 3, 15, 1, 8, 92, 1 };
            int input2 = 4;

            AboveBelow(array1, input1);
            AboveBelow(array2, input2);


            /******************
             Exercise 2
            ********************/

            static void RotateString(string str, int input)
            {
                //get end of string
                int rotate = str.Length - input;

                //concat end of string to front of original string
                string result = str.Substring(rotate) + str.Substring(0, rotate); 

                //output
                Console.WriteLine(result);
            }

            //testing RotateString method
            string str1 = "MyString";
            int rotation1 = 2;

            string str2 = "RTSLabsExercise2";
            int rotation2 = 6;

            RotateString(str1, rotation1);
            RotateString(str2, rotation2);

            /*****************
             Exercise 3
             *****************/

            /*#3 If you could change 1 thing about your favorite framework/language/platform (pick one), what would it be?*/

            /*
            One thing I would like to change is how errors are generated when testing and 
            working with PHP applications. When there are fatal errors, PHP will let you 
            know, but nothing is more frustrating than having a blank webpage pop up when 
            testing, and have no idea what caused it. I've used var dump to see what exactly 
            has been stored in my variables before, which helps, and I read that you can 
            enable error reporting too, but it would be much nicer if this was done automatically.
            This would save time and effort, so I wouldn't have to enable error reporting, 
            or sift through variables using var dump. 
             */
        }
    }
}
