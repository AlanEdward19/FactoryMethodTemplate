﻿namespace Core.ValueObjects;

public class DeliveryAddressValueObject
{
    public string Street { get; set; }
    public string Number { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
}