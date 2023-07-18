using DemoLibrary.Models;
using DemoLibrary.Responses;

namespace DemoLibrary.DataAccess
{
    public interface IDataAccess
    {
        List<TicketModel> GetTickets();
        TicketModel InsertTicket(string FirstName, string LastName);
        MessageDto RemoveTicket(int id);
    }
}