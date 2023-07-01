using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace ConversorMonetario
{
    public class Log
    {
        public static void Add(LogType type, LogSave save, string message)
        {
            try
            {
                if (type == LogType.success && !Convert.ToBoolean(Config.logSuccessEnabled))
                    return;

                else if (type == LogType.info && !Convert.ToBoolean(Config.logInfoEnabled))
                    return;

                else if (type == LogType.error && !Convert.ToBoolean(Config.logErrorEnabled))
                    return;

                else
                {
                    if (save == LogSave.database)
                    {
                        SaveLogToDatabase(type, message);
                    }

                    else if (save == LogSave.file)
                    {
                        SaveLogToFile(type, message);
                    }
                }
            }
            catch
            { }
        }

        private static void SaveLogToDatabase(LogType type, string message)
        {
            DatabaseAccess dba = new DatabaseAccess();

            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"INSERT INTO logs (creation_date, type, message) " +
                                      @"VALUES (@creationDate, @type, @message);";


                    cmd.Parameters.AddWithValue("@creationDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@type", type.ToString());
                    cmd.Parameters.AddWithValue("@message", message);

                    using (cmd.Connection = dba.OpenConnection())
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            { }
        }

        private static void SaveLogToFile(LogType type, string message)
        {
            if (!Directory.Exists(Config.logFolder))
                Directory.CreateDirectory(Config.logFolder);

            if (!File.Exists(Config.logPath))
                File.Create(Config.logPath).Dispose();

            File.AppendAllText(Config.logPath, DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " - " + type.ToString() + ": " + message + Environment.NewLine);
        }
    }
}
