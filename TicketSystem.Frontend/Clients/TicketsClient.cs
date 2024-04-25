using TicketSystem.Frontend.Models;

namespace TicketSystem.Frontend.Clients;

public class TicketsClient(HttpClient httpClient)
{
    public async Task<Ticket[]> GetTicketsAsync() 
        => await httpClient.GetFromJsonAsync<Ticket[]>("tickets") ?? [];

    public async Task AddTicketAsync(Ticket ticket)
        => await httpClient.PostAsJsonAsync("tickets", ticket);

    public async Task<Ticket> GetTicketAsync(int id)
        => await httpClient.GetFromJsonAsync<Ticket>($"tickets/{id}")
            ?? throw new Exception("Could not find ticket!");

    public async Task UpdateTicketAsync(Ticket updatedTicket)
        => await httpClient.PutAsJsonAsync($"tickets/{updatedTicket.Id}", updatedTicket);

    public async Task DeleteTicketAsync(int id)
        => await httpClient.DeleteAsync($"tickets/{id}");
}
