using Flunt.Notifications;
using Notebook.Domain.Commands;
using Notebook.Domain.Commands.Contracts;
using Notebook.Domain.Entities;
using Notebook.Domain.Handlers.Contracts;
using Notebook.Domain.Repositories;

namespace Notebook.Domain.Handlers;

public class ContactBookHandler :
                Notifiable,
                IHandler<CreateContactBookCommand>,
                IHandler<UpdateContactBookCommand>,
                IHandler<DeleteContactBookCommand>
{
    private readonly IContactBookRepository _repository;
    public ContactBookHandler(IContactBookRepository repository)
    {
        _repository = repository;
    }
    public ICommandResult Handle(CreateContactBookCommand command)
    {
        //Fail Fast Validations
        command.Validate();
        if (command.Invalid)
            return new GenericCommandResult(false, "Parece que algo deu errado.", command.Notifications);

        
        //Gera o contact
        var contactBook = new ContactBook(command.Name);
        contactBook.Company.Add(command.Company);

        //Salva no banco
        _repository.Create(contactBook);

        return new GenericCommandResult(true, "Tarefa realizada com sucesso.", contactBook);

    }

    public ICommandResult Handle(UpdateContactBookCommand command)
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

    public ICommandResult Handle(DeleteContactBookCommand command)
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

