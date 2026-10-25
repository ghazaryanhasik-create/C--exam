using System;

namespace MovieDemo
{
    public enum Genre
    {
        Action = 1,
        Comedy = 2,
        Drama = 3,
        Horror = 4,
        SciFi = 5
    }

    public class Movie
    {
        public int Id;
        public string Name;
        public int Year;
        public Genre Genre;
        public int Views;
        public int Likes;

        public Movie(string line)
        {
            string[] parts = line.Split(',');

            Id = int.Parse(parts[0].Trim());
            Name = parts[1].Trim();
            Year = int.Parse(parts[2].Trim());
            Genre = (Genre)int.Parse(parts[3].Trim());
            Views = int.Parse(parts[4].Trim());
            Likes = int.Parse(parts[5].Trim());
        }

        public double GetRating()
        {
            return Math.Sqrt(Math.Pow(Likes, 2) / Views);
        }

        public override string ToString()
        {
            string year = "(" + Year + ")";
            return string.Format("{0,4} {1,-15} {2,-8} {3,-12} {4,8:F3}",
                                 Id, Name, year, Genre, GetRating());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Filmeri qanak: ");
            int count = int.Parse(Console.ReadLine());

            Movie[] movies = new Movie[count];

            Console.WriteLine("DZEVACHAP hamar, anun, taretiv, janr (1-5), ditum, like");

            for (int i = 0; i < count; i++)
            {
                Console.Write($"film #{i + 1}: ");
                movies[i] = new Movie(Console.ReadLine());
            }

            Console.WriteLine();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(movies[i]);
            }
        }
    }
}
