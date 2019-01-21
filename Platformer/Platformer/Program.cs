using System;

namespace Platformer
{
    class Program
    {
        static void Main(string[] args)
        {
            SFML.Graphics.RenderWindow window =
            new SFML.Graphics.RenderWindow(new SFML.Window.VideoMode(Constants.Screen_Width, Constants.Screen_Height), "Platformer"); // create window
            interfaces.Scene scene;
            scene = new Levels.Logo();
            SFML.System.Clock clock = new SFML.System.Clock(); // the time counter from the start of the game
            long Time = 0; // the time counter for Delta
            long Timefixed = 0; // the time counter for Fixed_Update
            window.Closed += Window_Closed;           // connecting a window close listener
            window.KeyPressed += Window_KeyPressed;   // connecting a listener to a keystroke event
            window.KeyReleased += Window_KeyReleased; // connecting a listener to a key release event
            //window.SetFramerateLimit(65);
            window.SetVerticalSyncEnabled(true); // enable vertical sync

            while (window.IsOpen) // main loop
            {
                
                Time = clock.ElapsedTime.AsMicroseconds(); // reset the time counter for Delta
                window.DispatchEvents();  // sending window events
            
                Update(scene, clock.ElapsedTime.AsMicroseconds() - Time); // call the Update method
                if (clock.ElapsedTime.AsMicroseconds() - Timefixed >= Constants.Fixed_Delta) // if equal to or greater than the specified time
                {
                    FixedUpdate(scene);  // call the Fixed_Update method
                    Timefixed = clock.ElapsedTime.AsMicroseconds();  // reset the time counter
                }
                Render(scene, window);
                System.Threading.Thread.Sleep(2); // to stop the thread of 1 millisecond, to reduce the load on the processor

            }
            scene.Dispose();  //remove the scene
            clock.Dispose();  //remove the timer
            window.Dispose(); //remove the window
         

        }

        private static void Window_KeyReleased(object sender, SFML.Window.KeyEventArgs e) // key release event listener
        {
            Input.ReleaseHandler(e.Code); // transfer to the handler the release keys in a static class Input

        }

        private static void Window_KeyPressed(object sender, SFML.Window.KeyEventArgs e) // key press event listener
        {
            SFML.Graphics.RenderWindow window = (SFML.Graphics.RenderWindow)sender; // the conversion of the sender of the event in the window class

            if (e.Code == SFML.Window.Keyboard.Key.Escape) // close the window if the Escape key is pressed
                window.Close(); // close the window
            else
                Input.PressedHandler(e.Code); // the transfer handler for the Pressed keys in a static class Input
        }

        private static void Window_Closed(object sender, EventArgs e) // handling a window close event 
        {
            SFML.Graphics.RenderWindow window = (SFML.Graphics.RenderWindow)sender; // the conversion of the sender of the event in the window class
            window.Close(); // close the window
        }
        private static void Render(interfaces.Scene scene, SFML.Graphics.RenderWindow window) // Main rendering method
        {
            window.Clear(scene.GetBackColor()); // clear the window
            scene.Render(window); // call the rendering method in the current scene
            window.Display(); // displays the current frame
        }
        private static void Update(interfaces.Scene scene, float delta) // the Update method is executed on each frame
        {
            scene.Update(delta * 0.000001f); // execute the Update method in the current scene
        }
        private static void FixedUpdate(interfaces.Scene scene) // the Fixed_Update method runs after the specified time in microseconds (2000 microseconds by default)
        {
            scene.FixedUpdate();  // execute the Fixed_Update method in the current scene
        }
    }
}
