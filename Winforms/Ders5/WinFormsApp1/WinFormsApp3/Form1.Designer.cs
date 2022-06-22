namespace WinFormsApp3
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
            this.btnXmlSave = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductCat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudProductPrice = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReadXml = new System.Windows.Forms.Button();
            this.btnJSONSave = new System.Windows.Forms.Button();
            this.btnReadFromJSON = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXmlSave
            // 
            this.btnXmlSave.Location = new System.Drawing.Point(193, 12);
            this.btnXmlSave.Name = "btnXmlSave";
            this.btnXmlSave.Size = new System.Drawing.Size(173, 54);
            this.btnXmlSave.TabIndex = 0;
            this.btnXmlSave.Text = "XML Save";
            this.btnXmlSave.UseVisualStyleBackColor = true;
            this.btnXmlSave.Click += new System.EventHandler(this.btnXmlSave_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(175, 304);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adı ";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(60, 324);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(127, 23);
            this.txtProductName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kat.";
            // 
            // txtProductCat
            // 
            this.txtProductCat.Location = new System.Drawing.Point(60, 353);
            this.txtProductCat.Name = "txtProductCat";
            this.txtProductCat.Size = new System.Drawing.Size(127, 23);
            this.txtProductCat.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyat";
            // 
            // nudProductPrice
            // 
            this.nudProductPrice.Location = new System.Drawing.Point(60, 383);
            this.nudProductPrice.Name = "nudProductPrice";
            this.nudProductPrice.Size = new System.Drawing.Size(127, 23);
            this.nudProductPrice.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(112, 412);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReadXml
            // 
            this.btnReadXml.Location = new System.Drawing.Point(193, 72);
            this.btnReadXml.Name = "btnReadXml";
            this.btnReadXml.Size = new System.Drawing.Size(173, 54);
            this.btnReadXml.TabIndex = 6;
            this.btnReadXml.Text = "Read From XML";
            this.btnReadXml.UseVisualStyleBackColor = true;
            this.btnReadXml.Click += new System.EventHandler(this.btnReadXml_Click);
            // 
            // btnJSONSave
            // 
            this.btnJSONSave.Location = new System.Drawing.Point(193, 178);
            this.btnJSONSave.Name = "btnJSONSave";
            this.btnJSONSave.Size = new System.Drawing.Size(173, 54);
            this.btnJSONSave.TabIndex = 7;
            this.btnJSONSave.Text = "JSON Save";
            this.btnJSONSave.UseVisualStyleBackColor = true;
            this.btnJSONSave.Click += new System.EventHandler(this.btnJSONSave_Click);
            // 
            // btnReadFromJSON
            // 
            this.btnReadFromJSON.Location = new System.Drawing.Point(193, 238);
            this.btnReadFromJSON.Name = "btnReadFromJSON";
            this.btnReadFromJSON.Size = new System.Drawing.Size(173, 54);
            this.btnReadFromJSON.TabIndex = 7;
            this.btnReadFromJSON.Text = "Read from JSON";
            this.btnReadFromJSON.UseVisualStyleBackColor = true;
            this.btnReadFromJSON.Click += new System.EventHandler(this.btnReadFromJSON_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReadFromJSON);
            this.Controls.Add(this.btnJSONSave);
            this.Controls.Add(this.btnReadXml);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nudProductPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductCat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnXmlSave);
            this.Name = "Form1";
            this.Text = "Serialization";
            ((System.ComponentModel.ISupportInitialize)(this.nudProductPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnXmlSave;
        private ListBox listBox1;
        private Label label1;
        private TextBox txtProductName;
        private Label label2;
        private TextBox txtProductCat;
        private Label label3;
        private NumericUpDown nudProductPrice;
        private Button btnAdd;
        private Button btnReadXml;
        private Button btnJSONSave;
        private Button btnReadFromJSON;
    }
}