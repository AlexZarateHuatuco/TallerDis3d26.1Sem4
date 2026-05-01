namespace Taller3dSemana4
{
    internal abstract class Scenes
    {
        protected string title;
        protected string description;
        public Scenes(string t, string d)
        {
            title = t;
            description = d;
        }
        public abstract void Play();
    }
}