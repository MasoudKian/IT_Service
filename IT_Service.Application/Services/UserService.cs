using IT_Service.Application.Interfaces;
using IT_Service.Domain.InterfaceRepositories;

namespace IT_Service.Application.Services
{
    public class UserService : IUserService
    {
        #region Constructor

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        #endregion
    }
}
