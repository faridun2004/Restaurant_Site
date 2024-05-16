namespace Restaurant_Site.Models.finances
{
    //Категория расходов
    public class ExpenseCategory:BaseEntity
    {
        public string? Name { get; set; }
        public List<Expense>?Expenses { get; set; }
    }
}
