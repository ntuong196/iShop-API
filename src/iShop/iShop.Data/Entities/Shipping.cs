﻿using System;
using iShop.Data.Base;

namespace iShop.Data.Entities
{
    public class Shipping : KeyEntity, IEntityBase
    {
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public DateTime ShippingDate { get; set; }
        public ShippingState ShippingState { get; set; } = ShippingState.None;
        public double Charge { get; set; }
        public string Ward { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName  { get; set; }
    }
}
