namespace WinformsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDataSet = new System.Windows.Forms.Button();
            this.btnCommandBuilder = new System.Windows.Forms.Button();
            this.btnStoredProcedure = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbReportNames = new System.Windows.Forms.ComboBox();
            this.btnRefreshReportNames = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgDataView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDataSet);
            this.panel1.Controls.Add(this.btnCommandBuilder);
            this.panel1.Controls.Add(this.btnStoredProcedure);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbReportNames);
            this.panel1.Controls.Add(this.btnRefreshReportNames);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(877, 43);
            this.panel1.TabIndex = 0;
            // 
            // btnDataSet
            // 
            this.btnDataSet.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDataSet.Location = new System.Drawing.Point(246, 10);
            this.btnDataSet.Name = "btnDataSet";
            this.btnDataSet.Size = new System.Drawing.Size(104, 23);
            this.btnDataSet.TabIndex = 5;
            this.btnDataSet.Text = "DataSet";
            this.btnDataSet.UseVisualStyleBackColor = true;
            this.btnDataSet.Click += new System.EventHandler(this.btnDataSet_Click);
            // 
            // btnCommandBuilder
            // 
            this.btnCommandBuilder.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCommandBuilder.Location = new System.Drawing.Point(118, 10);
            this.btnCommandBuilder.Name = "btnCommandBuilder";
            this.btnCommandBuilder.Size = new System.Drawing.Size(128, 23);
            this.btnCommandBuilder.TabIndex = 4;
            this.btnCommandBuilder.Text = "Command Builder";
            this.btnCommandBuilder.UseVisualStyleBackColor = true;
            this.btnCommandBuilder.Click += new System.EventHandler(this.btnCommandBuilder_Click);
            // 
            // btnStoredProcedure
            // 
            this.btnStoredProcedure.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStoredProcedure.Location = new System.Drawing.Point(10, 10);
            this.btnStoredProcedure.Name = "btnStoredProcedure";
            this.btnStoredProcedure.Size = new System.Drawing.Size(108, 23);
            this.btnStoredProcedure.TabIndex = 3;
            this.btnStoredProcedure.Text = "Stored Procedure";
            this.btnStoredProcedure.UseVisualStyleBackColor = true;
            this.btnStoredProcedure.Click += new System.EventHandler(this.btnStoredProcedure_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(401, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reports :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbReportNames
            // 
            this.cmbReportNames.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmbReportNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportNames.FormattingEnabled = true;
            this.cmbReportNames.Location = new System.Drawing.Point(501, 10);
            this.cmbReportNames.Name = "cmbReportNames";
            this.cmbReportNames.Size = new System.Drawing.Size(333, 23);
            this.cmbReportNames.TabIndex = 0;
            this.cmbReportNames.SelectedIndexChanged += new System.EventHandler(this.cmbReportNames_SelectedIndexChanged);
            // 
            // btnRefreshReportNames
            // 
            this.btnRefreshReportNames.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefreshReportNames.Image = global::WinformsApp1.Properties.Resources.sync_16;
            this.btnRefreshReportNames.Location = new System.Drawing.Point(834, 10);
            this.btnRefreshReportNames.Name = "btnRefreshReportNames";
            this.btnRefreshReportNames.Size = new System.Drawing.Size(33, 23);
            this.btnRefreshReportNames.TabIndex = 2;
            this.btnRefreshReportNames.UseVisualStyleBackColor = true;
            this.btnRefreshReportNames.Click += new System.EventHandler(this.btnRefreshReportNames_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgDataView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(877, 398);
            this.panel2.TabIndex = 1;
            // 
            // dgDataView
            // 
            this.dgDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDataView.Location = new System.Drawing.Point(10, 10);
            this.dgDataView.Name = "dgDataView";
            this.dgDataView.RowTemplate.Height = 25;
            this.dgDataView.Size = new System.Drawing.Size(857, 378);
            this.dgDataView.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 441);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox cmbReportNames;
        private Panel panel2;
        private DataGridView dgDataView;
        private Button btnRefreshReportNames;
        private Button btnStoredProcedure;
        private Button btnCommandBuilder;
        private Button btnDataSet;
    }
}