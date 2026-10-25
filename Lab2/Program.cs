using System;

namespace OverloadDemo
{
    class Program
    {
        static int ToMultiplicate(int x, int N = 2)
        {
            Console.WriteLine("kanchvum e double funkcian");
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += x;
            }
            return sum;
        }

        static double ToMultiplicate(double x, int N = 2)
        {
            Console.WriteLine("kanchvum e double funkcian");
            double sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += x;
            }
            return sum;
        }

        static string ToMultiplicate(string x, int N = 2)
        {
            Console.WriteLine("kanchvum e string funkcian");
            string result = "";
            for (int i = 0; i < N; i++)
            {
                result += x;
            }
            return result;
        }

        static void Main(string[] args)
        {
          Console.WriteLine(ToMultiplicate(5));        
            Console.WriteLine(ToMultiplicate(5, 4));     
            Console.WriteLine(ToMultiplicate(2.5));      
            Console.WriteLine(ToMultiplicate(2.5, 3));   
            Console.WriteLine(ToMultiplicate("ab"));     
            Console.WriteLine(ToMultiplicate("ab", 3));
            
        }
    }
}
