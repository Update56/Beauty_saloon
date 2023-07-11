using Microsoft.Xna.Framework;
using Project4.Code;

internal class Program
{
    private static void Main(string[] args)
    {
        using var game = new Project4.Code.Game1();
        game.Run();
    }
}