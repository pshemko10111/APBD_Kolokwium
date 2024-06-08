namespace KolokwiumAPBD.Models;

public class Discount
{
    public int IdDiscount { get; set; }
    public int Value { get; set; } 
    public DateOnly DateFrom { get; set; } 
    public DateOnly DateTo { get; set; }
    
}