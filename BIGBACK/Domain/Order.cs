﻿namespace BIGBACK.Domain
{
    public class Order: BaseDomainModel
    {
        public DateTime OrderDateTime { get; set; }
        public string? OrderStatus { get; set; }
        public int? OrderTotal { get; set; }
        public int CustomerId { get; set; }
    }
}