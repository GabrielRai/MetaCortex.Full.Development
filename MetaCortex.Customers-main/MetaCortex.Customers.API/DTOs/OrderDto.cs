﻿using MetaCortex.Customers.DataAccess.Entities;

namespace MetaCortex.Customers.API.DTOs;

public class OrderDto : EntityBase
{
    public DateTime OrderDate { get; set; }
    public string CustomerId { get; set; }
    public string PaymentMethod { get; set; }
    public bool IsPaid { get; set; }
    public bool VIPStatus { get; set; }
}
