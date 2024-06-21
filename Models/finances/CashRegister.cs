namespace Restaurant_Site.server.Models.finances
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
