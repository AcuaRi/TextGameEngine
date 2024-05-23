namespace SokobanGame
{
    public class Target : GameObject
    {
        public Target(Point position) : base(position)
        {
            color = ConsoleColor.Yellow;
            name = 'T';
        }
    }
}