using Flunt.Notifications;
using Flunt.Validations;
using Notebook.Domain.Commands.Contracts;

namespace Notebook.Domain.Commands;

public class DeleteContactBookCommand : Notifiable, ICommand
{
    public DeleteContactBookCommand(int id)
    {
        Id = id;
  
    }

    public int Id { get; set; }
 


    public void Validate()
    {
        AddNotifications(new Contract()
          .Requires()
        
          );


    }
}

