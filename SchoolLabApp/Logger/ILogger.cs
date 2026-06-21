using System;
using System.Collections.Generic;
using System.Text;
using log4net;

namespace SchoolLabApp.Logger
{
    public interface ILogger
    {
        void Info(string message);

        void Warn(string message);

        void Error(string message);

        void Error(Exception ex);

        void Fatal(string message);

        void Fatal(Exception ex);
    }
}
