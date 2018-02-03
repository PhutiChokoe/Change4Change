using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Change4Change.Database
{
    public class Dbhandler : Idbhandler
    {
        private readonly Change4ChangeEntities _dbcontext = new Change4ChangeEntities();
        private static  IErrorLog _errorLog = new LogErrors();
        public bool CreateInvestment(Investment invest)
        {
            try
            {
                _dbcontext.Investments.Add(invest);
                _dbcontext.SaveChanges();
                return false;
            }
            catch (Exception ex)
            {
                _errorLog.ErrorMsgSettings(ex, "CreateInvestment","DbHandler","Create Dream", MySession.CurrentUser.Id);
                throw ex;
            }
        }

        public void LogError(ErrorLog error)
        {
            _dbcontext.ErrorLogs.Add(error);
            _dbcontext.SaveChanges();
        }

        public User GetUserById(Guid userGuid,string pageName)
        {
            try
            {
                return _dbcontext.Users.SingleOrDefault(x => x.Id == userGuid);
            }
            catch (Exception ex)
            {
                _errorLog.ErrorMsgSettings(ex, "GetUserById", "DbHandler", pageName, MySession.CurrentUser.Id);
                throw ex;
            }
        }
    }
}