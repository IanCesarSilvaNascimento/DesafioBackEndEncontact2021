
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Notebook.Domain.Entities;

namespace Notebook.Domain.Test.EntityTests;

[TestClass]
public class CompanyEntityTest
{
    private readonly Company _valid = new Company("Empresa Test LTDA",System.DateTime.Now,"Usuário Test");

    [TestMethod]
    public void GivenNewCompanyReturnNotSuccess()
    {
       Assert.AreEqual(_valid.Name,"Empresa Test LTDA");
    }

   
}