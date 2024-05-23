using System.Diagnostics;

namespace SokobanGame
{
    public class Scene
    {
        //classify for depth on draw
        private List<GameObject> gameObjects = new List<GameObject>();
        //box
        private List<Box> boxes = new List<Box>();
        //target
        private List<Target> targets = new List<Target>();
        //player
        private Player player;
        //game manager
        private GameManager gameManager;
        
        public Scene(string mapFileName)
        {
            Load(mapFileName);
            gameManager = new GameManager(targets.Count);
        }

        // check move is enable
        public bool CanMove(Point newPosition)
        {
            return gameManager.CanMove(
                newPosition, 
                player, 
                gameObjects, 
                boxes, 
                targets
            );
        }
        
        //read map file
        private void Load(string filename)
        {
            //get data from mapfile
            string[] lines =  File.ReadAllLines(filename);
            //foreach (var line in lines)
            for(int y = 0; y < lines.Length; y++)
            {
                char[] lineChars = lines[y].ToCharArray();
                //foreach (var c in lineChars)
                for(int x = 0; x < lineChars.Length; x++)
                {
                    GameObject replace;
                    Point position = new Point(x, y);
                    
                    switch (lineChars[x])
                    {
                        //wall
                        case '1':
                            replace = new Wall(position);
                            break;
                        //ground
                        case '.':
                            replace = new Ground(position);
                            break;
                        //player
                        case 'p':
                            player = new Player(position, this);
                            replace = new Ground(position);
                            break;
                        //target
                        case 't':
                            Target newTarget = new Target(position);
                            replace = newTarget;
                            targets.Add(newTarget);
                            break;
                        //box
                        case 'b':
                            boxes.Add( new Box(position) );
                            replace = new Ground(position);
                            break;
                        //default : set as wall
                        default:
                            replace = new Wall(position);
                            break;
                    }
                    gameObjects.Add(replace);
                }
            }
            
            
        }

        public void Update(ConsoleKey key)
        {
            if (gameManager.IsGameClear == true)
            {
                return;
            }
            
            foreach (var gameObject in gameObjects)
            {
                gameObject.Update(key);
            }
            
            foreach (var box in boxes)
            {
                box.Update(key);
            }
            
            player.Update(key);
            gameManager.UpdateScore(boxes, targets);
        }

        public void Draw()
        {
            //draw menu
            DrawMenu();

            if (gameManager.IsGameClear == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(0, 1);
                Console.Write("  게임 클리어");
            }
            
            //draw stage(level)
            foreach (var gameObject in gameObjects)
            {
                gameObject.Draw();
            }
            
            foreach (var box in boxes)
            {
                box.Draw();
            }
            
            player.Draw();
        }
        
        public void DrawMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" | Press Q for exit");
        }
    }
}

