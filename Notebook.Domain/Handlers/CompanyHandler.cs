using Flunt.Notifications;
using Notebook.Domain.Commands;
using Notebook.Domain.Commands.Contracts;
using Notebook.Domain.Entities;
using Notebook.Domain.Handlers.Contracts;
using Notebook.Domain.Repositories;

namespace Notebook.Domain.Handlers;

public class CompanyHandler : 
                Notifiable,
                IHandler<CreateCompanyCommand>,
                IHandler<UpdateCompanyCommand>,             
                IHandler<DeleteCompanyCommand>
{
    private readonly ICompanyRepository _repository;

    public CompanyHandler(ICompanyRepository repository)
    {
        _repository = repository;
    }
    public ICommandResult Handle(CreateCompanyCommand command)
    {
        //Fail Fast Validations
        command.Validate();
        if (command.Invalid)
            return new GenericCommandResult(false, "Parece que algo deu errado.", command.Notifications);

        //Gera o company
        var company = new Company(command.Name);
     
        //Acessa o banco em memória passando o company gerado
        _repository.Create(company);

        return new GenericCommandResult(true, "Tarefa realizada com sucesso.", company);

    }

    public ICommandResult Handle(UpdateCompanyCommand command)
    {
        //Fail Fast Validations
        command.Validate();
        if (command.Invalid)
            return new GenericCommandResult(false, "Parece que algo deu errado.", command.Notifications);
        
        //Recupera o company pelo ID 
        var company = _repository.GetById(command.Id);

        //Altera o nome
        company.UpdateName(command.Name);

        //Salva
        _repository.Update(company);

        //Retorna resultado
        return new GenericCommandResult(true, "Tarefa realizada com sucesso.", company);
    }

    public ICommandResult Handle(DeleteCompanyCommand command)
    {
         //Fail Fast Validations
        command.Validate();
        if (command.Invalid)
            return new GenericCommandResult(false, "Parece que algo deu errado.", command.Notifications);
        
        //Recupera o company pelo ID 
        var company = _repository.GetById(command.Id);
      
        //Salva
        _repository.Delete(company);

        //Retorna resultado
        return new GenericCommandResult(true, "Tarefa realizada com sucesso.", company);
    }

  
}

