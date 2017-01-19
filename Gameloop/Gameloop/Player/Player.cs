using System;
using System.Windows.Input;

namespace Gameloop
{
    class PlayerInputMapping
    {
        public Key Up;
        public Key Down;
        public Key Left;
        public Key Right;

        public PlayerInputMapping(Key up, Key down, Key left, Key right)
        {
            Up = up;
            Down = down;
            Left = left;
            Right = right;
        }
    }

    class Player
    {
        public int Posx = 5;
        public int Posy = 5;

        public char Sprite;

        private PlayerInputMapping input;

        public Player(char sprite, PlayerInputMapping inputMapping)
        {
            Sprite = sprite;
            input = inputMapping;
        }

        public Player(char sprite, PlayerInputMapping inputMapping, int posx, int posy)
        {
            Sprite = sprite;
            input = inputMapping;
            Posx = posx;
            Posy = posy;
        }

        public void Update()
        {
            if (Keyboard.IsKeyDown(input.Up))
            {
                Posy = Posy - 1;
            }

            if (Keyboard.IsKeyDown(input.Down))
            {
                Posy = Posy + 1;
            }

            if (Keyboard.IsKeyDown(input.Left))
            {
                Posx = Posx - 1;
            }

            if (Keyboard.IsKeyDown(input.Right))
            {
                Posx = Posx + 1;
            }
        }

        public void Draw(ConsoleCanvas canvas)
        {
            canvas.Draw(Sprite, Posx, Posy);
        }
    }
}
