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
            this.btnTuple = new System.Windows.Forms.Button();
            this.btnShowMyMessageBox = new System.Windows.Forms.Button();
            this.btnShowSozlesme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTuple
            // 
            this.btnTuple.Location = new System.Drawing.Point(16, 15);
            this.btnTuple.Margin = new System.Windows.Forms.Padding(4);
            this.btnTuple.Name = "btnTuple";
            this.btnTuple.Size = new System.Drawing.Size(213, 69);
            this.btnTuple.TabIndex = 0;
            this.btnTuple.Text = "Tuple";
            this.btnTuple.UseVisualStyleBackColor = true;
            this.btnTuple.Click += new System.EventHandler(this.btnTuple_Click);
            // 
            // btnShowMyMessageBox
            // 
            this.btnShowMyMessageBox.Location = new System.Drawing.Point(16, 103);
            this.btnShowMyMessageBox.Name = "btnShowMyMessageBox";
            this.btnShowMyMessageBox.Size = new System.Drawing.Size(213, 67);
            this.btnShowMyMessageBox.TabIndex = 1;
            this.btnShowMyMessageBox.Text = "Show MyMessageBox";
            this.btnShowMyMessageBox.UseVisualStyleBackColor = true;
            this.btnShowMyMessageBox.Click += new System.EventHandler(this.btnShowMyMessageBox_Click);
            // 
            // btnShowSozlesme
            // 
            this.btnShowSozlesme.Location = new System.Drawing.Point(16, 189);
            this.btnShowSozlesme.Name = "btnShowSozlesme";
            this.btnShowSozlesme.Size = new System.Drawing.Size(213, 45);
            this.btnShowSozlesme.TabIndex = 2;
            this.btnShowSozlesme.Text = "Sözleşme Göster";
            this.btnShowSozlesme.UseVisualStyleBackColor = true;
            this.btnShowSozlesme.Click += new System.EventHandler(this.btnShowSozlesme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 415);
            this.Controls.Add(this.btnShowSozlesme);
            this.Controls.Add(this.btnShowMyMessageBox);
            this.Controls.Add(this.btnTuple);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTuple;
        private System.Windows.Forms.Button btnShowMyMessageBox;
        private System.Windows.Forms.Button btnShowSozlesme;
    }
}

