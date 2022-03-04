using Microsoft.AspNetCore.Mvc;
using Notebook.Domain.Commands;
using Notebook.Domain.Entities;
using Notebook.Domain.Handlers;
using Notebook.Domain.Repositories;

namespace Notebook.Domain.Api.Controllers;


[ApiController]
[Route("v1/contacts")]

public class ContactController : ControllerBase
{

    [Route("gets")]
    [HttpGet]
    public IEnumerable<Contact> GetAll(
         [FromServices] IContactRepository repository
    )
    {
        return repository.GetAll();
    }

    [Route("gets/{id:int}")]
    [HttpGet]
    public Contact GetById(
               [FromServices] IContactRepository repository,
               [FromRoute] int id
       )
    {
        return repository.GetById(id);
    }

    [Route("posts")]
    [HttpPost]
    public GenericCommandResult Create(
        [FromBody] CreateContactCommand command,
        [FromServices] ContactHandler handler
    )
    {

        return (GenericCommandResult)handler.Handle(command);
    }

    [Route("updates")]
    [HttpPut]
    public GenericCommandResult Update(
         [FromBody] UpdateContactCommand command,
         [FromServices] ContactHandler handler
      )
    {
        return (GenericCommandResult)handler.Handle(command);
    }

    [Route("deletes")]
    [HttpDelete]
    public GenericCommandResult Delete(
      [FromBody] DeleteContactCommand command,
      [FromServices] ContactHandler handler

    )
    {
        return (GenericCommandResult)handler.Handle(command);

    }

}
