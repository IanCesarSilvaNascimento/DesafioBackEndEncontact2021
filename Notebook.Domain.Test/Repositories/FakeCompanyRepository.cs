using System;
using System.Collections.Generic;
using Notebook.Domain.Entities;
using Notebook.Domain.Repositories;

namespace Notebook.Domain.Test.Repositories;

public class FakeCompanyRepository : ICompanyRepository
{
    public void Create(Company company)
    {
       
    }

    public void Delete(Company company)
    {
       
    }

    public IEnumerable<Company> GetAll()
    {
        throw new NotImplementedException();
    }

    public Company GetById(int id)
    {
        return new Company("Empresa Teste LTDA");
    }

    public void Update(Company company)
    {
       
    }
}