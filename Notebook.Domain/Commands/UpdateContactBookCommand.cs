using Flunt.Notifications;
using Flunt.Validations;
using Notebook.Domain.Commands.Contracts;

namespace Notebook.Domain.Commands;

public class UpdateContactBookCommand : Notifiable, ICommand
{
    public UpdateContactBookCommand(int id, string name)
    {
        Id = id;
        Name = name;

    }

    public int Id { get; set; }
    public string Name { get; set; }


    public void Validate()
    {
        AddNotifications(new Contract()
         .Requires()
         .HasMinLen(Name, 3, "Name", "Nome da empresa é obrigatório com no mínimo 3 caracteres.")



         );


    }
}

