namespace Notebook.Domain.Entities;

public class ContactBook : Entity
{

    public ContactBook(string name)
    {
        Name = name;
        Company = new List<Company>();

    }

    public string Name { get; set; }
    public IList<Company> Company { get; set; }

    public void UpdateName(string name)
    {
        Name = name;
    }

}