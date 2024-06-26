namespace Restaurant_Site.server.Models.finances
{
    //Финансовая транзакция
    public class FinancialTransaction:BaseEntity
    {
        public decimal Amount { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public string? Description { get; set; }
    }
}
