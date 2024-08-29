/* http://www.zkea.net/ Copyright 2016 ZKEASOFT http://www.zkea.net/licenses */
using Easy.Constant;
using Easy.Modules.User.Models;
using Easy.RepositoryPattern;

namespace Easy.Modules.User.Service
{
    public interface IUserService : IService<UserEntity>
    {
        UserEntity Login(string userID, string passWord, UserType userType, string ip);
        UserEntity SetResetToken(string email, UserType userType);
        bool ResetPassWord(string token, string newPassword);
    }
}
