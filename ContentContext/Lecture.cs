using ProjetoPOO.contextContent.Enums;
using ProjetoPOO.SharedContent;
namespace ProjetoPOO.contextContent
{
    //Aparentemente usamos o Lectute para não confundir, pois ira ficar public class Class
    public class Lecture : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}