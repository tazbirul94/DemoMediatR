using DemoLibrary.Models;
using DemoLibrary.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<TicketModel> tickets = new();

        public DemoDataAccess()
        {
            tickets.Add(new TicketModel() { Id = 1, FirstName = "Tazbirul", LastName = "Haque" });
            tickets.Add(new TicketModel() { Id = 2, FirstName = "Amma", LastName = "Nazma" });
        }

        public List<TicketModel> GetTickets()
        {
            return tickets;
        }

        public TicketModel InsertTicket(string FirstName, string LastName)
        {
            TicketModel p = new() { FirstName = FirstName, LastName = LastName };
            p.Id = tickets.Max(x => x.Id) + 1;
            tickets.Add(p);

            return p;
        }

        public MessageDto RemoveTicket(int id)
        {
            var getTicketById = tickets.FirstOrDefault(x => x.Id == id);
            _ = tickets.Remove(getTicketById);

            return new MessageDto();
        }
    }
}
