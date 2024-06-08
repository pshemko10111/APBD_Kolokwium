namespace KolokwiumAPBD.DTOs;

public class ClientDTO
{
    public int IdClient { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public List<PaymentDTO> Payments { get; set; }
    public List<SaleDTO> Sales { get; set; }
}