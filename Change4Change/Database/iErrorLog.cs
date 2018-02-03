using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change4Change.Database
{
    public interface IErrorLog
    {
        void ErrorMsgSettings(Exception Ex, string procedureName, string moduleName, string pageName, Guid UserID);
    }
}
