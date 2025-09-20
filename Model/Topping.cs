namespace BlazingPizza
{
    public class Topping
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string GetFormattedPrice()
        {
            var pt = System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR");
            return $"R$ {Price.ToString("N2", pt)}";
        }
    }
}
