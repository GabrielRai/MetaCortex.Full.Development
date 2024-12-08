﻿namespace MetaCortex.Payments.DataAccess.Entities;

public class ProcessedOrder : BaseDocument
{
    public string OrderId { get; set; }
    public DateTime? OrderDate { get; set; }
    public string? CustomerId { get; set; }
    public string? PaymentMethod { get; set; }
    public bool IsPaid { get; set; }
    public bool? VIPStatus { get; set; }
    public List<string>? Products { get; set; }
    public Payment PaymentPlan { get; set; }
}