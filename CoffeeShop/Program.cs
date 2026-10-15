namespace CoffeeShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drink[] drinks = {
                new Coffee("Matcha",price:18,volume:330, 85,1),
                new Espresso("Mekiato",25,330,75),
                new Affogato("Belissima",22,75,temperature:85,5)

            };
            foreach (HotDrink drink in drinks)
            {
                
                    Console.WriteLine( drink.CalculatePrice());
            }
        }
    }
}
