
using System;
using SFML.Graphics;

namespace Platformer.Levels
{
    public class Logo : interfaces.Scene
    {
        private SFML.Graphics.Sprite SpLogo;    // the sprite for the logo
        private SFML.Graphics.Texture TexLogo;  // the texture for the logo
        private SFML.Graphics.Color BackColor;  // the background color for the scene
        private bool ShowLogo;                  // if true, show the logo
        private int progress = 0;               // the progress display of the logo

        public Logo()
        {
            this.ShowLogo = true;                               // show logo
            this.BackColor = new Color(50,50,50);               // set the background color
            this.TexLogo = new Texture("Resources//Logo.png");  // Load the logo texture
            this.SpLogo = new SFML.Graphics.Sprite(TexLogo);    // create a logo sprite
            this.SpLogo.Position = new SFML.System.Vector2f((Constants.Screen_Width-SpLogo.Texture.Size.X) /2, // move the sprite to 
                (Constants.Screen_Height - SpLogo.Texture.Size.Y) / 2);                                        // the center of the screen
            this.SpLogo.Color = new Color(255, 255, 255, 0);    // set the transparency of the sprite to 0
        }

        public void Render(SFML.Graphics.RenderWindow window)   // the method of rendering the scene
        {
            window.Draw(SpLogo);        // draw a logo
        }

        public void Update(float delta) // the method is executed on each frame
        {
       
        }
        public void Dispose()   // method of removing scenes
        {
            SpLogo.Dispose();   // remove sprite and texture
            TexLogo.Dispose();  //
        }
        public Color GetBackColor()   // the method of taking the colors of the background scene
        {
            return this.BackColor;
        }
        public void FixedUpdate()     // the Fixed_Update method runs after the specified time in microseconds (2000 microseconds by default)
        {
            if (SpLogo.Color.A < 255 && ShowLogo)       // the progress display of the logo
                progress++;                             
            else if (!ShowLogo && SpLogo.Color.A > 0) 
                progress--;
            else                                        // if the transparency of the logo is 255, turn off the display of the logo
                ShowLogo = false;

            SpLogo.Color = new Color(255, 255, 255, (byte)Mathf.Lerp(0, 255, progress)); // change the transparency of the logo
        }
    }
}
