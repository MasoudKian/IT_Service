using Microsoft.EntityFrameworkCore;

namespace IT_Service.Infra.Data.Context
{
    public class ITServiceContext : DbContext
    {
        public ITServiceContext(DbContextOptions<ITServiceContext> options) : base(options)
        {
            
        }

        #region User

        #endregion
    }
}
