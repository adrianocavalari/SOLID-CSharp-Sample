using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDSample.OCP
{
    public class BadWay
    {
        public class Product
        {
            public string Name { get; set; }

            public string Category { get; set; }

            public decimal Price { get; set; }

            public decimal Discount()
            {
                if (Category == "Movie")
                    return (Price * 10) / 100 ;

                if (Category == "Game")
                    return (Price * 30) / 100;

                return Price;
            }
        }
    }

    public class OCP
    {
        public class Product
        {
            public string Name { get; set; }

            public string Category { get; set; }

            public decimal Price { get; set; }

            public virtual decimal Discount()
            {
                return 0;
            }
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
