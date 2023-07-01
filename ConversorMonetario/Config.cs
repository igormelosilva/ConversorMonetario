using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMonetario
{
    public class Config
    {
        //Credenciais de acesso ao banco
        public static string dbHost = ConfigurationManager.AppSettings["dbHost"];
        public static string dbPort = ConfigurationManager.AppSettings["dbPort"];
        public static string dbName = ConfigurationManager.AppSettings["dbName"];
        public static string dbUser = ConfigurationManager.AppSettings["dbUser"];
        public static string dbPass = ConfigurationManager.AppSettings["dbPass"];

        //Diretório raiz da aplicação
        public static string appRootFolder = AppDomain.CurrentDomain.BaseDirectory;

        //Habilita os logs conforme o tipo
        public static bool logSuccessEnabled = Convert.ToBoolean(ConfigurationManager.AppSettings["logSuccessEnabled"]);
        public static bool logErrorEnabled = Convert.ToBoolean(ConfigurationManager.AppSettings["logErrorEnabled"]);
        public static bool logInfoEnabled = Convert.ToBoolean(ConfigurationManager.AppSettings["logInfoEnabled"]);

        //Nome pasta e caminho do log
        public static string logName = ConfigurationManager.AppSettings["logFileName"];
        public static string logFolder = ConfigurationManager.AppSettings["logFilePath"];
        public static string logPath = Path.Combine(appRootFolder, logFolder, logName);
    }
    public enum LogType
    {
        success = 1,
        info = 2,
        error = 3
    }
    public enum LogSave
    {
        database = 1,
        file = 2
    }
}
