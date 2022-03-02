using Flunt.Notifications;
using Flunt.Validations;
using Notebook.Domain.Commands.Contracts;

namespace Notebook.Domain.Commands;

public class CreateCompanyCommand : Notifiable, ICommand
{
       public CreateCompanyCommand(string name,string user)
    {
        Name = name;
        CreatedDate = DateTime.Now.ToLocalTime();
        User = user;
    }

    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }
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

