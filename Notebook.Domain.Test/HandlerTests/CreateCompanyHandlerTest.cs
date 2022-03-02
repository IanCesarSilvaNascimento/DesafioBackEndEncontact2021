using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Notebook.Domain.Commands;
using Notebook.Domain.Handlers;
using Notebook.Domain.Test.Repositories;

namespace Notebook.Domain.Test.CommandTests;

[TestClass]
public class CreateCompanyHandlerTest
{
    private readonly CreateCompanyCommand _invalidComand = new CreateCompanyCommand("", "");
    private readonly CreateCompanyCommand _validComand = new CreateCompanyCommand("Empresa teste LTDA", "Usuário Teste");
    private readonly CompanyHandler _handler = new CompanyHandler(new FakeCompanyRepository());

    public CreateCompanyHandlerTest()
    {
        
    }

    [TestMethod]
    public void GivenInvalidCommandReturnErro()
    {
        var result = (GenericCommandResult)_handler.Handle(_invalidComand);
        Assert.AreEqual(result.Success, false);
    }


    [TestMethod]
    public void GivenValidCommandCreateTask()
    {
        var result = (GenericCommandResult)_handler.Handle(_validComand);
        Assert.AreEqual(result.Success, true);
    }


}