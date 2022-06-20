namespace WindowsFormsApp2
{
    partial class frmClassrooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClassrooms));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClassroomDelete = new System.Windows.Forms.Button();
            this.btnClassroomSave = new System.Windows.Forms.Button();
            this.btnClassroomAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClassroomName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstClassrooms = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSave = new System.Windows.Forms.ToolStripButton();
            this.mnuCut = new System.Windows.Forms.ToolStripButton();
            this.mnuCopy = new System.Windows.Forms.ToolStripButton();
            this.mnuPaste = new System.Windows.Forms.ToolStripButton();
            this.mnuStudentAdd = new System.Windows.Forms.ToolStripButton();
            this.mnuShowStudentList = new System.Windows.Forms.ToolStripButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnClassroomDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnClassroomSave);
            this.flowLayoutPanel1.Controls.Add(this.btnClassroomAdd);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 338);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(372, 56);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtClassroomName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 276);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(372, 62);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstClassrooms);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8);
            this.panel2.Size = new System.Drawing.Size(372, 276);
            this.panel2.TabIndex = 2;
            // 
            // btnClassroomDelete
            // 
            this.btnClassroomDelete.Location = new System.Drawing.Point(278, 11);
            this.btnClassroomDelete.Name = "btnClassroomDelete";
            this.btnClassroomDelete.Size = new System.Drawing.Size(75, 33);
            this.btnClassroomDelete.TabIndex = 0;
            this.btnClassroomDelete.Text = "Sil";
            this.btnClassroomDelete.UseVisualStyleBackColor = true;
            this.btnClassroomDelete.Click += new System.EventHandler(this.btnClassroomDelete_Click);
            // 
            // btnClassroomSave
            // 
            this.btnClassroomSave.Location = new System.Drawing.Point(197, 11);
            this.btnClassroomSave.Name = "btnClassroomSave";
            this.btnClassroomSave.Size = new System.Drawing.Size(75, 33);
            this.btnClassroomSave.TabIndex = 1;
            this.btnClassroomSave.Text = "Kaydet";
            this.btnClassroomSave.UseVisualStyleBackColor = true;
            this.btnClassroomSave.Click += new System.EventHandler(this.btnClassroomSave_Click);
            // 
            // btnClassroomAdd
            // 
            this.btnClassroomAdd.Location = new System.Drawing.Point(116, 11);
            this.btnClassroomAdd.Name = "btnClassroomAdd";
            this.btnClassroomAdd.Size = new System.Drawing.Size(75, 33);
            this.btnClassroomAdd.TabIndex = 2;
            this.btnClassroomAdd.Text = "Ekle";
            this.btnClassroomAdd.UseVisualStyleBackColor = true;
            this.btnClassroomAdd.Click += new System.EventHandler(this.btnClassroomAdd_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sınıf Adı :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtClassroomName
            // 
            this.txtClassroomName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClassroomName.Location = new System.Drawing.Point(8, 32);
            this.txtClassroomName.Name = "txtClassroomName";
            this.txtClassroomName.Size = new System.Drawing.Size(356, 23);
            this.txtClassroomName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(8, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sınıflar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstClassrooms
            // 
            this.lstClassrooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstClassrooms.FormattingEnabled = true;
            this.lstClassrooms.ItemHeight = 16;
            this.lstClassrooms.Location = new System.Drawing.Point(8, 57);
            this.lstClassrooms.Name = "lstClassrooms";
            this.lstClassrooms.Size = new System.Drawing.Size(356, 211);
            this.lstClassrooms.TabIndex = 2;
            this.lstClassrooms.SelectedIndexChanged += new System.EventHandler(this.lstClassrooms_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSave,
            this.toolStripSeparator,
            this.mnuCut,
            this.mnuCopy,
            this.mnuPaste,
            this.toolStripSeparator1,
            this.mnuStudentAdd,
            this.mnuShowStudentList});
            this.toolStrip1.Location = new System.Drawing.Point(8, 8);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(356, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // mnuSave
            // 
            this.mnuSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuSave.Image = ((System.Drawing.Image)(resources.GetObject("mnuSave.Image")));
            this.mnuSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(23, 22);
            this.mnuSave.Text = "&Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuCut
            // 
            this.mnuCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuCut.Image = ((System.Drawing.Image)(resources.GetObject("mnuCut.Image")));
            this.mnuCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuCut.Name = "mnuCut";
            this.mnuCut.Size = new System.Drawing.Size(23, 22);
            this.mnuCut.Text = "C&ut";
            this.mnuCut.Click += new System.EventHandler(this.mnuCut_Click);
            // 
            // mnuCopy
            // 
            this.mnuCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuCopy.Image = ((System.Drawing.Image)(resources.GetObject("mnuCopy.Image")));
            this.mnuCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.Size = new System.Drawing.Size(23, 22);
            this.mnuCopy.Text = "&Copy";
            this.mnuCopy.Click += new System.EventHandler(this.mnuCopy_Click);
            // 
            // mnuPaste
            // 
            this.mnuPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuPaste.Image = ((System.Drawing.Image)(resources.GetObject("mnuPaste.Image")));
            this.mnuPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuPaste.Name = "mnuPaste";
            this.mnuPaste.Size = new System.Drawing.Size(23, 22);
            this.mnuPaste.Text = "&Paste";
            this.mnuPaste.Click += new System.EventHandler(this.mnuPaste_Click);
            // 
            // mnuStudentAdd
            // 
            this.mnuStudentAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuStudentAdd.Image = global::WindowsFormsApp2.Properties.Resources.add_people_16;
            this.mnuStudentAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuStudentAdd.Name = "mnuStudentAdd";
            this.mnuStudentAdd.Size = new System.Drawing.Size(23, 22);
            this.mnuStudentAdd.Text = "Öğrenci Ekle";
            this.mnuStudentAdd.Click += new System.EventHandler(this.mnuStudentAdd_Click);
            // 
            // mnuShowStudentList
            // 
            this.mnuShowStudentList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuShowStudentList.Image = global::WindowsFormsApp2.Properties.Resources.people_16;
            this.mnuShowStudentList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuShowStudentList.Name = "mnuShowStudentList";
            this.mnuShowStudentList.Size = new System.Drawing.Size(23, 22);
            this.mnuShowStudentList.Text = "Öğrenci Listele";
            // 
            // frmClassrooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 394);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmClassrooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sınıflar";
            this.Load += new System.EventHandler(this.frmClassrooms_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClassroomDelete;
        private System.Windows.Forms.Button btnClassroomSave;
        private System.Windows.Forms.Button btnClassroomAdd;
        private System.Windows.Forms.TextBox txtClassroomName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstClassrooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton mnuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton mnuCut;
        private System.Windows.Forms.ToolStripButton mnuCopy;
        private System.Windows.Forms.ToolStripButton mnuPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton mnuStudentAdd;
        private System.Windows.Forms.ToolStripButton mnuShowStudentList;
    }
}