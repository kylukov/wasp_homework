using System;
using System.ComponentModel;

namespace ConsoleApp1
{
    class Program
    {
        public static void task_3_2()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Array.Sort(numbers);
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numbers[k-1]);
            Console.ReadKey();
        }

        public static void task_3_3()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            
            string line = Console.ReadLine();
            string[] nums = line.Split(' ');
            
            string command = Console.ReadLine();
            string[] coms = command.Split(':');
            
            int start = Convert.ToInt32(coms[0]);
            int end = Convert.ToInt32(coms[1]);
            int step = Convert.ToInt32(coms[2]);
            if (step > 0)
            {
                for (int i = start; i <= end; i += step)
                    Console.Write(nums[i] + " ");
            }
            else
            {
                for (int i = end; i >= start; i += step)
                    Console.Write(nums[i] + " ");
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("ВВЕДИТЕ КОМАНДУ:\n3.1 - 1\n3.2 - 2\n3.3 - 3");
            int command = Convert.ToInt32(Console.ReadLine());
            switch (command)
            {
                case 2:
                    task_3_2();
                    break;
                case 3:
                    task_3_3();
                    break;
                default:
                    Console.WriteLine("Input Incorrect");
                    break;
            }
        }
    }
}

