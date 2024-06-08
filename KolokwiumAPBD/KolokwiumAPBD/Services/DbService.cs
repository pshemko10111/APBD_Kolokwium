using KolokwiumAPBD.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;

namespace KolokwiumAPBD.Services;

public class DbService : IDbService
{
    
    
    public async Task<IEnumerable<ClientDTO>> GetClientAsync(int IdClient)
    {
        throw new NotImplementedException();
    }

    public async Task AddSubscriptionPaymentAsync(int IdClient, int IdSubscription, float Payment)
    {
        return;
    }
}