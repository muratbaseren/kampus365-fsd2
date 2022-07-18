namespace WinFormsApp1_Ders1
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
            this.btnConnectDatabase = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInsertNewCategory = new System.Windows.Forms.Button();
            this.btnReadAllCategories = new System.Windows.Forms.Button();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.btnReadAllCategoriesGrid = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExecuteScalar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenForm2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnectDatabase
            // 
            this.btnConnectDatabase.Location = new System.Drawing.Point(12, 12);
            this.btnConnectDatabase.Name = "btnConnectDatabase";
            this.btnConnectDatabase.Size = new System.Drawing.Size(97, 63);
            this.btnConnectDatabase.TabIndex = 0;
            this.btnConnectDatabase.Text = "Connect to Database";
            this.btnConnectDatabase.UseVisualStyleBackColor = true;
            this.btnConnectDatabase.Click += new System.EventHandler(this.btnConnectDatabase_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInsertNewCategory
            // 
            this.btnInsertNewCategory.Location = new System.Drawing.Point(12, 81);
            this.btnInsertNewCategory.Name = "btnInsertNewCategory";
            this.btnInsertNewCategory.Size = new System.Drawing.Size(97, 67);
            this.btnInsertNewCategory.TabIndex = 2;
            this.btnInsertNewCategory.Text = "Insert New Category";
            this.btnInsertNewCategory.UseVisualStyleBackColor = true;
            this.btnInsertNewCategory.Click += new System.EventHandler(this.btnInsertNewCategory_Click);
            // 
            // btnReadAllCategories
            // 
            this.btnReadAllCategories.Location = new System.Drawing.Point(12, 154);
            this.btnReadAllCategories.Name = "btnReadAllCategories";
            this.btnReadAllCategories.Size = new System.Drawing.Size(97, 67);
            this.btnReadAllCategories.TabIndex = 3;
            this.btnReadAllCategories.Text = "Read All Categories";
            this.btnReadAllCategories.UseVisualStyleBackColor = true;
            this.btnReadAllCategories.Click += new System.EventHandler(this.btnReadAllCategories_Click);
            // 
            // lstCategories
            // 
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.ItemHeight = 15;
            this.lstCategories.Location = new System.Drawing.Point(140, 12);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(305, 214);
            this.lstCategories.TabIndex = 4;
            // 
            // btnReadAllCategoriesGrid
            // 
            this.btnReadAllCategoriesGrid.Location = new System.Drawing.Point(12, 283);
            this.btnReadAllCategoriesGrid.Name = "btnReadAllCategoriesGrid";
            this.btnReadAllCategoriesGrid.Size = new System.Drawing.Size(97, 80);
            this.btnReadAllCategoriesGrid.TabIndex = 5;
            this.btnReadAllCategoriesGrid.Text = "Read All Categories (Grid)";
            this.btnReadAllCategoriesGrid.UseVisualStyleBackColor = true;
            this.btnReadAllCategoriesGrid.Click += new System.EventHandler(this.btnReadAllCategoriesGrid_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(140, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(386, 276);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnExecuteScalar
            // 
            this.btnExecuteScalar.Location = new System.Drawing.Point(12, 570);
            this.btnExecuteScalar.Name = "btnExecuteScalar";
            this.btnExecuteScalar.Size = new System.Drawing.Size(97, 81);
            this.btnExecuteScalar.TabIndex = 7;
            this.btnExecuteScalar.Text = "Execute Scalar";
            this.btnExecuteScalar.UseVisualStyleBackColor = true;
            this.btnExecuteScalar.Click += new System.EventHandler(this.btnExecuteScalar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(140, 598);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // btnOpenForm2
            // 
            this.btnOpenForm2.Location = new System.Drawing.Point(451, 628);
            this.btnOpenForm2.Name = "btnOpenForm2";
            this.btnOpenForm2.Size = new System.Drawing.Size(75, 23);
            this.btnOpenForm2.TabIndex = 9;
            this.btnOpenForm2.Text = "Form 2";
            this.btnOpenForm2.UseVisualStyleBackColor = true;
            this.btnOpenForm2.Click += new System.EventHandler(this.btnOpenForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 663);
            this.Controls.Add(this.btnOpenForm2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExecuteScalar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnReadAllCategoriesGrid);
            this.Controls.Add(this.lstCategories);
            this.Controls.Add(this.btnReadAllCategories);
            this.Controls.Add(this.btnInsertNewCategory);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConnectDatabase);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnConnectDatabase;
        private Button button1;
        private Button btnInsertNewCategory;
        private Button btnReadAllCategories;
        private ListBox lstCategories;
        private Button btnReadAllCategoriesGrid;
        private DataGridView dataGridView1;
        private Button btnExecuteScalar;
        private Label label1;
        private Button btnOpenForm2;
    }
}