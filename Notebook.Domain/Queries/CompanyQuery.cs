using System.Linq.Expressions;
using Notebook.Domain.Entities;

namespace Notebook.Domain.Queries;

public static class CompanyQuery
{
    public static Expression<Func<Company, bool>> GetAll(string name)
    {
        return x => x.Name == name ;
    }

}