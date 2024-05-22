namespace SokobaGame
{
    public class Ground : GameObject
    {
        public Ground()
        {
            color = ConsoleColor.DarkGreen;
        }
        
        public override void Update(ConsoleKey key)
        {
        }

        public override void Draw()
        {
            //set console color
            Console.ForegroundColor = color;
            //draw
            Console.Write('_');
        }
    }
}

