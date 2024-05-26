using ProjetoPOO.contextContent.Enums;

namespace ProjetoPOO.contextContent
{
    public class Course : Content
    {
        //sempre que trabalhamos com objetos dentro de objetos(inicializar o objeto)
        public Course(string title, string url)
            : base(title, url)
        {
            Modules = new List<Module>();
        }
        public string Tag { get; set; }
        public IList<Module> Modules  { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }

    }
}