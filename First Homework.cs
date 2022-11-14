using System;

namespace dop
{
    class Program
    {
        public static float factorial(int n)
        {
            float i, x = 1;
            for (i = 1; i <= n; i++)
                x *= i;
            return x;
        }

        public static void task_1_1()
        {
            Console.WriteLine("TASK 1.1");
            for (int i = 9; i > 2; i--)
            {
                string str = $"{i}{i - 1}{i - 2}{i - 3}";
                Console.WriteLine(str);
            }
        }


        public static void task_1_2()
        /*
         * Прости за лютый костыль
         */
        {
            Console.WriteLine("Введите размерность матрицы");
            int n = int.Parse(Console.ReadLine());
            int count = 1;
            for (int i = 1; i < n+1; i++, count++)
            {
                for (int j = 1; j < n+1; j++)
                {
                    if (j < count) Console.Write($"{n - (count-j)} ");
                    
                    if (j == count) Console.Write(n + " ");

                    if (j > count)
                    {
                        for (int k = 1; k < n-count+1; k++) Console.Write($"{n-k} ");
                        break;
                    }
                }
                Console.WriteLine();
            }
        }

        public static void task_1_3()
        {
            Console.WriteLine("\nTASK 1.3\nВведите координаты");
            string t = "";
            int max_x = 0;
            int max_y = 0;
            for (int i = 0; i < 3; i++)
            {
                t = Console.ReadLine();
                string[] tv = t.Split(' ').Where(x => x != "").ToArray();
                int x = int.Parse(tv[0]);
                int y = int.Parse(tv[1]);

                max_x = Math.Max(max_x, x);
                max_y = Math.Max(max_y, y);
            }

            for (int i = 1; i < max_y + 1; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write('*');
                
                Console.WriteLine();
            }
        }

        public static void task_1_4()
        {
            Console.WriteLine("\nTASK 1.4\nВведите длину последоавтельности");
            int n;
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write(factorial(i) / (factorial(j) * factorial(i - j)));
                
                Console.WriteLine();
            }
        }

        public static void task_2_1()
        {
            Console.WriteLine("\nTask 2.1\nВведите число в 10сс");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(n, 2));
        }

        public static void task_2_2()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            string bin_a = Convert.ToString(a, 2);
            string bin_b = Convert.ToString(b, 2);
            string res = Convert.ToString((a + b), 2);
            
            while (bin_a.Length != res.Length )
                bin_a = bin_a.Insert(0, "0");
            while (bin_b.Length != res.Length)
                bin_b = bin_b.Insert(0, "0");

            Console.WriteLine(bin_a);
            Console.WriteLine(bin_b);
            for (int i = 0; i < res.Length; i++)
                Console.Write("-");

            Console.WriteLine("\n"+res);
            
        }
        

        public static void Main(string[] args)
        {
            
            Console.WriteLine("Введите команду\n1.1 - 1\n1.2 - 2\n1.3 - 3\n1.4 - 4\n2.1 - 5\n2.2 - 6\n2.3 - 7");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    task_1_1();
                    break;
                case 2:
                    task_1_2();
                    break;
                case 3:
                    task_1_3();
                    break;
                case 4:
                    task_1_4();
                    break;
                case 5:
                    task_2_1();
                    break;
                case 6:
                    task_2_2();
                    break;

                default:
                    Console.WriteLine("Input Error");
                    break;
            }
            Console.ReadKey();
        }
    }
}