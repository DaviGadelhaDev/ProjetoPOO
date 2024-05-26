namespace ProjetoPOO.contextContent
{
    //Não é ruim ter uma classe vazia
    public class Article : Content
    {
        public Article(string title, string url)
        //passando esses parâmetros para o ctro de Content
            : base(title, url)
        {
            
        }
    }
}