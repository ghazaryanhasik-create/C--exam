using System;

namespace MatrixDemo
{
    class RandomMatrix
    {
      
        private int N { get; set; }
        private int A { get; set; }
        private int B { get; set; }

        private int[,] matrix;
        private Random random = new Random();

        public RandomMatrix(int n, int a, int b)
        {
            N = n;
            A = a;
            B = b;
            matrix = new int[N, N];
            FillMatrix();
        }

        private void FillMatrix()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = random.Next(A, B + 1);
                }
            }
        }

        public void ShowMatrix()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{matrix[i, j],5}");
                }
                Console.WriteLine();
            }
        }

        public int CountOdd()
        {
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                        count++;
                }
            }
            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Մուտքագրեք N (մատրիցայի չափը): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Մուտքագրեք A (ստորին սահման): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Մուտքագրեք B (վերին սահման): ");
            int b = int.Parse(Console.ReadLine());

            RandomMatrix m = new RandomMatrix(n, a, b);

            Console.WriteLine("\nՄատրիցան.");
            m.ShowMatrix();

            Console.WriteLine($"\nԿենտ թվերի քանակը: {m.CountOdd()}");

            Console.ReadKey();
        }
    }
}
