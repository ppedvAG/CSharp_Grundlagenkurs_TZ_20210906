using System;

namespace TupleSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie(1, "Star Wars", "Die Niederlage der JavaScript Entwickler Teil 1", 9.99m);

            (string, decimal) result = movie.GetTitleAndPrice();

            Console.WriteLine(result.Item1);// title
            Console.WriteLine(result.Item2);// preis


            string title;
            decimal price;
            (title, price) = movie.GetTitleAndPrice();


            Console.WriteLine(title);// title
            Console.WriteLine(price);// preis
        }
    }

    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }


        public Movie(int id, string title, string description, decimal price)
        {
            Id = id;
            Title = title;
            Description = description;
            Price = price;
        }

        public (string, decimal) GetTitleAndPrice()
        {
            return (this.Title, this.Price);
        }
    }
}
