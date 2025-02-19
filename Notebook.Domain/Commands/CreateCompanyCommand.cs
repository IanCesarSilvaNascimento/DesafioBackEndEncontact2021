using Flunt.Notifications;
using Flunt.Validations;
using Notebook.Domain.Commands.Contracts;


namespace Notebook.Domain.Commands;

public class CreateCompanyCommand : Notifiable, ICommand
{

    public CreateCompanyCommand(string name)
    {
        Name = name;
        
    }


    public string Name { get; set; }




    public void Validate()
    {
        AddNotifications(new Contract()
            .Requires()
            .HasMinLen(Name, 3, "Name", "Nome da empresa é obrigatório com no mínimo 3 caracteres.")

        );


    }
}

