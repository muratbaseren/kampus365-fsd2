namespace WinFormsApp1
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
            this.btnUseStreamWriter = new System.Windows.Forms.Button();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUseStreamReader = new System.Windows.Forms.Button();
            this.btnExcelExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUseStreamWriter
            // 
            this.btnUseStreamWriter.Location = new System.Drawing.Point(231, 12);
            this.btnUseStreamWriter.Name = "btnUseStreamWriter";
            this.btnUseStreamWriter.Size = new System.Drawing.Size(190, 49);
            this.btnUseStreamWriter.TabIndex = 0;
            this.btnUseStreamWriter.Text = "Stream Writer ile Yazma";
            this.btnUseStreamWriter.UseVisualStyleBackColor = true;
            this.btnUseStreamWriter.Click += new System.EventHandler(this.btnUseStreamWriter_Click);
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.ItemHeight = 15;
            this.lstItems.Location = new System.Drawing.Point(12, 12);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(213, 349);
            this.lstItems.TabIndex = 1;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(12, 367);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(132, 23);
            this.txtText.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(150, 367);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUseStreamReader
            // 
            this.btnUseStreamReader.Location = new System.Drawing.Point(231, 67);
            this.btnUseStreamReader.Name = "btnUseStreamReader";
            this.btnUseStreamReader.Size = new System.Drawing.Size(190, 49);
            this.btnUseStreamReader.TabIndex = 4;
            this.btnUseStreamReader.Text = "Stream Reader ile Okuma";
            this.btnUseStreamReader.UseVisualStyleBackColor = true;
            this.btnUseStreamReader.Click += new System.EventHandler(this.btnUseStreamReader_Click);
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.Location = new System.Drawing.Point(231, 122);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(190, 50);
            this.btnExcelExport.TabIndex = 5;
            this.btnExcelExport.Text = "Excel Export";
            this.btnExcelExport.UseVisualStyleBackColor = true;
            this.btnExcelExport.Click += new System.EventHandler(this.btnExcelExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 408);
            this.Controls.Add(this.btnExcelExport);
            this.Controls.Add(this.btnUseStreamReader);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.btnUseStreamWriter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUseStreamWriter;
        private ListBox lstItems;
        private TextBox txtText;
        private Button btnAdd;
        private Button btnUseStreamReader;
        private Button btnExcelExport;
    }
}