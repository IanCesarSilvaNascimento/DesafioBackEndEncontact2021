using Microsoft.AspNetCore.Mvc;
using Notebook.Domain.Commands;
using Notebook.Domain.Entities;
using Notebook.Domain.Handlers;
using Notebook.Domain.Repositories;

namespace Notebook.Domain.Api.Controllers;


[ApiController]
[Route("v1/contactbooks")]

public class ContactaBookController : ControllerBase
{

    
    [HttpGet("")]
    public IEnumerable<ContactBook> GetAll(
         [FromServices] IContactBookRepository repository
    )
    {
        return repository.GetAll();
    }

    
    [HttpGet("{id:int}")]
    public ContactBook GetById(
               [FromServices] IContactBookRepository repository,
               [FromRoute] int id
       )
    {
        return repository.GetById(id);
    }

    
    [HttpPost("")]
    public GenericCommandResult Create(
        [FromBody] CreateContactBookCommand command,
        [FromServices] ContactBookHandler handler
    )
    {

        return (GenericCommandResult)handler.Handle(command);
    }

    [HttpPut("")]
    public GenericCommandResult Update(
         [FromBody] UpdateContactBookCommand command,
         [FromServices] ContactBookHandler handler
      )
    {
        return (GenericCommandResult)handler.Handle(command);
    }


    [HttpDelete("")]
    public GenericCommandResult Delete(
      [FromBody] DeleteContactBookCommand command,
      [FromServices] ContactBookHandler handler

    )
    {
        return (GenericCommandResult)handler.Handle(command);

    }

}
