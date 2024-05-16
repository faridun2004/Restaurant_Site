namespace Restaurant_Site.Models.finances
{
    //Class Расход
    public class Expense: BaseEntity
    {
        public string? Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime ExpenseDateTime { get; set; }
        public ExpenseCategory? Category { get; set; }
        public Guid CategoryId { get; internal set; }
    }
}
