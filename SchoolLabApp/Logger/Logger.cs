using log4net;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SchoolLabApp.Logger
{
    public class Logger:ILogger
    {
        private readonly ILog _log;

        public Logger()
        {
            _log = LogManager.GetLogger(
                MethodBase.GetCurrentMethod()!.DeclaringType);
        }

        public void Info(string message)
        {
            _log.Info(message);
        }

        public void Warn(string message)
        {
            _log.Warn(message);
        }

        public void Error(string message)
        {
            _log.Error(message);
        }

        public void Error(Exception ex)
        {
            _log.Error(ex.Message, ex);
        }

        public void Fatal(string message)
        {
            _log.Fatal(message);
        }

        public void Fatal(Exception ex)
        {
            _log.Fatal(ex.Message, ex);
        }
    }
}
