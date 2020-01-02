﻿namespace USMarketAssistant
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabChart = new System.Windows.Forms.TabPage();
            this.tabData = new System.Windows.Forms.TabPage();
            this.tabSetting = new System.Windows.Forms.TabPage();
            this.txtFavoriteStocks = new System.Windows.Forms.TextBox();
            this.btnUpdateFavoriteStocks = new System.Windows.Forms.Button();
            this.lblFavoriteStocks = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabData.SuspendLayout();
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
            // tabSetting
            // 
            this.tabSetting.Location = new System.Drawing.Point(4, 22);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.Size = new System.Drawing.Size(1063, 636);
            this.tabSetting.TabIndex = 2;
            this.tabSetting.Text = "Settings";
            this.tabSetting.UseVisualStyleBackColor = true;
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
            // lblFavoriteStocks
            // 
            this.lblFavoriteStocks.AutoSize = true;
            this.lblFavoriteStocks.Location = new System.Drawing.Point(249, 240);
            this.lblFavoriteStocks.Name = "lblFavoriteStocks";
            this.lblFavoriteStocks.Size = new System.Drawing.Size(228, 13);
            this.lblFavoriteStocks.TabIndex = 2;
            this.lblFavoriteStocks.Text = "Enter your favorite stocks\' symbol (one per line)";
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
            this.tabData.ResumeLayout(false);
            this.tabData.PerformLayout();
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
    }
}