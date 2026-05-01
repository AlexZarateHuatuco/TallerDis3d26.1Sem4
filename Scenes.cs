namespace Taller3dSemana4
{
    internal class Scenes
    {
        protected string title;
        protected string description;
        public Situation(string t, string d)
        {
            title = t;
            description = d;
        }
        public abstract void Play();
    }
}