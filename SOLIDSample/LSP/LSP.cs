using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Any object of some class can be replaced by an object of a child class
/// </summary>
namespace SOLIDSample.LSP
{

    public class BadWay
    {
        public static class Main
        {
            public static void TestIt()
            {
                Product movie = new Movie();
                movie.Price = 100;
                var movieDiscount = movie.Discount(movie);

                Product game = new Game();
                game.Price = 100;
                //It will generate error
                var gameDiscount = game.Discount(game);
            }

        }

        //Similar to OCP, but it has inheritance, Liskov works side by side with OCP
        public class Product
        {
            public string Name { get; set; }

            public string Category { get; set; }

            public decimal Price { get; set; }

            public decimal Discount(Product product)
            {
                if (product is Movie)
                    return product.Price * 10;

                if (product is Game)
                    return product.Price * 20;

                return 0;
            }
        }

        public class Movie : Product
        {

        }

        public class Game : Product
        {

        }
    }

    public class LSP
    {
        public static class Main
        {
            public static void TestIt()
            {
                //You'll be able to change class between movie and game, and it still working
                IProductWithDiscount movie = new Movie() //Game()
                {
                    Price = 10
                };

                var movieDiscount = movie.Discount();

                IProductWithDiscount game = new Game() //Movie()
                {
                    Price = 20
                };

                var gameDiscount = game.Discount();

                //Will not work
                //IProductWithDiscount car = new Car()
                //{
                //    Price = 20
                //};

                //var carDiscount = game.Discount();
            }
        }

        public abstract class Product
        {
            public string Name { get; set; }

            public string Category { get; set; }

            public decimal Price { get; set; }
        }

        public interface IProductWithDiscount
        {
            decimal Discount();
        }

        public class Movie : Product, IProductWithDiscount
        {
            public decimal Discount()
            {
                return (Price * 10) / 100;
            }
        }

        public class Game : Product, IProductWithDiscount
        {
            public decimal Discount()
            {
                return (Price * 30) / 100;
            }
        }

        public class Car : Product
        {

        }
    }
}
