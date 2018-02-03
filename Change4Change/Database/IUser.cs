using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change4Change.Database
{
    public interface IUser
    {
        User GetUserDetailsbyId(Guid userId,string pageName);
        bool CreateUser(User NewUser);

    }
}
