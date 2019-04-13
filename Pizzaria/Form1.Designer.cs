namespace Pizzaria
{
    partial class frmMain
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
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.btnShowResults = new System.Windows.Forms.Button();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.cmbAllReports = new System.Windows.Forms.ComboBox();
            this.lblChooseReport = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ribbonUpDown1 = new System.Windows.Forms.RibbonUpDown();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.PizzariaDataSet = new Pizzaria.PizzariaDataSet();
            this.ribbonUpDown2 = new System.Windows.Forms.RibbonUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PizzariaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(387, 77);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(147, 26);
            this.dtpFromDate.TabIndex = 2;
            this.dtpFromDate.Value = new System.DateTime(2018, 4, 7, 17, 13, 39, 0);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(387, 128);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(147, 26);
            this.dtpToDate.TabIndex = 3;
            // 
            // btnShowResults
            // 
            this.btnShowResults.Location = new System.Drawing.Point(482, 168);
            this.btnShowResults.Name = "btnShowResults";
            this.btnShowResults.Size = new System.Drawing.Size(164, 34);
            this.btnShowResults.TabIndex = 5;
            this.btnShowResults.Text = "Покажи";
            this.btnShowResults.UseVisualStyleBackColor = true;
            this.btnShowResults.Click += new System.EventHandler(this.btnShowResults_Click);
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFromDate.Location = new System.Drawing.Point(290, 74);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(91, 29);
            this.lblFromDate.TabIndex = 4;
            this.lblFromDate.Text = "От дата:";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblToDate.Location = new System.Drawing.Point(288, 125);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(93, 29);
            this.lblToDate.TabIndex = 6;
            this.lblToDate.Text = "До дата:";
            // 
            // cmbAllReports
            // 
            this.cmbAllReports.FormattingEnabled = true;
            this.cmbAllReports.Items.AddRange(new object[] {
            "10-те най-продавани продукта за зададен период",
            "10-те продукта с най-голяма сума на продажбите",
            "Клиенти без поръчка в зададен период",
            "Клиенти с оборот по-голям от зададена сума и период",
            "Всички продукти, поръчани от въведен клиент",
            "Всички поръчки с по-голяма стойност от въведената",
            "Детайлна информация за всяка поръчка"});
            this.cmbAllReports.Location = new System.Drawing.Point(432, 28);
            this.cmbAllReports.Name = "cmbAllReports";
            this.cmbAllReports.Size = new System.Drawing.Size(472, 26);
            this.cmbAllReports.TabIndex = 1;
            this.cmbAllReports.SelectedValueChanged += new System.EventHandler(this.cmbAllReports_SelectedValueChanged);
            // 
            // lblChooseReport
            // 
            this.lblChooseReport.AutoSize = true;
            this.lblChooseReport.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChooseReport.Location = new System.Drawing.Point(233, 21);
            this.lblChooseReport.Name = "lblChooseReport";
            this.lblChooseReport.Size = new System.Drawing.Size(180, 35);
            this.lblChooseReport.TabIndex = 8;
            this.lblChooseReport.Text = "Избери отчет:";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSum.Location = new System.Drawing.Point(561, 74);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(66, 29);
            this.lblSum.TabIndex = 9;
            this.lblSum.Text = "Сума:";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(726, 77);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(156, 26);
            this.txtSum.TabIndex = 4;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 208);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1151, 630);
            this.crystalReportViewer1.TabIndex = 11;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ribbonUpDown1
            // 
            this.ribbonUpDown1.AltKey = null;
            this.ribbonUpDown1.CheckedGroup = null;
            this.ribbonUpDown1.Image = null;
            this.ribbonUpDown1.Tag = null;
            this.ribbonUpDown1.Text = null;
            this.ribbonUpDown1.TextBoxText = "";
            this.ribbonUpDown1.TextBoxWidth = 50;
            this.ribbonUpDown1.ToolTip = null;
            this.ribbonUpDown1.ToolTipTitle = null;
            this.ribbonUpDown1.Value = null;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClientName.Location = new System.Drawing.Point(561, 125);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(160, 29);
            this.lblClientName.TabIndex = 12;
            this.lblClientName.Text = "Име на клиент:";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(726, 125);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(156, 26);
            this.txtClientName.TabIndex = 13;
            // 
            // PizzariaDataSet
            // 
            this.PizzariaDataSet.DataSetName = "PizzariaDataSet";
            this.PizzariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ribbonUpDown2
            // 
            this.ribbonUpDown2.AltKey = null;
            this.ribbonUpDown2.CheckedGroup = null;
            this.ribbonUpDown2.Image = null;
            this.ribbonUpDown2.Tag = null;
            this.ribbonUpDown2.Text = null;
            this.ribbonUpDown2.TextBoxText = "";
            this.ribbonUpDown2.TextBoxWidth = 50;
            this.ribbonUpDown2.ToolTip = null;
            this.ribbonUpDown2.ToolTipTitle = null;
            this.ribbonUpDown2.Value = null;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 840);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblChooseReport);
            this.Controls.Add(this.cmbAllReports);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.btnShowResults);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчети";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PizzariaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PizzariaDataSet PizzariaDataSet;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Button btnShowResults;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.ComboBox cmbAllReports;
        private System.Windows.Forms.Label lblChooseReport;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.TextBox txtSum;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.RibbonUpDown ribbonUpDown1;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.RibbonUpDown ribbonUpDown2;
    }
}

