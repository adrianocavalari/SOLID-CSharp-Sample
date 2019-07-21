using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDSample.LSP
{
    public class BadWay2
    {
        public static class Main
        {
            public static void TestIt()
            {
                Product movie = new Movie();
                movie.Price = 100;
                var movieDiscount = movie.Discount();

                Product game = new Game();
                game.Price = 100;
                //It will generate error
                var gameDiscount = game.Discount();
            }

        }

        public abstract class Product
        {
            public string Name { get; set; }

            public string Category { get; set; }

            public decimal Price { get; set; }

            public abstract decimal Discount();
        }

        public class Movie : Product
        {
            public override decimal Discount()
            {
                return (Price * 10) / 100;
            }
        }

        public class Game : Product
        {
            public override decimal Discount()
            {
                throw new NotImplementedException();
            }
        }
    }

    public class LSP2
    {
        public static class Main
        {
            public static void TestIt()
            {
                Product movie = new Movie();
                movie.Price = 100;
                var movieDiscount = movie.Discount();

                Product game = new Game();
                game.Price = 100;
                var gameDiscount = game.Discount();
            }

        }

        public abstract class Product
        {
            public string Name { get; set; }

            public string Category { get; set; }

            public decimal Price { get; set; }

            public abstract decimal Discount();
        }

        public class Movie : Product
        {
            public override decimal Discount()
            {
                return (Price * 10) / 100;
            }
        }

        public class Game : Product
        {
            public override decimal Discount()
            {
                return (Price * 30) / 100;
            }
        }
    }
}
