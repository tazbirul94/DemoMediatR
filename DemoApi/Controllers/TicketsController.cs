using DemoLibrary.Models;
using DemoLibrary.Queries;
using DemoLibrary.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TicketsController(IMediator mediator)
        {
           _mediator = mediator;
        }
        // GET: api/<PersonController>
        [HttpGet]
        public async Task<List<TicketModel>> Get() => await _mediator.Send(new GetTicketListQuery());
        

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public async Task<TicketModel> Get(int id) => await _mediator.Send(new GetTicketByIdQuery(id));


        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public async Task<MessageDto> Delete(int id) => await _mediator.Send(new RemoveTicketByIdQuery(id));
        
    }
}
