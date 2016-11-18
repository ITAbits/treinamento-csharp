using System.Windows.Input;

namespace Gameloop
{
    public class Game
    {
        public const int Fps = 60;
        public const int ScreenWidth = 50;
        public const int ScreenHeight = 50;

        private Character player;

        public bool Over { get; }

        public Game()
        {
            Over = false;
        }

        public void Initialize()
        {
            player.Posx = 5;
            player.Posy = 5;
            player.Sprite = 'O';
        }

        internal void Update()
        {
            if (Keyboard.IsKeyDown(Key.Up))
            {
                player.Posy = player.Posy - 1;
            }

            if (Keyboard.IsKeyDown(Key.Down))
            {
                player.Posy = player.Posy + 1;
            }

            if (Keyboard.IsKeyDown(Key.Left))
            {
                player.Posx = player.Posx - 1;
            }

            if (Keyboard.IsKeyDown(Key.Right))
            {
                player.Posx = player.Posx + 1;
            }
        }

        public void Draw(ConsoleCanvas canvas)
        {
            canvas.Draw('0', player.Posx, player.Posy);
        }
    }

    struct Character
    {
        public int Posx;
        public int Posy;

        public char Sprite;
    }
}
