
namespace Notebook.Domain.Entities;

public class Company : Entity
{
 
    public Company(string name)
    {
        Name = name;       
        CreatedDate = DateTime.UtcNow.ToLocalTime();
    }

    public string Name { get; private set; }
    public DateTime CreatedDate { get; private set; } 

    public void UpdateName(string name)
    {
        Name = name;
    }
}