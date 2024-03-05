using MiniExcelLibs;
using SerialCom.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialCom
{
    public partial class QueryDataForm : Form
    {
        IFreeSql freeSql = null;
        List<DataSent> list = new List<DataSent>();
        public QueryDataForm()
        {
            InitializeComponent();

            this.dtpStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            //使用自定义格式
            this.dtpStart.Format = DateTimePickerFormat.Custom;
            //时间控件的启用
            this.dtpStart.ShowUpDown = true;

            this.dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            //使用自定义格式
            this.dtpEnd.Format = DateTimePickerFormat.Custom;
            //时间控件的启用
            this.dtpEnd.ShowUpDown = true;
            InitializeFreeSql();


        }
        private void InitializeFreeSql()
        {
            try
            {
                freeSql = FreeSqlHelper.GetFreeSql();
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库未打开, 原因：" + ex.Message);
            }
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime start = this.dtpStart.Value;
            DateTime end = this.dtpEnd.Value;

            var result = freeSql.Select<DataSent>()
                                  .Where(a => a.Timestamp > start && a.Timestamp < end)
                                  .ToList();

            this.dgvQueryResult.DataSource = result;
            this.list = result;
            if (result.Count > 0)
            {
                this.lblCountInfo.Text = result.Count.ToString();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (this.list.Any())
            {
                //获得当前目录的路径
                string currentDirectory = Directory.GetCurrentDirectory();

                //合并当前目录与Excel文件名
                var path = Path.Combine(currentDirectory, $"{DateTime.Now.ToString("yyyyMMddHHmmss")}.xlsx");

                MiniExcel.SaveAs(path, this.list);

                MessageBox.Show(string.Format("共 {0} 条数据导出成功~", this.list.Count().ToString()));
            }
        }
    }
}
