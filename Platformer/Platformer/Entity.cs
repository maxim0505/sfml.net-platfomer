

namespace Platformer
{
    public class Entity
    {
        private SFML.System.Vector2f Position; // the position of the object
        private float Rotation;  // the rotation of the object
        private SFML.Graphics.Color FillColor = SFML.Graphics.Color.White; // the fill color of the object

        public Entity() // Constructor sets zero position and rotation
        {
            this.Position = new SFML.System.Vector2f(0,0); 
            this.Rotation = 0;
        }
        public Entity(SFML.System.Vector2f Position,float Rotation) // The constructor sets the passed position and rotation
        {
            this.Position = Position;
            this.Rotation = Rotation;
        }
        public Entity(SFML.System.Vector2f Position, float Rotation,SFML.Graphics.Color FillColor) // The constructor sets the passed position, rotation and color of the object
        {
            this.Position  = Position;
            this.Rotation  = Rotation;
            this.FillColor = FillColor;
        }

        public void SetRotation(float Rotation) // method to change the object's rotation
        {
            this.Rotation = Rotation;
        }
        public void Move(SFML.System.Vector2f Position) // method for moving an object based on the current position
        {
            this.Position += Position;
        }
        public void SetFillColor(SFML.Graphics.Color FillColor) // method to change the color of an object
        {
            this.FillColor = FillColor;
        }
       

    }
}
