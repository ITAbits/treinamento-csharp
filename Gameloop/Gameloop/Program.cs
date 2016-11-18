using System;

namespace Gameloop
{
    public class Program
    {
        private const int Fps = 60;

        private static void Main(string[] args)
        {
            var canvas = new ConsoleCanvas(10, 10);
            var game = new Game();

            game.Initialize();

            while (true)
            {
                var start = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
                
                // Very simple game loop
                game.Update();
                game.Draw(canvas);
                canvas.Render();

                // Make fps constant
                var deltaTime = start - DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
                System.Threading.Thread.Sleep((int)(1000.0f / Fps - deltaTime));
            }
        }
    }
    
}
