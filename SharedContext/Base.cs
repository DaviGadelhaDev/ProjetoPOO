using ProjetoPOO.NotificationContext;

namespace ProjetoPOO.SharedContent
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}