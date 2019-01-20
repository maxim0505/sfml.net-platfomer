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
            SFML.Graphics.RenderWindow window = 
                new SFML.Graphics.RenderWindow(new SFML.Window.VideoMode(1024, 768), "Platformer"); // create window

            window.Closed += Window_Closed; // connecting a window close listener
            window.KeyPressed += Window_KeyPressed; // connecting a listener to a keystroke event
            window.KeyReleased += Window_KeyReleased; // connecting a listener to a key release event

            while (window.IsOpen) // main loop
            {
                window.DispatchEvents();  // sending window events
                System.Threading.Thread.Sleep(1); // to stop the thread of 1 millisecond, to reduce the load on the processor
            }
            window.Dispose(); //remove the window
        }

        private static void Window_KeyReleased(object sender, SFML.Window.KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void Window_KeyPressed(object sender, SFML.Window.KeyEventArgs e)
        {
            SFML.Graphics.RenderWindow window = (SFML.Graphics.RenderWindow)sender; // the conversion of the sender of the event in the window class

            if (e.Code == SFML.Window.Keyboard.Key.Escape) // close the window if the Escape key is pressed
            {
                window.Close(); // close the window
            }
        }

        private static void Window_Closed(object sender, EventArgs e) // handling a window close event 
        {
            SFML.Graphics.RenderWindow window = (SFML.Graphics.RenderWindow)sender; // the conversion of the sender of the event in the window class
            window.Close(); // close the window
        }
    }
}
