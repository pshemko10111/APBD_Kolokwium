﻿namespace KolokwiumAPBD.Models;

public class Client
{
    public int IdClient { get; set; } 
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
    
}