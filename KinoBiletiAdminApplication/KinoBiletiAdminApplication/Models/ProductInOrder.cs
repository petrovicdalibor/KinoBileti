using System;

namespace KinoBiletiAdminApplication.Models
{
    public class ProductInOrder
    {
        public Guid ProductId { get; set; }
        public Product OrderedProduct { get; set; }
        public Guid OrderId { get; set; }
        public Order UserOrder { get; set; }
        public int Quantity { get; set; }
    }
}
