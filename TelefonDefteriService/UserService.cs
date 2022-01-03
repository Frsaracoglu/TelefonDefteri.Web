
using TelefonDefteriData;
using TelefonDefteriEntity;

namespace TelefonDefteriService
{
    public class UserService
    {
        public User Login(string eMail, string password)
        {

            UserData userData = new();
            var user = userData.LoginUser(eMail, password);

            return user;
        }

        public bool InsertUser(User user)
        {
            var retval = false;
            UserData userData = new();
            retval = userData.InsertUser(user);

            return retval;
        }

        public bool UpdateUser(User user)
        {
            UserData userData = new();
            return userData.UpdateUser(user);
        }       
    }
}
