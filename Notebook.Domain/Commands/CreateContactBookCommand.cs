using Flunt.Notifications;
using Flunt.Validations;
using Notebook.Domain.Commands.Contracts;
using Notebook.Domain.Entities;

namespace Notebook.Domain.Commands;

public class CreateContactBookCommand : Notifiable, ICommand
{

    public CreateContactBookCommand(string name, Company company)
    {
        Name = name;
        Company = company;
    }

    public string Name { get; set; }

    public Company Company { get; set; }


   


    public void Validate()
    {
        AddNotifications(new Contract()
            .Requires()
            .HasMinLen(Name, 3, "Name", "Nome da empresa é obrigatório com no mínimo 3 caracteres.")
        );


    }
}

