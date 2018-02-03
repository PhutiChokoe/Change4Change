using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Change4Change.Database
{
    public class LogErrors : IErrorLog
    {
        private static Idbhandler _dbhandler = new Dbhandler();
        public static void logError(string moduleName, string pageName, string procedureName, Exception exception, Guid UserID, string UserName)
        {

                ErrorLog error = new ErrorLog
                {
                    Exception = exception.ToString(),
                    Id = Guid.NewGuid(),
                    UserName = MySession.CurrentUser.UserName,
                    ModuleName = moduleName,
                    pageName = pageName,
                    UserId = UserID,
                    procedureName = procedureName
                };
                _dbhandler.LogError(error);
         
        }



        public void logErrorMessage(string moduleName, string pageName, string procedureName, string strexception, Guid UserID,
            string UserName)
        {
            throw new NotImplementedException();
        }
        public void ErrorMsgSettings(Exception Ex, string procedureName, string moduleName, string pageName, Guid UserID)
        {
            string username;
      
            username = MySession.CurrentUser.UserName;
            
            var aprocedureName = procedureName.Substring(0, Math.Min(procedureName.Length, 100));
            logError(moduleName, pageName, aprocedureName, Ex, UserID, username);
        }

    }
}