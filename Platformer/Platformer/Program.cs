using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer
{
    class Program
    {
        static void Main(string[] args)
        {
            SFML.Graphics.RenderWindow window = new SFML.Graphics.RenderWindow(new SFML.Window.VideoMode(1024, 768), "Platformer"); // create window
            window.Closed += Window_Closed; // connecting a window close listener
            while (window.IsOpen) // main loop
            {
                window.DispatchEvents();  // sending window events
            }
        }

        private static void Window_Closed(object sender, EventArgs e) // handling a window close event 
        {
            SFML.Graphics.RenderWindow window = (SFML.Graphics.RenderWindow)sender; // the conversion of the sender of the event in the window class
            window.Close(); // close the window
        }
    }
}
