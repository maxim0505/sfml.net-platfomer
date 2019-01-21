
using System;
using SFML.Graphics;

namespace Platformer.Levels
{
    public class Logo : interfaces.Scene
    {
        private SFML.Graphics.Sprite SpLogo;
        private SFML.Graphics.Texture TexLogo;

        private SFML.Graphics.Color BackColor;
        private SFML.Graphics.Color SpColor;
        private bool Show = true;
        private int progress = 0;
        public Logo()
        {

            this.BackColor = new Color(50,50,50);
            TexLogo = new Texture("Resources//Logo.png");
            this.SpLogo = new SFML.Graphics.Sprite(TexLogo);
      
            this.SpColor = new SFML.Graphics.Color(0, 0, 0,1);
            //this.SpLogo.Scale = new SFML.System.Vector2f(0.3f, 0.3f);
            this.SpLogo.Position = new SFML.System.Vector2f((Constants.Screen_Width-SpLogo.Texture.Size.X) /2, 
                (Constants.Screen_Height - SpLogo.Texture.Size.Y) / 2);
            SpLogo.Color = new Color(255, 255, 255, 0);
        }

        public void Render(SFML.Graphics.RenderWindow window)
        {
            window.Draw(SpLogo);
        }

        public void Update(float delta)
        {
       
        }

        public void Dispose()
        {
            SpLogo.Dispose();
            

        }

        public Color GetBackColor()
        {
            return this.BackColor;
        }

        public void FixedUpdate()
        {
            if (SpLogo.Color.A < 255 && Show)
                progress++;
            else if (!Show && SpLogo.Color.A > 0)
                progress--;
            else
                Show = false;

            SpLogo.Color = new Color(255, 255, 255, (byte)Mathf.Lerp(0, 255, progress));
        }
    }
}
