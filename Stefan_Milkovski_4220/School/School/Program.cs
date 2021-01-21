using System;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] students = new int[8];
            int max, min, old = 0, young = 0;
            int i = 0;

            Console.WriteLine("Enter the student's age");
            max = students[0];
            min = 100;

            while (i < students.Length)
            {
                Console.WriteLine($"Student {i + 1}: ");
                students[i] = Convert.ToInt32(Console.ReadLine());

                if (students[i] > max)
                {
                    max = students[i];
                }

                if (students[i] < min)
                {
                    min = students[i];
                }

                i++;
            }


            for (i = 0; i < students.Length; i++)
            {
                if (students[i] == min)
                {
                    young++;
                }
                if (students[i] == max)
                {
                    old++;
                }
            }

            if (old > 1)
            {
                Console.WriteLine("The amount of students with same old age are: {0}\n", old);
                Console.Write("With age: {0}", max);
            }

            else
            {
                Console.Write("Oldest student is: {0}\n", max);
            }

            if (young > 1)
            {
                Console.WriteLine("The amount of students with same young age are: {0}", young);
                Console.Write("With age: {0}\n", min);
            }

            else
            {
                Console.Write("Youngest student is: {0}", min);
            }

        }
    }
}
