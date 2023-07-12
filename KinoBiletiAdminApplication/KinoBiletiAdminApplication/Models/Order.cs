using System;
using System.Collections.Generic;

namespace KinoBiletiAdminApplication.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public KinoBiletiUser User { get; set; }
        public ICollection<ProductInOrder> ProductInOrders { get; set; }
    }
}
