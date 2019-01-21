

namespace Platformer
{
    public static class Mathf
    {
        public static int Lerp(int fromValue, int toValue,int progress)
        {
            return (int)((float)fromValue + (float)(toValue - fromValue) * (float)(progress*0.01f));
        }
    }
}
