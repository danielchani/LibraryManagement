namespace Library_Management_System.UI.UserControls
{
    partial class UserControl_Employee
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
            this.BT_Borrow = new System.Windows.Forms.Button();
            this.TXT_EID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_ES = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_ESID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_EN = new System.Windows.Forms.TextBox();
            this.LBL_Name = new System.Windows.Forms.Label();
            this.textBook = new System.Windows.Forms.TextBox();
            this.lblBook = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BT_Borrow
            // 
            this.BT_Borrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Borrow.Location = new System.Drawing.Point(20, 298);
            this.BT_Borrow.Name = "BT_Borrow";
            this.BT_Borrow.Size = new System.Drawing.Size(323, 38);
            this.BT_Borrow.TabIndex = 23;
            this.BT_Borrow.Text = "Add Employee";
            this.BT_Borrow.UseVisualStyleBackColor = true;
            this.BT_Borrow.Click += new System.EventHandler(this.BT_Borrow_Click);
            // 
            // TXT_EID
            // 
            this.TXT_EID.Location = new System.Drawing.Point(156, 54);
            this.TXT_EID.Name = "TXT_EID";
            this.TXT_EID.Size = new System.Drawing.Size(187, 20);
            this.TXT_EID.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "ID :";
            // 
            // TXT_ES
            // 
            this.TXT_ES.Location = new System.Drawing.Point(156, 170);
            this.TXT_ES.Name = "TXT_ES";
            this.TXT_ES.Size = new System.Drawing.Size(187, 20);
            this.TXT_ES.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Section :";
            // 
            // TXT_ESID
            // 
            this.TXT_ESID.Location = new System.Drawing.Point(156, 91);
            this.TXT_ESID.Name = "TXT_ESID";
            this.TXT_ESID.Size = new System.Drawing.Size(187, 20);
            this.TXT_ESID.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Employee ID :";
            // 
            // TXT_EN
            // 
            this.TXT_EN.Location = new System.Drawing.Point(156, 19);
            this.TXT_EN.Name = "TXT_EN";
            this.TXT_EN.Size = new System.Drawing.Size(187, 20);
            this.TXT_EN.TabIndex = 16;
            // 
            // LBL_Name
            // 
            this.LBL_Name.AutoSize = true;
            this.LBL_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Name.Location = new System.Drawing.Point(16, 19);
            this.LBL_Name.Name = "LBL_Name";
            this.LBL_Name.Size = new System.Drawing.Size(65, 20);
            this.LBL_Name.TabIndex = 15;
            this.LBL_Name.Text = "Name :";
            // 
            // textBook
            // 
            this.textBook.Location = new System.Drawing.Point(156, 212);
            this.textBook.Name = "textBook";
            this.textBook.Size = new System.Drawing.Size(187, 20);
            this.textBook.TabIndex = 25;
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook.Location = new System.Drawing.Point(16, 212);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(114, 20);
            this.lblBook.TabIndex = 24;
            this.lblBook.Text = "Book Taken :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 251);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 20);
            this.textBox2.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Phone Number :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(156, 129);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(187, 20);
            this.textBox3.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "City :";
            // 
            // UserControl_Faculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBook);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.BT_Borrow);
            this.Controls.Add(this.TXT_EID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXT_ES);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT_ESID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_EN);
            this.Controls.Add(this.LBL_Name);
            this.Name = "UserControl_Faculty";
            this.Size = new System.Drawing.Size(362, 369);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Borrow;
        private System.Windows.Forms.TextBox TXT_EID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_ES;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_ESID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_EN;
        private System.Windows.Forms.Label LBL_Name;
        private System.Windows.Forms.TextBox textBook;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
    }
}
