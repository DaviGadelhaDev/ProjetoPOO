using System.Collections.Generic;
namespace ProjetoPOO.contextContent
{
    public class Career : Content
    {
        public Career(string title, string url)
            : base(title, url)
        {
            Items = new List<CareerItem>();
        }
        //items é os meus cursos
        public IList<CareerItem> Items { get; set; }

        //Sempre que for apenas uma linha podemos tirar o:
        /* get 
        {
            return Items.Count;
        } */
        //Chamamos isso de Expression Body
        public int TotalCourses => Items.Count;
           
    }
}