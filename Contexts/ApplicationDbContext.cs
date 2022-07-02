using Microsoft.EntityFrameworkCore;
using NuevaDB_Qatar22.Models;

namespace NuevaDB_Qatar22.Controllers.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
