using Flunt.Notifications;
using Flunt.Validations;
using Notebook.Domain.Commands.Contracts;
using Notebook.Domain.Entities;

namespace Notebook.Domain.Commands;

public class CreateContactCommand : Notifiable, ICommand
{
    public CreateContactCommand(string name) 
    {   
        Name = name;
   
    }

    public string Name { get; private set; }


 


    public void Validate()
    {
        AddNotifications(new Contract()
        .Requires()
        .HasMinLen(Name, 3, "Name", "Nome da empresa é obrigatório com no mínimo 3 caracteres.")
    

        );


    }
}

