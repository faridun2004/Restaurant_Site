namespace Restaurant_Site.Models
{
    // Класс модели для отзыва
    public class Review : BaseEntity
    {
        public string Comment { get; set; }
        public int Rating { get; set; }
    }
}
