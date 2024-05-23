namespace SokobanGame
{
    //game core logic
    public class GameManager
    {
        //field
        ////score
        private int currentScore = 0;
        private int targetScore = 0;

        public bool IsGameClear
        {
            get
            {
                return currentScore == targetScore;
            }
        }
        
        //constructor
        public GameManager(int targetScore)
        {
            this.targetScore = targetScore;
            currentScore = 0;
        }
        
        /// <summary>
        /// check move enable(interface).
        /// </summary>
        /// <param name="newPosition">goal position</param>
        /// <param name="player">player</param>
        /// <param name="gameObjects">default game object list</param>
        /// <param name="boxes">box object list</param>
        /// <param name="targets">target object list</param>
        public bool CanMove(Point newPosition, Player player, List<GameObject> gameObjects, List<Box> boxes, List<Target> targets)
        {
            if (gameObjects == null || gameObjects.Count == 0)
            {
                return false;
            }

            Box? searchBox = boxes.Find(go => go.position.Equals(newPosition));

            if (searchBox != null)
            {
                Point direction = new Point();
                direction.x = newPosition.x - player.position.x;
                direction.y = newPosition.y - player.position.y;

                Point newBoxPosition =
                    new Point(direction.x + searchBox.position.x, direction.y + searchBox.position.y);

                Box? anotherBox = boxes.Find(go => go.position.Equals(newBoxPosition));
                if (anotherBox != null)
                {
                    return false;
                }
                
                GameObject? finalFound = gameObjects.Find(go => go.position.Equals(newBoxPosition));
                if (finalFound != null)
                {
                    if (finalFound is Ground || finalFound is Target)
                    {
                        searchBox.moveBox(direction);
                        return true;
                    }
                }
                
                return false;
            }
            
            GameObject? searchObject = gameObjects.Find(go => go.position.Equals(newPosition));
            
            if(searchObject != null)
            {
                return (searchObject is Wall) == false;
            }
            
            return false;
        }

        public void UpdateScore(List<Box> boxes, List<Target> targets)
        {
            currentScore = 0;
            foreach (var box in boxes)
            {
                foreach (var target in targets)
                {
                    if (box.position.Equals(target.position) == true)
                    {
                        currentScore++;
                        continue;
                    }
                }
            }
        }
    }
}

