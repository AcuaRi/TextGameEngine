namespace SokobaGame
{
    public class Target : GameObject
    {
        public Target()
        {
            color = ConsoleColor.Yellow;
        }
        
        public override void Update(ConsoleKey key)
        {
        }

        public override void Draw()
        {
            //set console color
            Console.ForegroundColor = color;
            //draw
            Console.Write('T');
        }
    }
}