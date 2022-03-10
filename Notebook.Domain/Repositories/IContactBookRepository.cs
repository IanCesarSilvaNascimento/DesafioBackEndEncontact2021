using Notebook.Domain.Entities;

namespace Notebook.Domain.Repositories;

public interface IContactBookRepository
{
    void Create(ContactBook contact);
    
    void Update(ContactBook contact);

    ContactBook GetById(int id);

    void Delete(ContactBook contact);

    IEnumerable<ContactBook> GetAll();

}