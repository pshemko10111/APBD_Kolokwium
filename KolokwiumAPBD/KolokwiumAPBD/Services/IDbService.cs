using KolokwiumAPBD.DTOs;

namespace KolokwiumAPBD.Services;

public interface IDbService
{
    public Task<IEnumerable<ClientDTO>> GetClientAsync(int IdClient);
    public Task AddSubscriptionPaymentAsync(int IdClient, int IdSubscription, float Payment);
}