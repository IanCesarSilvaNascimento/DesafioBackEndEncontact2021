using Microsoft.EntityFrameworkCore;
using Notebook.Domain.Entities;
using Notebook.Domain.Infra.Contexts;
using Notebook.Domain.Repositories;

namespace Notebook.Domain.Infra.Repositories;

public class ContactRepository : IContactRepository
{
    private readonly DataContext _context;

    public ContactRepository(DataContext context)
    {
        _context = context;
    }
    public void Create(Contact contact)
    {
        _context.Contacts.Add(contact);
        _context.SaveChanges();
    }

    public void Delete(Contact contact)
    {
        _context.Contacts.Remove(contact);
        _context.SaveChanges();
    }

    public IEnumerable<Contact> GetAll()
    {
        return _context.Contacts.AsNoTracking().OrderBy(x => x.Id);
    }

    public Contact GetById(int id)
    {
        return _context.Contacts.AsNoTracking().FirstOrDefault(x => x.Id == id);
    }

    public void Update(Contact contact)
    {
        _context.Contacts.Update(contact);
        _context.SaveChanges();
    }
}