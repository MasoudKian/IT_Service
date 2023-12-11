using IT_Service.Domain.Models.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace IT_Service.Infra.Data.Context
{
    public class ITServiceContext : DbContext
    {
        public ITServiceContext(DbContextOptions<ITServiceContext> options) : base(options)
        {
            
        }

        #region User
        public DbSet<User> Users { get; set; }

        #endregion

    }
}
