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
        return _context.Companies
               .AsNoTracking()
               .OrderBy(x => x.CreatedDate);
    }

    public Company GetById(Guid id)
    {
        return _context
                .Companies
                .First(x => x.Id == id);

    }

    public void Create(Company company)
    {
        _context.Companies.Add(company);
        _context.SaveChanges();
    }

    public void Delete(Company company)
    {
        _context.Remove(company).State = EntityState.Deleted;
        _context.SaveChanges();
    }
    public void Update(Company company)
    {
        _context.Entry(company).State = EntityState.Modified;
        _context.SaveChanges();
    }


}