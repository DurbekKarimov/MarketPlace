﻿using System.ComponentModel.DataAnnotations;
using TechStation.Domain.Commons;

namespace TechStation.Domain.Entities;

public class Product : Auditable
{
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public long CategoryId { get; set; }
    public string Images { get; set; }
    public Category Category { get; set; }
    public long BrendId { get; set; }
    public Brend Brend { get; set; }
}
