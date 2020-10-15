using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class GameControls
    {
        public void CalculeLogic() { };

        public void Render() { };
    }

    public interface IRenderObject
    {
        public void Render();
    }

    public class GameObject : IRenderObject 
    {
        public TypeObject GetType() { };
    }

    public interface IMove
    {
        public Position MoveToPosition(Position position);

        public Position abortMoving(Position position);
    }

    public interface IChecks
    {
        public bool isFood(GameObject gameObject);

        public bool isObstacle(GameObject gameObject);
    }
    
    public class Enemy : GameObject, IMove, IChecks { };

    public class Player : Enemy
    {
        public void AddBonus(GameObject gameObject) { };
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
