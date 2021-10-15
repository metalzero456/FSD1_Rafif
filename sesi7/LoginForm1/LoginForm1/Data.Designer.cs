
namespace LoginForm1
{
    partial class Data
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
            this.dgv_userInfo = new System.Windows.Forms.DataGridView();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_editPassword = new System.Windows.Forms.TextBox();
            this.tb_editUsername = new System.Windows.Forms.TextBox();
            this.tb_editName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_searchId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_userInfo
            // 
            this.dgv_userInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_userInfo.Location = new System.Drawing.Point(12, 225);
            this.dgv_userInfo.Name = "dgv_userInfo";
            this.dgv_userInfo.Size = new System.Drawing.Size(571, 213);
            this.dgv_userInfo.TabIndex = 0;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(94, 104);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(141, 20);
            this.tb_name.TabIndex = 1;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(94, 130);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(141, 20);
            this.tb_username.TabIndex = 2;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(94, 156);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(141, 20);
            this.tb_password.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(12, 196);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 7;
            this.btn_insert.Text = "Insert Data";
            this.btn_insert.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(280, 198);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 14;
            this.btn_edit.Text = "Edit Data";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Name";
            // 
            // tb_editPassword
            // 
            this.tb_editPassword.Location = new System.Drawing.Point(362, 158);
            this.tb_editPassword.Name = "tb_editPassword";
            this.tb_editPassword.Size = new System.Drawing.Size(141, 20);
            this.tb_editPassword.TabIndex = 10;
            // 
            // tb_editUsername
            // 
            this.tb_editUsername.Location = new System.Drawing.Point(362, 132);
            this.tb_editUsername.Name = "tb_editUsername";
            this.tb_editUsername.Size = new System.Drawing.Size(141, 20);
            this.tb_editUsername.TabIndex = 9;
            // 
            // tb_editName
            // 
            this.tb_editName.Location = new System.Drawing.Point(362, 106);
            this.tb_editName.Name = "tb_editName";
            this.tb_editName.Size = new System.Drawing.Size(141, 20);
            this.tb_editName.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "ID";
            // 
            // tb_searchId
            // 
            this.tb_searchId.Location = new System.Drawing.Point(362, 80);
            this.tb_searchId.Name = "tb_searchId";
            this.tb_searchId.Size = new System.Drawing.Size(141, 20);
            this.tb_searchId.TabIndex = 15;
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_searchId);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_editPassword);
            this.Controls.Add(this.tb_editUsername);
            this.Controls.Add(this.tb_editName);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.dgv_userInfo);
            this.Name = "Data";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_userInfo;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_editPassword;
        private System.Windows.Forms.TextBox tb_editUsername;
        private System.Windows.Forms.TextBox tb_editName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_searchId;
    }
}