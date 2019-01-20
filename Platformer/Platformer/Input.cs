namespace Platformer
{
    static class Input
    {
        public static sbyte Horizontal = 0; // the horizontal axis
        public static sbyte Vertical   = 0; // the Vertical axis

        public static void PressedHandler(SFML.Window.Keyboard.Key key) // handler for pressing keys
        {
          
                switch (key)
                {
                    case SFML.Window.Keyboard.Key.Left:  // if left key is pressed
                        Horizontal = -1;
                        break;
                    case SFML.Window.Keyboard.Key.Right: // if right key is pressed
                        Horizontal =  1;
                        break;
                    case SFML.Window.Keyboard.Key.Up:    // if Up key is pressed
                        Vertical   = -1;
                        break;
                    case SFML.Window.Keyboard.Key.Down:  // if down key is pressed
                        Vertical   =  1;
                        break;
                }
            //Console.WriteLine("Key pressed: " + key.ToString());
            
        }
        public static void ReleaseHandler(SFML.Window.Keyboard.Key key) // key release handler
        {
            if (key == SFML.Window.Keyboard.Key.Left && Horizontal < 0 
                || key == SFML.Window.Keyboard.Key.Right && Horizontal > 0) // if left and right keys are released
                Horizontal = 0; // put the horizontal axis in its original position

            if (key == SFML.Window.Keyboard.Key.Up && Vertical < 0 
                || key == SFML.Window.Keyboard.Key.Down && Vertical > 0) // if up and down keys are released
                Vertical   = 0; // put the vertical axis in its original position

            //Console.WriteLine("key released: " + key.ToString());
        }
    }
}
