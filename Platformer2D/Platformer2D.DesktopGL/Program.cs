using System;

namespace Platformer2D.DesktopGL
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            // TODO: Create a new instance of the PlatformerGame Class called game
            using (var game = new PlatformerGame())

            // TODO: Call the Run() method of the game object to run the game
                game.Run();
        }
    }
}
