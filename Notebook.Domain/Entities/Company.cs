
namespace Notebook.Domain.Entities;

public class Company : Entity
{
    public Company(string name)
    {
        Name = name;
        CreatedDate = DateTime.UtcNow.ToLocalTime();
      

    }

    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }
 
    public void UpdateName(string name)
    {
        Name = name;
    }
}