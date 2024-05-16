namespace Restaurant_Site.Models.finances
{
    //Класс Кассовый аппарат
    public class CashRegister: BaseEntity
    {
        //Денежная сумма
        public decimal CashAmount { get; set; }
        //РегистрацияДатаВремя
        public DateTime RegisterDateTime { get; set; }
    }
}
