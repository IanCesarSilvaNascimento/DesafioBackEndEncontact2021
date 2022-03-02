using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Notebook.Domain.Commands;
using Notebook.Domain.Entities;
using Notebook.Domain.Handlers;
using Notebook.Domain.Infra.Contexts;
using Notebook.Domain.Repositories;

namespace Notebook.Domain.Api.Controllers;


[ApiController]
[Route("v1/companies")]

public class CompanyController : ControllerBase
{
    
    [Route("")]
    [HttpGet]
    public IEnumerable<Company> GetAll(
         [FromServices] ICompanyRepository repository
    )
    {
        return repository.GetAll();
    }

    [Route("{id:Guid}")]
    [HttpGet]
    public Company GetById(
            [FromServices] ICompanyRepository repository,
            [FromRoute] Guid id
    )
    {
        return repository.GetById(id);
    }



    [Route("")]
    [HttpPost]
    public GenericCommandResult Create(
        [FromBody] CreateCompanyCommand command,
        [FromServices] CompanyHandler handler
    )
    {

        return (GenericCommandResult)handler.Handle(command);
    }

    [Route("")]
    [HttpPut]
    public GenericCommandResult Update(
       [FromBody] UpdateCompanyCommand command,
       [FromServices] CompanyHandler handler
    )
    {
        return (GenericCommandResult)handler.Handle(command);
    }

    [Route("")]
    [HttpDelete]
    public GenericCommandResult Delete(
      [FromBody] DeleteCompanyCommand command,
      [FromServices] CompanyHandler handler

    )
    {
        return (GenericCommandResult)handler.Handle(command);

    }


}
