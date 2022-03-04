using Microsoft.EntityFrameworkCore;
using Notebook.Domain.Entities;
using Notebook.Domain.Infra.Contexts;
using Notebook.Domain.Queries;
using Notebook.Domain.Repositories;

namespace Notebook.Domain.Infra.Repositories;

public class CompanyRepository : ICompanyRepository
{
    private readonly DataContext _context;

    public CompanyRepository(DataContext context)
    {
        _context = context;
    }
    public IEnumerable<Company> GetAll()
    {
        return _context.Companies.AsNoTracking().OrderBy(x => x.Id);
    }

    public Company GetById(int id)
    {
        return _context.Companies.AsNoTracking().FirstOrDefault(x => x.Id == id);

    }

    public void Create(Company company)
    {
        _context.Companies.Add(company);
        _context.SaveChanges();
    }

    public void Delete(Company company)
    {
        _context.Companies.Remove(company);
        _context.SaveChanges();
    }
    public void Update(Company company)
    {
        _context.Companies.Update(company);
        _context.SaveChanges();
    }


}