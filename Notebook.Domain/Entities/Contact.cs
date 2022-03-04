namespace Notebook.Domain.Entities;

public class Contact : Entity
{

    public Contact(string name)
    {
        Name = name;

    }

    public string Name { get; private set; }


    public void UpdateName(string name)
    {
        Name = name;
    }

}