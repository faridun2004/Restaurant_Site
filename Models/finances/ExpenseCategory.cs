namespace Restaurant_Site.server.Models.finances
{
    
    public class ExpenseCategory:BaseEntity
    {
        public string? Name { get; set; }
        public List<Expense>?Expenses { get; set; }
    }
}
