using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialCom
{
    
    public static class FreeSqlHelper
    {
        public static IFreeSql freeSql;
        public static IFreeSql GetFreeSql(){
            try
            {
                //@"Data Source=Resources\database.db; Attachs=test.db; Pooling=true;Min Pool Size=1"
                //var connstr = ConfigurationManager.AppSettings["connectionString"];
                var connstr = @"Data Source = Resources\database.db";
                freeSql = new FreeSql.FreeSqlBuilder()
                    .UseConnectionString(FreeSql.DataType.Sqlite, connstr)
                    .UseMonitorCommand(cmd => Console.WriteLine("\r\n SQL==> \r\n" + cmd.CommandText))
                    .UseAutoSyncStructure(true)
                    .UseNoneCommandParameter(true)
                    .Build();
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库未打开, 原因：" + ex.Message);
            }

            return freeSql;
        }
    }
}
