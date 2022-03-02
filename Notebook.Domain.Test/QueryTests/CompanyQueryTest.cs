using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Notebook.Domain.Entities;
using Notebook.Domain.Queries;

namespace Notebook.Domain.Test.QueryTests;

[TestClass]
public class CompanyQueryTest
{
    private List<Company> _items;

    public CompanyQueryTest()
    {
        _items = new List<Company>();
        _items.Add(new Company("Empresa Teste Ltda", DateTime.Now, "Usuário1 teste"));
        _items.Add(new Company("Empresa Teste Ltda", DateTime.Now, "Usuário teste"));
        _items.Add(new Company("Empresa Teste Ltda", DateTime.Now, "Usuário1 teste"));
        _items.Add(new Company("Empresa Teste Ltda", DateTime.Now, "Usuário teste"));
        _items.Add(new Company("Empresa Teste Ltda", DateTime.Now, "Usuário teste"));


    }
    [TestMethod]
    public void GivenQueryReturnDataBasedOnName()
    {
        var result = _items.AsQueryable().Where(CompanyQuery.GetAll("Usuário1 teste"));
        Assert.AreEqual(2,result.Count());
     
    }

}

