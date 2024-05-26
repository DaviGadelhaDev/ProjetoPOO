using ProjetoPOO.SharedContent;

namespace ProjetoPOO.contextContent
{
     public class Module : Base
    {
        public Module()
        {
            Lectures = new List<Lecture>();
        }
        public int Order { get; set; }
        public string Title { get; set; }

        public IList<Lecture> Lectures { get; set; }
    }

    
}