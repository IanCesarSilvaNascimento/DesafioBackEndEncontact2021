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

        _items.Add(new Company("Empresa1 Teste Ltda"));
        
        _items.Add(new Company("Empresa1 Teste Ltda"));
        
        _items.Add(new Company("Empresa Teste Ltda"));

        _items.Add(new Company("Empresa2 Teste Ltda"));

    }
    [TestMethod]
    public void GivenQueryReturnDataBasedOnName()
    {
        var result = _items.AsQueryable().Where(CompanyQuery.GetAll("Empresa1 Teste Ltda"));
        Assert.AreEqual(2, result.Count());

    }

}

