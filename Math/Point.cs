namespace SokobanGame
{
    public class Point
    {
        //field
        public int x { get; set; } = 0;
        public int y { get; set; } = 0;
        
        //constructor
        public Point()
        {
            x = y = 0;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
        //compare method
        public override bool Equals(object? obj)
        {
            Point? other = obj as Point;
            if (other == null)
            {
                return false;
            }

            return (this.x == other.x && this.y == other.y);

        }
    }
}

