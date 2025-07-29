namespace Library_Management_System.UI.UserControls
{
    partial class UserControl_Book
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BT_return = new System.Windows.Forms.Button();
            this.LBL_title = new System.Windows.Forms.Label();
            this.TXT_title = new System.Windows.Forms.TextBox();
            this.TXT_Aut = new System.Windows.Forms.TextBox();
            this.LBL_author = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BT_return
            // 
            this.BT_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_return.Location = new System.Drawing.Point(17, 314);
            this.BT_return.Name = "BT_return";
            this.BT_return.Size = new System.Drawing.Size(318, 38);
            this.BT_return.TabIndex = 1;
            this.BT_return.Text = "Add New Book";
            this.BT_return.UseVisualStyleBackColor = true;
            this.BT_return.Click += new System.EventHandler(this.BT_return_Click);
            // 
            // LBL_title
            // 
            this.LBL_title.AutoSize = true;
            this.LBL_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_title.Location = new System.Drawing.Point(18, 25);
            this.LBL_title.Name = "LBL_title";
            this.LBL_title.Size = new System.Drawing.Size(111, 20);
            this.LBL_title.TabIndex = 2;
            this.LBL_title.Text = "Book Name :";
            // 
            // TXT_title
            // 
            this.TXT_title.Location = new System.Drawing.Point(148, 27);
            this.TXT_title.Name = "TXT_title";
            this.TXT_title.Size = new System.Drawing.Size(187, 20);
            this.TXT_title.TabIndex = 3;
            // 
            // TXT_Aut
            // 
            this.TXT_Aut.Location = new System.Drawing.Point(148, 76);
            this.TXT_Aut.Name = "TXT_Aut";
            this.TXT_Aut.Size = new System.Drawing.Size(187, 20);
            this.TXT_Aut.TabIndex = 5;
            // 
            // LBL_author
            // 
            this.LBL_author.AutoSize = true;
            this.LBL_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_author.Location = new System.Drawing.Point(18, 74);
            this.LBL_author.Name = "LBL_author";
            this.LBL_author.Size = new System.Drawing.Size(124, 20);
            this.LBL_author.TabIndex = 4;
            this.LBL_author.Text = "Author Name :";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(153, 178);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Available :";
            // 
            // TXT_TB
            // 
            this.TXT_TB.Location = new System.Drawing.Point(148, 125);
            this.TXT_TB.Name = "TXT_TB";
            this.TXT_TB.Size = new System.Drawing.Size(187, 20);
            this.TXT_TB.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Taken By :";
            // 
            // UserControl_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.TXT_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.TXT_Aut);
            this.Controls.Add(this.LBL_author);
            this.Controls.Add(this.TXT_title);
            this.Controls.Add(this.LBL_title);
            this.Controls.Add(this.BT_return);
            this.Name = "UserControl_Book";
            this.Size = new System.Drawing.Size(362, 369);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BT_return;
        private System.Windows.Forms.Label LBL_title;
        private System.Windows.Forms.TextBox TXT_title;
        private System.Windows.Forms.TextBox TXT_Aut;
        private System.Windows.Forms.Label LBL_author;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_TB;
        private System.Windows.Forms.Label label2;
    }
}
