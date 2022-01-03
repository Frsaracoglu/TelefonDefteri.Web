using System.Linq;
using TelefonDefteriData.Models;
using TelefonDefteriUtil;

namespace TelefonDefteriData
{
    public class UserData
    {
        public TelefonDefteriEntity.User LoginUser(string eMail, string password)
        {
            TelefonDefteriEntity.User user = null;

            using (dbAdresDefteriContext context = new dbAdresDefteriContext())
            {
                user = context.Users.Where(l => l.Email == eMail).Select(l => new TelefonDefteriEntity.User
                {
                    Email = l.Email,
                    Password = l.Password,
                    UserId = l.UserId,
                    Name = l.Name,
                    LastName = l.LastName

                }).FirstOrDefault();

                if (user != null)
                {
                    if (user.Password != CryptoHelper.MD5Sifrele(password))
                    {
                        user = null;
                    }
                }
            }
            return user;

        }

        public bool LogoutUser()
        {

            return true;
        }

        public bool InsertUser(TelefonDefteriEntity.User user)
        {

            using (dbAdresDefteriContext context = new dbAdresDefteriContext())
            {
                Models.User user1 = new Models.User();
                user1.Name = user.Name;
                user1.LastName = user.LastName;
                user1.Email = user.Email;
                user1.Password = CryptoHelper.MD5Sifrele(user.Password);

                context.Users.Add(user1);
                int UserId = context.SaveChanges();
                if (UserId > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public bool UpdateUser(TelefonDefteriEntity.User user)
        {
            using (dbAdresDefteriContext context = new())
            {

                var people = context.Users.Where(l => l.UserId == user.UserId).FirstOrDefault();

                    people.Name = user.Name;
                    people.LastName = user.LastName;
                    people.Email = user.Email;
                    people.Password = CryptoHelper.MD5Sifrele(user.Password);


                context.Users.Update(people);
                context.SaveChanges();

                return true;
            }
        }
    }
}
