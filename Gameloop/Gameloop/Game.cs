namespace Gameloop
{
    public class Game
    {
        private static int posx;
        private static int posy;

        public void Initialize()
        {
            posx = 5;
            posy = 5;
        }

        internal void Update()
        {
            posx = (posx + 1) % 10;
        }

        public void Draw(ConsoleCanvas canvas)
        {
            canvas.Draw('@', posx, posy);
        }

        
    }
}
