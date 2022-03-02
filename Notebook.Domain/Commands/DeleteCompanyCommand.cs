using Flunt.Notifications;
using Flunt.Validations;
using Notebook.Domain.Commands.Contracts;

namespace Notebook.Domain.Commands;

public class DeleteCompanyCommand : Notifiable, ICommand
{
    public DeleteCompanyCommand(Guid id, string name, string user)
    {
        Id = id;
        Name = name;
        User = user;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string User { get; set; }


    public void Validate()
    {
        AddNotifications(new Contract()
          .Requires()
          .HasMinLen(Name, 3, "Name", "Nome da empresa é obrigatório com no mínimo 3 caracteres.")
          .HasMinLen(User, 3, "User", "Usuário é obrigatório com no mínimo 3 caracteres.")


          );


    }
}

