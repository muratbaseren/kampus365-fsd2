namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.trcOpacity = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbTaxExclude = new System.Windows.Forms.RadioButton();
            this.rdbTaxInclude = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbExpenseCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.nudExpensePrice = new System.Windows.Forms.NumericUpDown();
            this.dtpExpenseDate = new System.Windows.Forms.DateTimePicker();
            this.txtExpenseName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelExpense = new System.Windows.Forms.Button();
            this.btnSaveExpense = new System.Windows.Forms.Button();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstExpenses = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCloseApp = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.çalışanYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUserManage = new System.Windows.Forms.Button();
            this.btnDelCategory = new System.Windows.Forms.Button();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnRestartApp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCloseApp = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcOpacity)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpensePrice)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnUserManage);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelCategory);
            this.splitContainer1.Panel1.Controls.Add(this.btnSaveCategory);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddCategory);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.lstCategories);
            this.splitContainer1.Panel1.Controls.Add(this.cmbEmployees);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtCategoryName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.trcOpacity);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.btnDelExpense);
            this.splitContainer1.Panel2.Controls.Add(this.btnSaveExpense);
            this.splitContainer1.Panel2.Controls.Add(this.btnAddExpense);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.lstExpenses);
            this.splitContainer1.Size = new System.Drawing.Size(797, 519);
            this.splitContainer1.SplitterDistance = 269;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Harcama Kategorileri";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lstCategories
            // 
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.ItemHeight = 16;
            this.lstCategories.Items.AddRange(new object[] {
            "Gıda",
            "Akaryakıt",
            "Kırtasiye",
            "Diğer"});
            this.lstCategories.Location = new System.Drawing.Point(17, 108);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(237, 324);
            this.lstCategories.TabIndex = 2;
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Items.AddRange(new object[] {
            "Murat Başeren",
            "Kadir Başeren",
            "Yiğit Başeren",
            "Belinay Başeren"});
            this.cmbEmployees.Location = new System.Drawing.Point(17, 43);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(197, 24);
            this.cmbEmployees.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cmbEmployees, "Bu alandan hacama yapan çalışan seçimini yapabilirsiniz.");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 443);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Kategori Adı :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çalışanlar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(98, 440);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(156, 24);
            this.txtCategoryName.TabIndex = 11;
            // 
            // trcOpacity
            // 
            this.trcOpacity.Location = new System.Drawing.Point(15, 470);
            this.trcOpacity.Maximum = 100;
            this.trcOpacity.Minimum = 20;
            this.trcOpacity.Name = "trcOpacity";
            this.trcOpacity.Size = new System.Drawing.Size(193, 45);
            this.trcOpacity.TabIndex = 21;
            this.toolTip1.SetToolTip(this.trcOpacity, "Buradan formunuzun şeffaflığını ayarlayabilirsiniz.");
            this.trcOpacity.Value = 100;
            this.trcOpacity.Scroll += new System.EventHandler(this.trcOpacity_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbTaxExclude);
            this.groupBox2.Controls.Add(this.rdbTaxInclude);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cmbExpenseCategory);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.nudExpensePrice);
            this.groupBox2.Controls.Add(this.dtpExpenseDate);
            this.groupBox2.Controls.Add(this.txtExpenseName);
            this.groupBox2.Location = new System.Drawing.Point(313, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 340);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Harcama Ekle/Güncelle";
            // 
            // rdbTaxExclude
            // 
            this.rdbTaxExclude.AutoSize = true;
            this.rdbTaxExclude.Location = new System.Drawing.Point(115, 223);
            this.rdbTaxExclude.Name = "rdbTaxExclude";
            this.rdbTaxExclude.Size = new System.Drawing.Size(69, 21);
            this.rdbTaxExclude.TabIndex = 28;
            this.rdbTaxExclude.Text = "KDV\'siz";
            this.rdbTaxExclude.UseVisualStyleBackColor = true;
            // 
            // rdbTaxInclude
            // 
            this.rdbTaxInclude.AutoSize = true;
            this.rdbTaxInclude.Checked = true;
            this.rdbTaxInclude.Location = new System.Drawing.Point(23, 223);
            this.rdbTaxInclude.Name = "rdbTaxInclude";
            this.rdbTaxInclude.Size = new System.Drawing.Size(59, 21);
            this.rdbTaxInclude.TabIndex = 27;
            this.rdbTaxInclude.TabStop = true;
            this.rdbTaxInclude.Text = "KDV\'li";
            this.rdbTaxInclude.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Tutar: ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbExpenseCategory
            // 
            this.cmbExpenseCategory.FormattingEnabled = true;
            this.cmbExpenseCategory.Items.AddRange(new object[] {
            "Gıda",
            "Akaryakıt",
            "Kırtasiye",
            "Diğer"});
            this.cmbExpenseCategory.Location = new System.Drawing.Point(23, 99);
            this.cmbExpenseCategory.Name = "cmbExpenseCategory";
            this.cmbExpenseCategory.Size = new System.Drawing.Size(161, 24);
            this.cmbExpenseCategory.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Kategori :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Açıklama :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tarih :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Yer :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(23, 276);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(161, 49);
            this.txtDescription.TabIndex = 24;
            // 
            // nudExpensePrice
            // 
            this.nudExpensePrice.DecimalPlaces = 2;
            this.nudExpensePrice.Location = new System.Drawing.Point(23, 193);
            this.nudExpensePrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudExpensePrice.Name = "nudExpensePrice";
            this.nudExpensePrice.Size = new System.Drawing.Size(161, 24);
            this.nudExpensePrice.TabIndex = 23;
            this.nudExpensePrice.ThousandsSeparator = true;
            // 
            // dtpExpenseDate
            // 
            this.dtpExpenseDate.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dtpExpenseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpenseDate.Location = new System.Drawing.Point(23, 146);
            this.dtpExpenseDate.Name = "dtpExpenseDate";
            this.dtpExpenseDate.Size = new System.Drawing.Size(161, 24);
            this.dtpExpenseDate.TabIndex = 22;
            // 
            // txtExpenseName
            // 
            this.txtExpenseName.Location = new System.Drawing.Point(23, 52);
            this.txtExpenseName.Name = "txtExpenseName";
            this.txtExpenseName.Size = new System.Drawing.Size(161, 24);
            this.txtExpenseName.TabIndex = 21;
            this.toolTip1.SetToolTip(this.txtExpenseName, "Harcama yapılan yerin adını yazınız.");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Controls.Add(this.dtpEndDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(15, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 90);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarih Filtresi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Başlangıç Tar.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Checked = false;
            this.dtpStartDate.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(22, 54);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.ShowCheckBox = true;
            this.dtpStartDate.Size = new System.Drawing.Size(128, 24);
            this.dtpStartDate.TabIndex = 8;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Checked = false;
            this.dtpEndDate.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(168, 54);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.ShowCheckBox = true;
            this.dtpEndDate.Size = new System.Drawing.Size(128, 24);
            this.dtpEndDate.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bitiş Tar.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnDelExpense
            // 
            this.btnDelExpense.BackColor = System.Drawing.Color.Red;
            this.btnDelExpense.ForeColor = System.Drawing.Color.White;
            this.btnDelExpense.Location = new System.Drawing.Point(214, 470);
            this.btnDelExpense.Name = "btnDelExpense";
            this.btnDelExpense.Size = new System.Drawing.Size(75, 33);
            this.btnDelExpense.TabIndex = 18;
            this.btnDelExpense.Text = "Sil";
            this.toolTip1.SetToolTip(this.btnDelExpense, "Bu düğme ile listeden seçilen harcamayı silebilirsiniz.");
            this.btnDelExpense.UseVisualStyleBackColor = false;
            // 
            // btnSaveExpense
            // 
            this.btnSaveExpense.Location = new System.Drawing.Point(341, 470);
            this.btnSaveExpense.Name = "btnSaveExpense";
            this.btnSaveExpense.Size = new System.Drawing.Size(75, 33);
            this.btnSaveExpense.TabIndex = 17;
            this.btnSaveExpense.Text = "Güncelle";
            this.btnSaveExpense.UseVisualStyleBackColor = true;
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Location = new System.Drawing.Point(422, 470);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(75, 33);
            this.btnAddExpense.TabIndex = 16;
            this.btnAddExpense.Text = "Yeni Ekle";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Harcamalar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lstExpenses
            // 
            this.lstExpenses.FormattingEnabled = true;
            this.lstExpenses.ItemHeight = 16;
            this.lstExpenses.Location = new System.Drawing.Point(15, 124);
            this.lstExpenses.Name = "lstExpenses";
            this.lstExpenses.Size = new System.Drawing.Size(274, 340);
            this.lstExpenses.TabIndex = 0;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Bilgi";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.toolStripMenuItem2,
            this.mnuCloseApp});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.açToolStripMenuItem.Text = "Aç";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(107, 6);
            // 
            // mnuCloseApp
            // 
            this.mnuCloseApp.Name = "mnuCloseApp";
            this.mnuCloseApp.Size = new System.Drawing.Size(110, 22);
            this.mnuCloseApp.Text = "Çıkış";
            this.mnuCloseApp.Click += new System.EventHandler(this.mnuCloseApp_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.toolStripMenuItem3,
            this.yapıştırToolStripMenuItem,
            this.toolStripMenuItem4,
            this.çalışanYönetimiToolStripMenuItem});
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.kesToolStripMenuItem.Text = "Kes";
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(159, 6);
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(159, 6);
            // 
            // çalışanYönetimiToolStripMenuItem
            // 
            this.çalışanYönetimiToolStripMenuItem.Name = "çalışanYönetimiToolStripMenuItem";
            this.çalışanYönetimiToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.çalışanYönetimiToolStripMenuItem.Text = "Çalışan Yönetimi";
            this.çalışanYönetimiToolStripMenuItem.Click += new System.EventHandler(this.btnUserManage_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 568);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(797, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(167, 17);
            this.toolStripStatusLabel1.Text = "Harcama Yönetim Uygulaması";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(797, 25);
            this.toolStrip1.TabIndex = 13;
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
            // btnUserManage
            // 
            this.btnUserManage.Image = global::WindowsFormsApp1.Properties.Resources.cog_16;
            this.btnUserManage.Location = new System.Drawing.Point(220, 43);
            this.btnUserManage.Name = "btnUserManage";
            this.btnUserManage.Size = new System.Drawing.Size(34, 24);
            this.btnUserManage.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnUserManage, "Bu düğme ile çalışanları düzenleyebilirsiniz.");
            this.btnUserManage.UseVisualStyleBackColor = true;
            this.btnUserManage.Click += new System.EventHandler(this.btnUserManage_Click);
            // 
            // btnDelCategory
            // 
            this.btnDelCategory.BackColor = System.Drawing.Color.Red;
            this.btnDelCategory.ForeColor = System.Drawing.Color.White;
            this.btnDelCategory.Image = global::WindowsFormsApp1.Properties.Resources.trash_w_16;
            this.btnDelCategory.Location = new System.Drawing.Point(17, 470);
            this.btnDelCategory.Name = "btnDelCategory";
            this.btnDelCategory.Size = new System.Drawing.Size(60, 33);
            this.btnDelCategory.TabIndex = 6;
            this.btnDelCategory.Text = "Sil";
            this.btnDelCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelCategory.UseVisualStyleBackColor = false;
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.Image = global::WindowsFormsApp1.Properties.Resources.save_16;
            this.btnSaveCategory.Location = new System.Drawing.Point(83, 470);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(79, 33);
            this.btnSaveCategory.TabIndex = 5;
            this.btnSaveCategory.Text = "Kaydet";
            this.btnSaveCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Image = global::WindowsFormsApp1.Properties.Resources.plus_16;
            this.btnAddCategory.Location = new System.Drawing.Point(168, 470);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(86, 33);
            this.btnAddCategory.TabIndex = 4;
            this.btnAddCategory.Text = "Yeni Ekle";
            this.btnAddCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.money;
            this.pictureBox1.Location = new System.Drawing.Point(355, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRestartApp,
            this.btnCloseApp});
            this.toolStripDropDownButton1.Image = global::WindowsFormsApp1.Properties.Resources.close2_16;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // btnRestartApp
            // 
            this.btnRestartApp.Image = global::WindowsFormsApp1.Properties.Resources.sync_16;
            this.btnRestartApp.Name = "btnRestartApp";
            this.btnRestartApp.Size = new System.Drawing.Size(150, 22);
            this.btnRestartApp.Text = "Yeniden Başlat";
            this.btnRestartApp.Click += new System.EventHandler(this.btnRestartApp_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Image = global::WindowsFormsApp1.Properties.Resources.close_16;
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(150, 22);
            this.btnCloseApp.Text = "Kapat";
            this.btnCloseApp.Click += new System.EventHandler(this.mnuCloseApp_Click);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.info_16;
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 590);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Harcama Yönetim Uygulaması";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trcOpacity)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpensePrice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnDelCategory;
        private System.Windows.Forms.Button btnSaveCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstExpenses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnDelExpense;
        private System.Windows.Forms.Button btnSaveExpense;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbExpenseCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.NumericUpDown nudExpensePrice;
        private System.Windows.Forms.DateTimePicker dtpExpenseDate;
        private System.Windows.Forms.TextBox txtExpenseName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTaxExclude;
        private System.Windows.Forms.RadioButton rdbTaxInclude;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TrackBar trcOpacity;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseApp;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.Button btnUserManage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btnRestartApp;
        private System.Windows.Forms.ToolStripMenuItem btnCloseApp;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem çalışanYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
    }
}

