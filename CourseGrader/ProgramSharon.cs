using System;

namespace CourseGrader
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // create a method named GradeTestScores that takes a int array of test scores as its parameter and returns a string
            // GradeTestScores will add up these test scores and calculate an average score. 
            // It should then return a string of "pass" or "fail" depending on these two conditions:
            // If the average score is greater than or equal to 70 and no single test score is below 50, then return a message of "pass".
            // If the average score is lower than 70 or at least one test score is below 50, then return a message of "fail".

            int[] arr = new int[] { 97, 94, 99 };

            Console.ReadLine();

        }
        public static int GradeTestScores()
        {
            int sum = 0;
            int average = 0;
            foreach (int item in arr)
            {
                sum += item;
            }
            average = sum / arr.Length;
            if (average >= 70)
            {
                string message = "Pass!";
                Console.WriteLine(message);
            }
            else if (average < 70)
            {
                string message = "Fail!";
                Console.WriteLine(message);
            }


        }
    }
}
