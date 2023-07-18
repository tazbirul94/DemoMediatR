using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DemoLibrary.Handlers
{
    public class GetPersonListHandler : IRequestHandler<GetTicketListQuery, List<TicketModel>>
    {
        private readonly IDataAccess _data;

        public GetPersonListHandler(IDataAccess data)
        {
           _data = data;
        }

        public async Task<List<TicketModel>> Handle(GetTicketListQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_data.GetTickets());
        }
    }
}
