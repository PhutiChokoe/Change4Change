using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Change4Change.Database
{
    public class Users : IUser
    {
        private static Idbhandler _iDbhandler = new Dbhandler();
        public User GetUserDetailsbyId(Guid userId,string PageName)
        {
            return _iDbhandler.GetUserById(userId, PageName);
        }

        public bool CreateUser(User NewUser)
        {
            throw new NotImplementedException();
        }
    }
}