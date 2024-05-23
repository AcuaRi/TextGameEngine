namespace SokobanGame
{
    //basic gameObject Class(abstract)
    public class GameObject
    {
        //color value
        protected ConsoleColor color = ConsoleColor.White;

        protected char name;

        public Point position { get; set; } = new Point();

        public GameObject(Point position)
        {
            SetPosition(position);
        }
        
        public void SetPosition(Point position)
        {
            this.position.x = position.x;
            this.position.y = position.y;
        }
        
        //update
        public virtual void Update(ConsoleKey key)
        {
            
        }
        
        //draw
        public virtual void Draw()
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(position.x *2 ,position.y + 2);
            Console.Write(name);
        }
    } 
}

