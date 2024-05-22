namespace SokobaGame
{
    public class Player : GameObject
    {
        public Player()
        {
            color = ConsoleColor.Red;
        }
        
        public override void Update(ConsoleKey key)
        {
        }

        public override void Draw()
        {
            //set console color
            Console.ForegroundColor = color;
            //draw
            Console.Write('P');
        }
    }
}