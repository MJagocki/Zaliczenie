namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figura figura1 = new Figura("kwadrat");
            Console.WriteLine(figura1.WypiszDane());

            Prostokat figura2 = new Prostokat("Testowe",1,2);
            Console.WriteLine(figura2.WypiszDane());


        }
    }
}
