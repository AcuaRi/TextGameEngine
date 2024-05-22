namespace SokobaGame
{
    //basic gameObject Class(abstract)
    public abstract class GameObject
    {
        //color value
        protected ConsoleColor color = ConsoleColor.White;
        
        
        //update
        public abstract void Update(ConsoleKey key);
        
        //draw
        public abstract void Draw();
    } 
}

