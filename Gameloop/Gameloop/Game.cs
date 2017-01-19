using System.Windows.Input;

namespace Gameloop
{
    public class Game
    {
        public const int Fps = 60;
        public const int ScreenWidth = 50;
        public const int ScreenHeight = 50;

        private Player player1;
        private Player player2;

        public bool Over { get; }

        public Game()
        {
            Over = false;
        }

        public void Initialize()
        {
            player1 = new Player('O', new PlayerInputMapping(Key.W, Key.S, Key.A, Key.D), 5, 5);
            player2 = new Player('U', new PlayerInputMapping(Key.I, Key.K, Key.J, Key.L), 15, 5);
        }

        internal void Update()
        {
            player1.Update();
            player2.Update();
        }

        public void Draw(ConsoleCanvas canvas)
        {
            player1.Draw(canvas);
            player2.Draw(canvas);
        }
    }
}
