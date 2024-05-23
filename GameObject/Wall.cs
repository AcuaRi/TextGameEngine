namespace SokobanGame
{
    public class Wall : GameObject
    {
        //Constructor
        public Wall(Point position) : base(position)
        {
            color = ConsoleColor.DarkBlue;
            name = 'W';
        }
    }
}

