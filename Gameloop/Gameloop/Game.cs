using System.Windows.Input;

namespace Gameloop
{
    public class Game
    {
        public const int Fps = 60;
        public const int ScreenWidth = 50;
        public const int ScreenHeight = 50;

        class Character
        {
            public int Posx = 5;
            public int Posy = 5;

            public char Sprite = 'O';

            public void Update()
            {
                if (Keyboard.IsKeyDown(Key.Up))
                {
                    Posy = Posy - 1;
                }

                if (Keyboard.IsKeyDown(Key.Down))
                {
                    Posy = Posy + 1;
                }

                if (Keyboard.IsKeyDown(Key.Left))
                {
                    Posx = Posx - 1;
                }

                if (Keyboard.IsKeyDown(Key.Right))
                {
                    Posx = Posx + 1;
                }
            }

            public void Draw(ConsoleCanvas canvas)
            {
                canvas.Draw(Sprite, Posx, Posy);
            }
        }

        private Character player;

        public bool Over { get; }

        public Game()
        {
            Over = false;
        }

        public void Initialize()
        {
            player = new Character();
        }

        internal void Update()
        {
            player.Update();
        }

        public void Draw(ConsoleCanvas canvas)
        {
            player.Draw(canvas);
        }
    }
}
