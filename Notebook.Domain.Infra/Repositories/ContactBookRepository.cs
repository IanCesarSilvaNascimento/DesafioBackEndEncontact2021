using Microsoft.EntityFrameworkCore;
using Notebook.Domain.Entities;
using Notebook.Domain.Infra.Contexts;
using Notebook.Domain.Repositories;

namespace Notebook.Domain.Infra.Repositories;

public class ContactBookRepository : IContactBookRepository
{
    private readonly DataContext _context;

    public ContactBookRepository(DataContext context)
    {
        _context = context;
    }
    public void Create(ContactBook contactBook)
    {
        _context.ContactBooks.Add(contactBook);
        _context.SaveChanges();
    }

    public void Delete(ContactBook contactBook)
    {
        _context.ContactBooks.Remove(contactBook);
        _context.SaveChanges();
    }

    public IEnumerable<ContactBook> GetAll()
    {
        return _context.ContactBooks.AsNoTracking().OrderBy(x => x.Id);
    }

    public ContactBook GetById(int id)
    {
        return _context.ContactBooks.AsNoTracking().FirstOrDefault(x => x.Id == id);
    }

    public void Update(ContactBook contactBook)
    {
        _context.ContactBooks.Update(contactBook);
        _context.SaveChanges();
    }
}