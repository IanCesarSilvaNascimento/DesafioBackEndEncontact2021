namespace Notebook.Domain.Entities;

public class CompanyBook : Entity
{
    public CompanyBook(List<Company> companies)
    {
        Companies = companies;
    }

    public List<Company> Companies { get; private set; }


}