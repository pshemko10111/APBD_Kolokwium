using KolokwiumAPBD.DTOs;
using KolokwiumAPBD.Models;
using KolokwiumAPBD.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace KolokwiumAPBD.Controllers;

[ApiController]
[Route("/client")]
public class ClientController : Controller
{
    private readonly IDbService _service;

    public ClientController(IDbService service)
    {
        _service = service;
    }
    
    [HttpGet("/{IdClient}")]
    public async Task<IActionResult> GetClientAsync(int IdClient)
    {
        return Ok(await _service.GetClientAsync(IdClient));
    }

    [HttpPost("/{IdClient}/{IdPayment}")]
    public async Task<IActionResult> AddSubscriptionPaymentAsync(int IdClient, int IdSubscription, float Payment)
    {
        return Ok();
        //return Ok(await _service.AddSubscriptionPaymentAsync(IdClient, IdSubscription, Payment));
    }
    
}