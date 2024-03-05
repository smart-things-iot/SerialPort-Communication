namespace SerialCom
{
    partial class QueryDataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbContainer = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvQueryResult = new System.Windows.Forms.DataGridView();
            this.gbQueryCondition = new System.Windows.Forms.GroupBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCountInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryResult)).BeginInit();
            this.gbQueryCondition.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbContainer
            // 
            this.gbContainer.Controls.Add(this.groupBox1);
            this.gbContainer.Controls.Add(this.gbQueryCondition);
            this.gbContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbContainer.Location = new System.Drawing.Point(0, 0);
            this.gbContainer.Name = "gbContainer";
            this.gbContainer.Size = new System.Drawing.Size(994, 573);
            this.gbContainer.TabIndex = 0;
            this.gbContainer.TabStop = false;
            this.gbContainer.Text = "导出数据";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.statusStrip1);
            this.groupBox1.Controls.Add(this.dgvQueryResult);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(988, 429);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询结果";
            // 
            // dgvQueryResult
            // 
            this.dgvQueryResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueryResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQueryResult.Location = new System.Drawing.Point(3, 17);
            this.dgvQueryResult.Name = "dgvQueryResult";
            this.dgvQueryResult.RowTemplate.Height = 23;
            this.dgvQueryResult.Size = new System.Drawing.Size(982, 409);
            this.dgvQueryResult.TabIndex = 0;
            // 
            // gbQueryCondition
            // 
            this.gbQueryCondition.Controls.Add(this.btnQuery);
            this.gbQueryCondition.Controls.Add(this.btnExport);
            this.gbQueryCondition.Controls.Add(this.label1);
            this.gbQueryCondition.Controls.Add(this.lblStartTime);
            this.gbQueryCondition.Controls.Add(this.dtpEnd);
            this.gbQueryCondition.Controls.Add(this.dtpStart);
            this.gbQueryCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbQueryCondition.Location = new System.Drawing.Point(3, 17);
            this.gbQueryCondition.Name = "gbQueryCondition";
            this.gbQueryCondition.Size = new System.Drawing.Size(988, 124);
            this.gbQueryCondition.TabIndex = 0;
            this.gbQueryCondition.TabStop = false;
            this.gbQueryCondition.Text = "查询条件";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(223, 79);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(306, 79);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "结束时间";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(92, 27);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(53, 12);
            this.lblStartTime.TabIndex = 2;
            this.lblStartTime.Text = "起始时间";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(151, 52);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(230, 21);
            this.dtpEnd.TabIndex = 1;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(151, 21);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(230, 21);
            this.dtpStart.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCount,
            this.lblCountInfo});
            this.statusStrip1.Location = new System.Drawing.Point(3, 404);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(982, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblCount
            // 
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(56, 17);
            this.lblCount.Text = "查询结果";
            // 
            // lblCountInfo
            // 
            this.lblCountInfo.Name = "lblCountInfo";
            this.lblCountInfo.Size = new System.Drawing.Size(15, 17);
            this.lblCountInfo.Text = "0";
            // 
            // QueryDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 573);
            this.Controls.Add(this.gbContainer);
            this.Name = "QueryDataForm";
            this.Text = "QueryDataForm";
            this.gbContainer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryResult)).EndInit();
            this.gbQueryCondition.ResumeLayout(false);
            this.gbQueryCondition.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContainer;
        private System.Windows.Forms.GroupBox gbQueryCondition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvQueryResult;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCount;
        private System.Windows.Forms.ToolStripStatusLabel lblCountInfo;
    }
}