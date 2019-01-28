using Autofac;
using Dapper;
using System;
using System.Configuration;
using System.Data;
using System.IO;
using System.Text;

namespace PSK.Databases.LogisticsCRUD.Startup
{
    public class DatabaseInitializationStartupProcedure : IStartupProcedure
    {
        public void Run()
        {
            if (bool.TryParse(ConfigurationManager.AppSettings.Get(Const.DatabaseInitializedKey),
                    out bool isDatabaseInitialized) && isDatabaseInitialized == false)
            {
                using (var connection = Program.Container.Resolve<IDbConnection>())
                {
                    var initSql = File.ReadAllLines(Const.InitPath, Encoding.UTF8);
                    var insertSql = File.ReadAllLines(Const.InsertPath, Encoding.UTF8);

                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            var commandBuilder = new StringBuilder();
                            foreach (var sqlFile in new[] { initSql, insertSql })
                            {
                                foreach (var sqlLine in sqlFile)
                                {
                                    if (sqlLine.EndsWith(";"))
                                    {
                                        if (commandBuilder.Length == 0)
                                        {
                                            connection.Execute(sqlLine.Replace(';', ' '), transaction);
                                        }
                                        else
                                        {
                                            commandBuilder.AppendFormat(" {0} ", sqlLine);
                                            var sql = commandBuilder.ToString();
                                            connection.Execute(sql.Replace(';', ' '), null, transaction);
                                            commandBuilder.Clear();
                                        }
                                    }
                                    else
                                    {
                                        commandBuilder.Append(sqlLine);
                                    }
                                }
                            }
                            transaction.Commit();
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }

                ConfigurationManager.AppSettings.Set(Const.DatabaseInitializedKey, true.ToString());
            }
        }
    }
}