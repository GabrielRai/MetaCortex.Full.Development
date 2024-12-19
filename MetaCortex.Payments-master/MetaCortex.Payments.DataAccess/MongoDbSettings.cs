﻿namespace MetaCortex.Payments.DataAccess;

public class MongoDbSettings
{
    public string? Host { get; set; }
    public string? Port { get; set; }
    public string? DatabaseName { get; set; }
    public string? CollectionName { get; set; }
}