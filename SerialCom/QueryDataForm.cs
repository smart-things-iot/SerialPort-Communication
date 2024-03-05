using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialCom
{
    public partial class QueryDataForm : Form
    {
        IFreeSql freeSql = null;
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


        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }
    }
}
