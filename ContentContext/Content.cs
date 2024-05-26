using ProjetoPOO.SharedContent;

namespace ProjetoPOO.contextContent
{
    public abstract class Content : Base
    {
        public Content(string title, string url)
        {
            //SPOF
            Title = title;
            Url = url;
        }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}