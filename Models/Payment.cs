namespace Restaurant_Site.server.Models
{
    // Класс модели для оплаты
    public class Payment: BaseEntity
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
