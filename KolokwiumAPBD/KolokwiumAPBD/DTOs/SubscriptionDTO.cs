namespace KolokwiumAPBD.DTOs;

public class SubscriptionDTO
{
    public int IdSubscription { get; set; }
    public string Name { get; set; }
    public int RenewalPeriod { get; set; }
    public DateOnly EndTime { get; set; }
    public float Price { get; set; }
    public List<PaymentDTO> Payments { get; set; }
    public List<DiscountDTO> Discounts { get; set; }
    public List<SaleDTO> Sales { get; set; }
}