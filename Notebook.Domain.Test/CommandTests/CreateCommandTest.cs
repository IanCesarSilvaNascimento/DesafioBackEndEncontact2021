using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Notebook.Domain.Commands;
using Notebook.Domain.Entities;

namespace Notebook.Domain.Test.CommandTests;

[TestClass]
public class CreateCommandTest
{
    private readonly CreateCompanyCommand _invalidComand = new CreateCompanyCommand("",);
    private readonly CreateCompanyCommand _validComand = new CreateCompanyCommand("Empresa teste LTDA",);

    public CreateCommandTest()
    {
        _invalidComand.Validate();
        _validComand.Validate();
    }

    [TestMethod]
    public void GivenInvalidCommand()
    {
        Assert.AreEqual(_invalidComand.Valid, false);
    }

    [TestMethod]
    public void GivenValidCommand()
    {
        Assert.AreEqual(_validComand.Valid, true);
    }
}