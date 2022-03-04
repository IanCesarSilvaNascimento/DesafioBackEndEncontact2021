using Notebook.Domain.Entities;

namespace Notebook.Domain.Repositories;

public interface ICompanyRepository
{
    void Create(Company company);
    
    void Update(Company company);

    Company GetById(int id);

    void Delete(Company company);

    IEnumerable<Company> GetAll();

}