using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class GetTicketByIdQueryHandler : IRequestHandler<GetTicketByIdQuery, TicketModel>
    {
        private readonly IMediator _mediator;

        public GetTicketByIdQueryHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<TicketModel> Handle(GetTicketByIdQuery request, CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetTicketListQuery());
            var output = results.FirstOrDefault(x=>x.Id == request.id);

            if (output != null)
            {
                return output;
            }

            throw new NullReferenceException();
        }
    }
}
