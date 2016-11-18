using System.Windows.Input;

namespace Gameloop
{
    public class Game
    {
        public const int Fps = 60;
        public const int ScreenWidth = 50;
        public const int ScreenHeight = 50;

        private static int posx;
        private static int posy;

        public bool Over { get; }

        public Game()
        {
            Over = false;
        }

        public void Initialize()
        {
            posx = 5;
            posy = 5;
        }

        internal void Update()
        {
            if (Keyboard.IsKeyDown(Key.Up))
            {
                posy = posy - 1;
            }

            if (Keyboard.IsKeyDown(Key.Down))
            {
                posy = posy + 1;
            }

            if (Keyboard.IsKeyDown(Key.Left))
            {
                posx = posx - 1;
            }

            if (Keyboard.IsKeyDown(Key.Right))
            {
                posx = posx + 1;
            }
        }

        public void Draw(ConsoleCanvas canvas)
        {
            canvas.Draw('0', posx, posy);
        }

        
    }
}
