using IT_Service.Domain.InterfaceRepositories;
using IT_Service.Infra.Data.Context;

namespace IT_Service.Infra.Data.ImplemenRepositories
{
    public class UserRepository : IUserRepository
    {
        #region Constructor

        private readonly ITServiceContext _context;

        public UserRepository(ITServiceContext context)
        {
            _context = context;
        }

        #endregion

        #region User

        #endregion
    }
}
