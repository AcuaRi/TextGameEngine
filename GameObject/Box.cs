namespace SokobanGame
{
    public class Box : GameObject
    {
        public Box(Point position) : base(position)
        {
            color = ConsoleColor.Cyan;
            name = 'B';
        }

        public void moveBox(Point direction)
        {
            position.x += direction.x;
            position.y += direction.y;
        }
        
        public override void Update(ConsoleKey key)
        {
            
        }
    }
}