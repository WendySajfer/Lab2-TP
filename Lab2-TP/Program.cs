using System;

namespace Application
{
    class Program
    {
        public static int number, n2;
        public static void Main(string[] args)
        {
            Random random = new Random();
            while (true)
            {
                Console.WriteLine("Input n2:");
                n2 = Convert.ToInt32(Console.ReadLine());
                if (n2 > 1) break;
            }
            number = random.Next(1, n2);
            double[] Z = new double [number];
            for (int i = 0; i < Z.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Z[i] = 2 * i - 1;
                }
                else Z[i] = i * i + 1;
            }
            Console.WriteLine(String.Join(" ", Z));
        }
    }
}