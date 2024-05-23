using System;

namespace SokobanGame
{
    //Game Engine
    public class GameEngine
    {
        //main scene field
        private Scene scene;

        //Constructor
        public GameEngine()
        {
            scene = new Scene("Stage.txt");
        }
        
        //Run Method(Interface)
        public void Run()
        {
            //hide cursor
            Console.CursorVisible = false;
            //set title
            Console.Title = "Socoban Game";
            
            //draw first frame
            Draw();
            
            while (true)
            {
                //screen clear
                ResetScreen();
                
                //update (react for user input)
                Update(Console.ReadKey().Key);
                
                //draw scene
                Draw();
                
                //Console.WriteLine("Game Execute");
            }
        }

        //screen clear method
        private void ResetScreen()
        {
            //Initialize color of text in console screen
            Console.ForegroundColor = ConsoleColor.White;
            
            //set cursor position to (0, 0)
            Console.SetCursorPosition(0, 0);
            
            //clear console screen
            //Console.Clear();
        }

        //update method(pass user input)
        private void Update(ConsoleKey key)
        {
            
            //press Q or Esc to exit
            if (key == ConsoleKey.Q || key == ConsoleKey.Escape)
            {
                ResetScreen();
                Console.Clear();
                
                Console.WriteLine("Game Over");
                //program terminated
                Environment.Exit(0);
            }
            
            scene.Update(key);
        }
        
        //scene draw method
        private void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            scene.Draw();
            //Console.WriteLine("Draw Scene");
        }
    }
    
}