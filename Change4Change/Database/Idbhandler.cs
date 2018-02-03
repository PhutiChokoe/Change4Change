using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change4Change.Database
{
    public interface Idbhandler
    {
        bool CreateInvestment(Investment invest);
        User GetUserById(Guid userGuid, string pageName);
        void LogError(ErrorLog error);

    }
}
