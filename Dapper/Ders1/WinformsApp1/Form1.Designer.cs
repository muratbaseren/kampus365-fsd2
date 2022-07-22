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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtCDesc = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInsertAfter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudCId = new System.Windows.Forms.NumericUpDown();
            this.txtNewCName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewCDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudDeletedCId = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdoNetOrm = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.btnLoad2 = new System.Windows.Forms.Button();
            this.btnSelectWhere = new System.Windows.Forms.Button();
            this.btnInsertMany = new System.Windows.Forms.Button();
            this.btnSelectIn = new System.Windows.Forms.Button();
            this.btnStoredProc = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnSSMS = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCId)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeletedCId)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Desc :";
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(80, 22);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(133, 23);
            this.txtCName.TabIndex = 1;
            // 
            // txtCDesc
            // 
            this.txtCDesc.Location = new System.Drawing.Point(80, 51);
            this.txtCDesc.Name = "txtCDesc";
            this.txtCDesc.Size = new System.Drawing.Size(133, 23);
            this.txtCDesc.TabIndex = 1;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(161, 80);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(52, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCName);
            this.groupBox1.Controls.Add(this.btnInsertAfter);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCDesc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 121);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Category";
            // 
            // btnInsertAfter
            // 
            this.btnInsertAfter.Location = new System.Drawing.Point(80, 80);
            this.btnInsertAfter.Name = "btnInsertAfter";
            this.btnInsertAfter.Size = new System.Drawing.Size(75, 23);
            this.btnInsertAfter.TabIndex = 2;
            this.btnInsertAfter.Text = "Insert After";
            this.btnInsertAfter.UseVisualStyleBackColor = true;
            this.btnInsertAfter.Click += new System.EventHandler(this.btnInsertAfter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudCId);
            this.groupBox2.Controls.Add(this.txtNewCName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNewCDesc);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 159);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Category Update";
            // 
            // nudCId
            // 
            this.nudCId.Location = new System.Drawing.Point(80, 33);
            this.nudCId.Name = "nudCId";
            this.nudCId.Size = new System.Drawing.Size(133, 23);
            this.nudCId.TabIndex = 4;
            // 
            // txtNewCName
            // 
            this.txtNewCName.Location = new System.Drawing.Point(80, 61);
            this.txtNewCName.Name = "txtNewCName";
            this.txtNewCName.Size = new System.Drawing.Size(133, 23);
            this.txtNewCName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Id :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(138, 119);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name :";
            // 
            // txtNewCDesc
            // 
            this.txtNewCDesc.Location = new System.Drawing.Point(80, 90);
            this.txtNewCDesc.Name = "txtNewCDesc";
            this.txtNewCDesc.Size = new System.Drawing.Size(133, 23);
            this.txtNewCDesc.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Desc :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudDeletedCId);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Location = new System.Drawing.Point(249, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 121);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Category Delete";
            // 
            // nudDeletedCId
            // 
            this.nudDeletedCId.Location = new System.Drawing.Point(80, 23);
            this.nudDeletedCId.Name = "nudDeletedCId";
            this.nudDeletedCId.Size = new System.Drawing.Size(133, 23);
            this.nudDeletedCId.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Id :";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(138, 80);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdoNetOrm
            // 
            this.btnAdoNetOrm.Location = new System.Drawing.Point(664, 12);
            this.btnAdoNetOrm.Name = "btnAdoNetOrm";
            this.btnAdoNetOrm.Size = new System.Drawing.Size(95, 23);
            this.btnAdoNetOrm.TabIndex = 4;
            this.btnAdoNetOrm.Text = "ADO.NET ORM";
            this.btnAdoNetOrm.UseVisualStyleBackColor = true;
            this.btnAdoNetOrm.Click += new System.EventHandler(this.btnAdoNetOrm_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(381, 312);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(99, 23);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load Dynamic";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lstCategories
            // 
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.ItemHeight = 15;
            this.lstCategories.Location = new System.Drawing.Point(249, 152);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(231, 154);
            this.lstCategories.TabIndex = 6;
            // 
            // btnLoad2
            // 
            this.btnLoad2.Location = new System.Drawing.Point(249, 312);
            this.btnLoad2.Name = "btnLoad2";
            this.btnLoad2.Size = new System.Drawing.Size(126, 23);
            this.btnLoad2.TabIndex = 5;
            this.btnLoad2.Text = "Load Strongly Typed";
            this.btnLoad2.UseVisualStyleBackColor = true;
            this.btnLoad2.Click += new System.EventHandler(this.btnLoad2_Click);
            // 
            // btnSelectWhere
            // 
            this.btnSelectWhere.Location = new System.Drawing.Point(486, 152);
            this.btnSelectWhere.Name = "btnSelectWhere";
            this.btnSelectWhere.Size = new System.Drawing.Size(120, 23);
            this.btnSelectWhere.TabIndex = 7;
            this.btnSelectWhere.Text = "Select Where(...)";
            this.btnSelectWhere.UseVisualStyleBackColor = true;
            this.btnSelectWhere.Click += new System.EventHandler(this.btnSelectWhere_Click);
            // 
            // btnInsertMany
            // 
            this.btnInsertMany.Location = new System.Drawing.Point(486, 183);
            this.btnInsertMany.Name = "btnInsertMany";
            this.btnInsertMany.Size = new System.Drawing.Size(120, 23);
            this.btnInsertMany.TabIndex = 8;
            this.btnInsertMany.Text = "Insert Many";
            this.btnInsertMany.UseVisualStyleBackColor = true;
            this.btnInsertMany.Click += new System.EventHandler(this.btnInsertMany_Click);
            // 
            // btnSelectIn
            // 
            this.btnSelectIn.Location = new System.Drawing.Point(486, 212);
            this.btnSelectIn.Name = "btnSelectIn";
            this.btnSelectIn.Size = new System.Drawing.Size(120, 23);
            this.btnSelectIn.TabIndex = 9;
            this.btnSelectIn.Text = "Select IN";
            this.btnSelectIn.UseVisualStyleBackColor = true;
            this.btnSelectIn.Click += new System.EventHandler(this.btnSelectIn_Click);
            // 
            // btnStoredProc
            // 
            this.btnStoredProc.Location = new System.Drawing.Point(486, 241);
            this.btnStoredProc.Name = "btnStoredProc";
            this.btnStoredProc.Size = new System.Drawing.Size(120, 23);
            this.btnStoredProc.TabIndex = 10;
            this.btnStoredProc.Text = "Stored Proc";
            this.btnStoredProc.UseVisualStyleBackColor = true;
            this.btnStoredProc.Click += new System.EventHandler(this.btnStoredProc_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.Location = new System.Drawing.Point(486, 270);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(120, 23);
            this.btnTransaction.TabIndex = 11;
            this.btnTransaction.Text = "Transaction";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnSSMS
            // 
            this.btnSSMS.Location = new System.Drawing.Point(664, 41);
            this.btnSSMS.Name = "btnSSMS";
            this.btnSSMS.Size = new System.Drawing.Size(95, 23);
            this.btnSSMS.TabIndex = 12;
            this.btnSSMS.Text = "My SSMS";
            this.btnSSMS.UseVisualStyleBackColor = true;
            this.btnSSMS.Click += new System.EventHandler(this.btnSSMS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 372);
            this.Controls.Add(this.btnSSMS);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.btnStoredProc);
            this.Controls.Add(this.btnSelectIn);
            this.Controls.Add(this.btnInsertMany);
            this.Controls.Add(this.btnSelectWhere);
            this.Controls.Add(this.lstCategories);
            this.Controls.Add(this.btnLoad2);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnAdoNetOrm);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCId)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeletedCId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCName;
        private TextBox txtCDesc;
        private Button btnInsert;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtNewCName;
        private Label label5;
        private Button btnUpdate;
        private Label label3;
        private TextBox txtNewCDesc;
        private Label label4;
        private NumericUpDown nudCId;
        private GroupBox groupBox3;
        private NumericUpDown nudDeletedCId;
        private Label label6;
        private Button btnDelete;
        private Button btnAdoNetOrm;
        private Button btnLoad;
        private ListBox lstCategories;
        private Button btnLoad2;
        private Button btnSelectWhere;
        private Button btnInsertMany;
        private Button btnInsertAfter;
        private Button btnSelectIn;
        private Button btnStoredProc;
        private Button btnTransaction;
        private Button btnSSMS;
    }
}