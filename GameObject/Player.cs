namespace SokobanGame
{
    public class Player : GameObject
    {
        private Scene scene;
        
        public Player(Point position, Scene scene) : base(position)
        {
            this.scene = scene;
            color = ConsoleColor.Red;
            name = 'P';
        }

        public override void Update(ConsoleKey key)
        {
            //Console.Clear();
            switch (key)
            {
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    if (scene.CanMove(new Point(position.x - 1, position.y)))
                    {
                        position.x -= 1;
                    }
                    break;
                
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    if (scene.CanMove(new Point(position.x + 1, position.y)))
                    {
                        position.x += 1;
                    }
                    break;
                
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    if (scene.CanMove(new Point(position.x, position.y - 1)))
                    {
                        position.y -= 1;
                    }
                    
                    break;
                
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    if (scene.CanMove(new Point(position.x, position.y + 1)))
                    {
                        position.y += 1;
                    }
                   
                    break;
            }
        }
    }
}