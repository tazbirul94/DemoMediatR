﻿using DemoLibrary.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Queries
{
    public record RemoveTicketByIdQuery(int id) : IRequest<MessageDto>;
}
