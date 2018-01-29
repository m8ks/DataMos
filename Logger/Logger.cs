using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class Logger
    {
        String dirLog;
        String fileLogName;
        String fileLogExtension = ".log";
        public Logger()
        {
            fileLogName = String.Format("{0}{1}", DateTime.Today, fileLogExtension);
        }
        public static void Warn(String wagingText)
        {

        }

        public static void Error(String ErrorTxt)
        {
            
        }

        public static void Info(String InfoTxt)
        {

        }
    }
}
