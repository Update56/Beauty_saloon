using Project4.Code;

internal class Program
{
    private static void Main(string[] args)
    {
        Saloon saloon = new Saloon(); //экземпляр класса Салон

        using var game = new Project4.Code.Game1();
        game.Run();
    }
}