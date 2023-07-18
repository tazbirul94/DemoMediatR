using DemoLibrary.DataAccess;
using DemoLibrary.Queries;
using DemoLibrary.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class RemovePersonByIdQueryHandler : IRequestHandler<RemoveTicketByIdQuery, MessageDto>
    {
        private readonly IDataAccess _data;

        public RemovePersonByIdQueryHandler(IDataAccess data)
        {
            _data = data;
        }
        public async Task<MessageDto> Handle(RemoveTicketByIdQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_data.RemoveTicket(request.id));
        }
    }
}
