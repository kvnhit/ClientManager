using ClientManager.Application.Commands.CreateClient;
using ClientManager.Application.Commands.DeleteClient;
using ClientManager.Application.Commands.UpdateClient;
using ClientManager.Application.Queries.GetAllClients;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ClientManager.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ClientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // api/client?query=NetCore
        [HttpGet]
        public async Task<IActionResult> Get(string query)
        {
            var getAllClientsQuery = new GetAllClientsQuery(query);

            var clients = await _mediator.Send(getAllClientsQuery);

            return Ok(clients);
        }

        // api/client/33
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetClientByIdQuery(id);

            var client = await _mediator.Send(query);

            if(client == null)
                return NotFound();

            return Ok(client); 
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateClientCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        // api/client/33
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateClientCommand command)
        {
            await _mediator.Send(command);

            return NoContent();
        }

        // api/client/3
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) 
        {
            var command = new DeleteClientCommand(id);

            await _mediator.Send(command);

            return NoContent();
        }
    }
}
