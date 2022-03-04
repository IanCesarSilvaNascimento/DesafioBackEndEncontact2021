using Notebook.Domain.Entities;

namespace Notebook.Domain.Repositories;

public interface IContactRepository
{
    void Create(Contact contact);
    
    void Update(Contact contact);

    Contact GetById(int id);

    void Delete(Contact contact);

    IEnumerable<Contact> GetAll();

}