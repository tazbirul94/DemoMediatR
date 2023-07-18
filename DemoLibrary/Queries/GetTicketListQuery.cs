using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Queries
{
    //IRequest<the data you want to output or return>
    public record GetTicketListQuery() : IRequest<List<TicketModel>>;

    //public class getpersonlistqueryclass : IRequest<List<PersonModel>>
    //{
    //}
}
