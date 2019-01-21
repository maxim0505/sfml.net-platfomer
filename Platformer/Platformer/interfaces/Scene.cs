
namespace Platformer.interfaces
{
    interface Scene
    {
        void Update(float delta);
        void FixedUpdate();
        void Render(SFML.Graphics.RenderWindow window);
        void Dispose();
        SFML.Graphics.Color GetBackColor();
    }
}
