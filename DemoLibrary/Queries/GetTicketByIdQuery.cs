using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Queries
{
    public record GetTicketByIdQuery(int id) : IRequest<TicketModel>;

    //public class GetTicketByIdClass : IRequest<PersonModel>
    //{
    //    public int Id { get; set; }

    //    public GetPersonByIdClass(int id)
    //    {
    //        Id = id;
    //    }
    //}
}
