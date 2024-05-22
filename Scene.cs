namespace SokobaGame
{
    public class Scene
    {
        //private List<char> mapData = new List<char>();
        private List<GameObject> mapData = new List<GameObject>();
        
        public Scene(string mapFileName)
        {
            Load(mapFileName);
        }

        //read map file
        private void Load(string filename)
        {
            //get data from mapfile
            string[] lines =  File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                char[] lineChars = line.ToCharArray();
                foreach (var c in lineChars)
                {
                    GameObject replace;
                    switch (c)
                    {
                        //wall
                        case '1':
                            replace = new Wall();
                            break;
                        //ground
                        case '.':
                            replace = new Ground();
                            break;
                        //player
                        case 'p':
                            replace = new Player();
                            break;
                        //target
                        case 't':
                            replace = new Target();
                            break;
                        //box
                        case 'b':
                            replace = new Box();
                            break;
                        //default : set as wall
                        default:
                            replace = new Wall();
                            break;
                    }
                    mapData.Add(replace);
                }
            }
            
            
        }

        public void Update(ConsoleKey key)
        {
            foreach (var gameObject in mapData)
            {
                gameObject.Update(key);
            }
        }

        public void Draw()
        {
            int index = 0;
            foreach (var gameObject in mapData)
            {
                Console.Write("  ");
                gameObject.Draw();

                index++;
                if (index % 10 == 0)
                {
                    Console.WriteLine("\n");
                }
            }
        }
    }
}

