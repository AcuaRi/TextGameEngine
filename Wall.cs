namespace SokobaGame
{
    public class Wall : GameObject
    {
        //Constructor
        public Wall()
        {
            color = ConsoleColor.DarkBlue;
        }
        
        
        public override void Update(ConsoleKey key)
        {
        }

        public override void Draw()
        {
            //set console color
            Console.ForegroundColor = color;
            //draw
            Console.Write('W');
        }
    }
}

