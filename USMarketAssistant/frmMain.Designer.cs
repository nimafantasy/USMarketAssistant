namespace USMarketAssistant
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabChart = new System.Windows.Forms.TabPage();
            this.tabData = new System.Windows.Forms.TabPage();
            this.btnSaveService1ApiKey = new System.Windows.Forms.Button();
            this.txtService1ApiKey = new System.Windows.Forms.TextBox();
            this.lblEnterApi = new System.Windows.Forms.Label();
            this.lblFavoriteStocks = new System.Windows.Forms.Label();
            this.btnUpdateFavoriteStocks = new System.Windows.Forms.Button();
            this.txtFavoriteStocks = new System.Windows.Forms.TextBox();
            this.tabSetting = new System.Windows.Forms.TabPage();
            this.lbFavorites = new System.Windows.Forms.ListBox();
            this.chrtMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rbPeriod10Y = new System.Windows.Forms.RadioButton();
            this.rbPeriod1Y = new System.Windows.Forms.RadioButton();
            this.rbPeriod9M = new System.Windows.Forms.RadioButton();
            this.rbPeriod6M = new System.Windows.Forms.RadioButton();
            this.rbPeriod3M = new System.Windows.Forms.RadioButton();
            this.rbPeriod1M = new System.Windows.Forms.RadioButton();
            this.pnlPeriods = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabChart.SuspendLayout();
            this.tabData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtMain)).BeginInit();
            this.pnlPeriods.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabChart);
            this.tabControl1.Controls.Add(this.tabData);
            this.tabControl1.Controls.Add(this.tabSetting);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1071, 662);
            this.tabControl1.TabIndex = 0;
            // 
            // tabChart
            // 
            this.tabChart.Controls.Add(this.pnlPeriods);
            this.tabChart.Controls.Add(this.chrtMain);
            this.tabChart.Controls.Add(this.lbFavorites);
            this.tabChart.Location = new System.Drawing.Point(4, 22);
            this.tabChart.Name = "tabChart";
            this.tabChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabChart.Size = new System.Drawing.Size(1063, 636);
            this.tabChart.TabIndex = 0;
            this.tabChart.Text = "Chart";
            this.tabChart.UseVisualStyleBackColor = true;
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.btnSaveService1ApiKey);
            this.tabData.Controls.Add(this.txtService1ApiKey);
            this.tabData.Controls.Add(this.lblEnterApi);
            this.tabData.Controls.Add(this.lblFavoriteStocks);
            this.tabData.Controls.Add(this.btnUpdateFavoriteStocks);
            this.tabData.Controls.Add(this.txtFavoriteStocks);
            this.tabData.Location = new System.Drawing.Point(4, 22);
            this.tabData.Name = "tabData";
            this.tabData.Size = new System.Drawing.Size(1063, 636);
            this.tabData.TabIndex = 1;
            this.tabData.Text = "Data";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // btnSaveService1ApiKey
            // 
            this.btnSaveService1ApiKey.Location = new System.Drawing.Point(499, 116);
            this.btnSaveService1ApiKey.Name = "btnSaveService1ApiKey";
            this.btnSaveService1ApiKey.Size = new System.Drawing.Size(75, 23);
            this.btnSaveService1ApiKey.TabIndex = 5;
            this.btnSaveService1ApiKey.Text = "Save Key";
            this.btnSaveService1ApiKey.UseVisualStyleBackColor = true;
            this.btnSaveService1ApiKey.Click += new System.EventHandler(this.btnSaveService1ApiKey_Click);
            // 
            // txtService1ApiKey
            // 
            this.txtService1ApiKey.Location = new System.Drawing.Point(252, 90);
            this.txtService1ApiKey.Name = "txtService1ApiKey";
            this.txtService1ApiKey.Size = new System.Drawing.Size(575, 20);
            this.txtService1ApiKey.TabIndex = 4;
            // 
            // lblEnterApi
            // 
            this.lblEnterApi.AutoSize = true;
            this.lblEnterApi.Location = new System.Drawing.Point(252, 74);
            this.lblEnterApi.Name = "lblEnterApi";
            this.lblEnterApi.Size = new System.Drawing.Size(151, 13);
            this.lblEnterApi.TabIndex = 3;
            this.lblEnterApi.Text = "Please enter the API key here:";
            // 
            // lblFavoriteStocks
            // 
            this.lblFavoriteStocks.AutoSize = true;
            this.lblFavoriteStocks.Location = new System.Drawing.Point(249, 240);
            this.lblFavoriteStocks.Name = "lblFavoriteStocks";
            this.lblFavoriteStocks.Size = new System.Drawing.Size(228, 13);
            this.lblFavoriteStocks.TabIndex = 2;
            this.lblFavoriteStocks.Text = "Enter your favorite stocks\' symbol (one per line)";
            // 
            // btnUpdateFavoriteStocks
            // 
            this.btnUpdateFavoriteStocks.Location = new System.Drawing.Point(499, 584);
            this.btnUpdateFavoriteStocks.Name = "btnUpdateFavoriteStocks";
            this.btnUpdateFavoriteStocks.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateFavoriteStocks.TabIndex = 1;
            this.btnUpdateFavoriteStocks.Text = "Update List";
            this.btnUpdateFavoriteStocks.UseVisualStyleBackColor = true;
            this.btnUpdateFavoriteStocks.Click += new System.EventHandler(this.btnUpdateFavoriteStocks_Click);
            // 
            // txtFavoriteStocks
            // 
            this.txtFavoriteStocks.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFavoriteStocks.Location = new System.Drawing.Point(252, 256);
            this.txtFavoriteStocks.Multiline = true;
            this.txtFavoriteStocks.Name = "txtFavoriteStocks";
            this.txtFavoriteStocks.Size = new System.Drawing.Size(575, 322);
            this.txtFavoriteStocks.TabIndex = 0;
            // 
            // tabSetting
            // 
            this.tabSetting.Location = new System.Drawing.Point(4, 22);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.Size = new System.Drawing.Size(1063, 636);
            this.tabSetting.TabIndex = 2;
            this.tabSetting.Text = "Settings";
            this.tabSetting.UseVisualStyleBackColor = true;
            // 
            // lbFavorites
            // 
            this.lbFavorites.FormattingEnabled = true;
            this.lbFavorites.Location = new System.Drawing.Point(6, 6);
            this.lbFavorites.Name = "lbFavorites";
            this.lbFavorites.Size = new System.Drawing.Size(133, 446);
            this.lbFavorites.TabIndex = 0;
            this.lbFavorites.SelectedIndexChanged += new System.EventHandler(this.lbFavorites_SelectedIndexChanged);
            // 
            // chrtMain
            // 
            chartArea4.Name = "ChartArea1";
            this.chrtMain.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chrtMain.Legends.Add(legend4);
            this.chrtMain.Location = new System.Drawing.Point(145, 6);
            this.chrtMain.Name = "chrtMain";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chrtMain.Series.Add(series4);
            this.chrtMain.Size = new System.Drawing.Size(912, 624);
            this.chrtMain.TabIndex = 1;
            this.chrtMain.Text = "chart1";
            // 
            // rbPeriod10Y
            // 
            this.rbPeriod10Y.AutoSize = true;
            this.rbPeriod10Y.Location = new System.Drawing.Point(3, 3);
            this.rbPeriod10Y.Name = "rbPeriod10Y";
            this.rbPeriod10Y.Size = new System.Drawing.Size(62, 17);
            this.rbPeriod10Y.TabIndex = 2;
            this.rbPeriod10Y.TabStop = true;
            this.rbPeriod10Y.Text = "10 Year";
            this.rbPeriod10Y.UseVisualStyleBackColor = true;
            this.rbPeriod10Y.CheckedChanged += new System.EventHandler(this.periodRadioButtons_CheckedChanged);
            // 
            // rbPeriod1Y
            // 
            this.rbPeriod1Y.AutoSize = true;
            this.rbPeriod1Y.Location = new System.Drawing.Point(3, 26);
            this.rbPeriod1Y.Name = "rbPeriod1Y";
            this.rbPeriod1Y.Size = new System.Drawing.Size(56, 17);
            this.rbPeriod1Y.TabIndex = 3;
            this.rbPeriod1Y.TabStop = true;
            this.rbPeriod1Y.Text = "1 Year";
            this.rbPeriod1Y.UseVisualStyleBackColor = true;
            this.rbPeriod1Y.CheckedChanged += new System.EventHandler(this.periodRadioButtons_CheckedChanged);
            // 
            // rbPeriod9M
            // 
            this.rbPeriod9M.AutoSize = true;
            this.rbPeriod9M.Location = new System.Drawing.Point(3, 50);
            this.rbPeriod9M.Name = "rbPeriod9M";
            this.rbPeriod9M.Size = new System.Drawing.Size(69, 17);
            this.rbPeriod9M.TabIndex = 4;
            this.rbPeriod9M.TabStop = true;
            this.rbPeriod9M.Text = "9 Months";
            this.rbPeriod9M.UseVisualStyleBackColor = true;
            this.rbPeriod9M.CheckedChanged += new System.EventHandler(this.periodRadioButtons_CheckedChanged);
            // 
            // rbPeriod6M
            // 
            this.rbPeriod6M.AutoSize = true;
            this.rbPeriod6M.Location = new System.Drawing.Point(3, 73);
            this.rbPeriod6M.Name = "rbPeriod6M";
            this.rbPeriod6M.Size = new System.Drawing.Size(69, 17);
            this.rbPeriod6M.TabIndex = 5;
            this.rbPeriod6M.TabStop = true;
            this.rbPeriod6M.Text = "6 Months";
            this.rbPeriod6M.UseVisualStyleBackColor = true;
            this.rbPeriod6M.CheckedChanged += new System.EventHandler(this.periodRadioButtons_CheckedChanged);
            // 
            // rbPeriod3M
            // 
            this.rbPeriod3M.AutoSize = true;
            this.rbPeriod3M.Location = new System.Drawing.Point(3, 96);
            this.rbPeriod3M.Name = "rbPeriod3M";
            this.rbPeriod3M.Size = new System.Drawing.Size(69, 17);
            this.rbPeriod3M.TabIndex = 6;
            this.rbPeriod3M.TabStop = true;
            this.rbPeriod3M.Text = "3 Months";
            this.rbPeriod3M.UseVisualStyleBackColor = true;
            this.rbPeriod3M.CheckedChanged += new System.EventHandler(this.periodRadioButtons_CheckedChanged);
            // 
            // rbPeriod1M
            // 
            this.rbPeriod1M.AutoSize = true;
            this.rbPeriod1M.Location = new System.Drawing.Point(3, 119);
            this.rbPeriod1M.Name = "rbPeriod1M";
            this.rbPeriod1M.Size = new System.Drawing.Size(64, 17);
            this.rbPeriod1M.TabIndex = 7;
            this.rbPeriod1M.TabStop = true;
            this.rbPeriod1M.Text = "1 Month";
            this.rbPeriod1M.UseVisualStyleBackColor = true;
            this.rbPeriod1M.CheckedChanged += new System.EventHandler(this.periodRadioButtons_CheckedChanged);
            // 
            // pnlPeriods
            // 
            this.pnlPeriods.Controls.Add(this.rbPeriod10Y);
            this.pnlPeriods.Controls.Add(this.rbPeriod1M);
            this.pnlPeriods.Controls.Add(this.rbPeriod1Y);
            this.pnlPeriods.Controls.Add(this.rbPeriod3M);
            this.pnlPeriods.Controls.Add(this.rbPeriod9M);
            this.pnlPeriods.Controls.Add(this.rbPeriod6M);
            this.pnlPeriods.Location = new System.Drawing.Point(6, 458);
            this.pnlPeriods.Name = "pnlPeriods";
            this.pnlPeriods.Size = new System.Drawing.Size(133, 143);
            this.pnlPeriods.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 686);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.Text = "Stock Assistant";
            this.tabControl1.ResumeLayout(false);
            this.tabChart.ResumeLayout(false);
            this.tabData.ResumeLayout(false);
            this.tabData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtMain)).EndInit();
            this.pnlPeriods.ResumeLayout(false);
            this.pnlPeriods.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabChart;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.TabPage tabSetting;
        private System.Windows.Forms.TextBox txtFavoriteStocks;
        private System.Windows.Forms.Button btnUpdateFavoriteStocks;
        private System.Windows.Forms.Label lblFavoriteStocks;
        private System.Windows.Forms.Button btnSaveService1ApiKey;
        private System.Windows.Forms.TextBox txtService1ApiKey;
        private System.Windows.Forms.Label lblEnterApi;
        private System.Windows.Forms.ListBox lbFavorites;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtMain;
        private System.Windows.Forms.Panel pnlPeriods;
        private System.Windows.Forms.RadioButton rbPeriod10Y;
        private System.Windows.Forms.RadioButton rbPeriod1M;
        private System.Windows.Forms.RadioButton rbPeriod1Y;
        private System.Windows.Forms.RadioButton rbPeriod3M;
        private System.Windows.Forms.RadioButton rbPeriod9M;
        private System.Windows.Forms.RadioButton rbPeriod6M;
    }
}