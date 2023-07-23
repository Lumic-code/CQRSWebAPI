using CQRS.WebApi.Model;
using Microsoft.EntityFrameworkCore;

namespace CQRS.WebApi.Context
{
    public interface IApplicationContext
    {
        DbSet<Product> Products { get; set; }
        Task<int> SaveChangesAsync();
    }
}