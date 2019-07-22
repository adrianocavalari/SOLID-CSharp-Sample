using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Interface Segregation Principle
/// Clients should not be forced to implement any methods they don’t use. Rather than one fat interface, 
///     numerous little interfaces are preferred based on groups of methods with each interface serving one submodule
/// </summary>

namespace SOLIDSample.ISP
{

    public class BadWay
    {
        public interface IPromotion
        {
            decimal Price { get; set; }

            decimal CalculatePrice();

            decimal CalculateSuperPrice();
        }

        public class PromotionOne : IPromotion
        {
            public decimal Price { get; set; }

            public decimal CalculatePrice()
            {
                return Price * 10;
            }

            //Not implemented 
            public decimal CalculateSuperPrice()
            {
                throw new NotImplementedException();
            }
        }

    }

    public class ISP
    {
        public interface IPromotion
        {
            decimal Price { get; set; }

            decimal CalculatePrice();
        }

        public interface ISuperPromotion
        {
            decimal CalculateSuperPrice();
        }

        public class PromotionOne : IPromotion
        {
            public decimal Price { get; set; }

            public decimal CalculatePrice()
            {
                return Price * 10;
            }
        }

        public class PromotionTwo : IPromotion, ISuperPromotion
        {
            public decimal Price { get; set; }

            public decimal CalculatePrice()
            {
                return Price * 10;
            }

            public decimal CalculateSuperPrice()
            {
                return Price * 50;
            }
        }
    }
}
