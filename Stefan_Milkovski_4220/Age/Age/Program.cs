using System;

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[10];
            Console.WriteLine("Enter 10 students to see if present or not: ");

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine($"Student {j + 1}: ");
                students[j] = Console.ReadLine();
            }

            var count = CountStudents(students);
            Console.WriteLine("{0} are present", count[0]);
            Console.WriteLine("{0} are absent", count[1]);
            Console.WriteLine("{0} presence unknown", count[2]);
        }

        public static int[] CountStudents(string[] students)
        {
            int tTrue = 0;
            int tFalse = 0;
            int tUnknown = 0;

            foreach(var student in students)
            {
                if (student == "present")
                {
                    tTrue++;
                }
                else if(student == "absent")
                {
                    tFalse++;
                }
                else
                {
                    tUnknown++;
                }
            }

            int[] total = { tTrue, tFalse, tUnknown };
            return total;
        }
    }
}
