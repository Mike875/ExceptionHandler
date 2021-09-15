# ExceptionHandler


Requires
NLog
Nlog.Config
NLog.Web.AspNetCore
System.Data.SqlClient



Used like this

try {
  throw new Exception("Example exception");
} catch(Exception ex){
  ex.Handle(new EmailExceptionService(), new NLogExceptionService(), new EventLogExceptionService());
}
