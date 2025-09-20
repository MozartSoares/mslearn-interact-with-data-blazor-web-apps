using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazingPizza
{
    public class Order
    {
        public int OrderId { get; set; }

        public string UserId { get; set; }

        public DateTime CreatedTime { get; set; }

        public Address DeliveryAddress { get; set; } = new Address();

        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();

        public decimal GetTotalPrice() => Pizzas.Sum(p => p.GetTotalPrice());

        public string GetFormattedTotalPrice()
        {
            var pt = System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR");
            return $"R$ {GetTotalPrice().ToString("N2", pt)}";
        }
    }
}
