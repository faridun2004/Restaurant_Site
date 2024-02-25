namespace Restaurant_Site.Models
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }
        public override string ToString()
        {
            return $"Id:{Id} ({GetType().Name})";
        }
    }
}
