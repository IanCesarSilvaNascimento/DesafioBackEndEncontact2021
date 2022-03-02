namespace Notebook.Domain.Entities;

public class Company : Entity
{
    public Company(string name, DateTime createdDate, string user)
    {
        Name = name;
        CreatedDate = createdDate;
        User = user;
    }

    public string Name { get; private set; }
    public DateTime CreatedDate { get; private set; }
    public string User { get; private set; }

    public void UpdateName(string name)
    {
        Name = name;
    }
}