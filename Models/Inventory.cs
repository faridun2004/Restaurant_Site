﻿namespace Restaurant_Site.server.Models
{
    // Класс модели для склада
    public class Inventory : BaseEntity
    {
        public string? Name { get; set; }
        public int? Quantity { get; set; }
    }
}
