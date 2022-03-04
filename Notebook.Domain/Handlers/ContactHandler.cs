using Flunt.Notifications;
using Notebook.Domain.Commands;
using Notebook.Domain.Commands.Contracts;
using Notebook.Domain.Entities;
using Notebook.Domain.Handlers.Contracts;
using Notebook.Domain.Repositories;

namespace Notebook.Domain.Handlers;

public class ContactHandler :
                Notifiable,
                IHandler<CreateContactCommand>,
                IHandler<UpdateContactCommand>,
                IHandler<DeleteContactCommand>
{
    private readonly IContactRepository _repository;

    public ContactHandler(IContactRepository repository)
    {
        _repository = repository;
    }
    public ICommandResult Handle(CreateContactCommand command)
    {
        //Fail Fast Validations
        command.Validate();
        if (command.Invalid)
            return new GenericCommandResult(false, "Parece que algo deu errado.", command.Notifications);

        //Gera o company
        var contact = new Contact(command.Name);

        //Salva no banco
        _repository.Create(contact);

        return new GenericCommandResult(true, "Tarefa realizada com sucesso.", contact);

    }

    public ICommandResult Handle(UpdateContactCommand command)
    {
        //Fail Fast Validations
        command.Validate();
        if (command.Invalid)
            return new GenericCommandResult(false, "Parece que algo deu errado.", command.Notifications);

        //Recupera o company pelo ID 
        var contact = _repository.GetById(command.Id);

        //Altera o nome
        contact.UpdateName(command.Name);

        //Salva
        _repository.Update(contact);

        //Retorna resultado
        return new GenericCommandResult(true, "Tarefa realizada com sucesso.", contact);
    }

    public ICommandResult Handle(DeleteContactCommand command)
    {
        //Fail Fast Validations
        command.Validate();
        if (command.Invalid)
            return new GenericCommandResult(false, "Parece que algo deu errado.", command.Notifications);

        //Recupera o company pelo ID 
        var contact = _repository.GetById(command.Id);

        //Salva
        _repository.Delete(contact);

        //Retorna resultado
        return new GenericCommandResult(true, "Tarefa realizada com sucesso.", contact);
    }




}

