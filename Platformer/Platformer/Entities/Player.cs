using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer.Entityes
{
    public class Player : Entity
    {
        

        public Player() : base()
        {
        }
        public Player(SFML.System.Vector2f Position, float Rotation) : base(Position, Rotation)
        {
            
        }
        public Player(SFML.System.Vector2f Position, float Rotation,SFML.Graphics.Color FillColor) : base(Position, Rotation,FillColor)
        {

        }
        
    }
}
