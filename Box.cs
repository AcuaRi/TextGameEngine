namespace SokobaGame
{
    public class Box : GameObject
    {
        public Box()
        {
            color = ConsoleColor.Cyan;
        }
        
        public override void Update(ConsoleKey key)
        {
        }

        public override void Draw()
        {
            //set console color
            Console.ForegroundColor = color;
            //draw
            Console.Write('B');
        }
    }
}