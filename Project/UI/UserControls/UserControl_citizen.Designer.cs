namespace Library_Management_System.UI.UserControls
{
    partial class UserControl_citizen
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
            this.TXT_ID = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.TXT_SN = new System.Windows.Forms.TextBox();
            this.LBL_name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_c = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_p = new System.Windows.Forms.Label();
            this.BT = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl_b = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXT_ID
            // 
            this.TXT_ID.Location = new System.Drawing.Point(159, 75);
            this.TXT_ID.Name = "TXT_ID";
            this.TXT_ID.Size = new System.Drawing.Size(187, 20);
            this.TXT_ID.TabIndex = 17;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(19, 75);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(38, 20);
            this.lbl_id.TabIndex = 16;
            this.lbl_id.Text = "ID :";
            // 
            // TXT_SN
            // 
            this.TXT_SN.Location = new System.Drawing.Point(159, 22);
            this.TXT_SN.Name = "TXT_SN";
            this.TXT_SN.Size = new System.Drawing.Size(187, 20);
            this.TXT_SN.TabIndex = 15;
            // 
            // LBL_name
            // 
            this.LBL_name.AutoSize = true;
            this.LBL_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_name.Location = new System.Drawing.Point(19, 22);
            this.LBL_name.Name = "LBL_name";
            this.LBL_name.Size = new System.Drawing.Size(65, 20);
            this.LBL_name.TabIndex = 14;
            this.LBL_name.Text = "Name :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 21;
            // 
            // lbl_c
            // 
            this.lbl_c.AutoSize = true;
            this.lbl_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_c.Location = new System.Drawing.Point(19, 177);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(49, 20);
            this.lbl_c.TabIndex = 20;
            this.lbl_c.Text = "City :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(159, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 20);
            this.textBox2.TabIndex = 19;
            // 
            // lbl_p
            // 
            this.lbl_p.AutoSize = true;
            this.lbl_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p.Location = new System.Drawing.Point(19, 124);
            this.lbl_p.Name = "lbl_p";
            this.lbl_p.Size = new System.Drawing.Size(137, 20);
            this.lbl_p.TabIndex = 18;
            this.lbl_p.Text = "Phone Number :";
            // 
            // BT
            // 
            this.BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT.Location = new System.Drawing.Point(23, 309);
            this.BT.Name = "BT";
            this.BT.Size = new System.Drawing.Size(318, 38);
            this.BT.TabIndex = 22;
            this.BT.Text = "Add New Member";
            this.BT.UseVisualStyleBackColor = true;
            this.BT.Click += new System.EventHandler(this.BT_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(159, 228);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(187, 20);
            this.textBox3.TabIndex = 24;
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_b.Location = new System.Drawing.Point(19, 228);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(114, 20);
            this.lbl_b.TabIndex = 23;
            this.lbl_b.Text = "Book Taken :";
            // 
            // UserControl_citizen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lbl_b);
            this.Controls.Add(this.BT);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_c);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_p);
            this.Controls.Add(this.TXT_ID);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.TXT_SN);
            this.Controls.Add(this.LBL_name);
            this.Name = "UserControl_citizen";
            this.Size = new System.Drawing.Size(362, 369);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_ID;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox TXT_SN;
        private System.Windows.Forms.Label LBL_name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_c;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_p;
        private System.Windows.Forms.Button BT;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbl_b;
    }
}
