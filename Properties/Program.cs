namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cookie c = new Cookie();
           // c.SetFlavor("Vanilla");
           
           
            c.Flavor = "Straberry";
            Console.WriteLine(c.Flavor); 

        }
    }
}