
namespace PartApp
{
    partial class ProfileForm
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
            this.TextBox1Username = new System.Windows.Forms.TextBox();
            this.TextBox2Password = new System.Windows.Forms.TextBox();
            this.TextBox3FirstName = new System.Windows.Forms.TextBox();
            this.TextBox4LastName = new System.Windows.Forms.TextBox();
            this.TextBox5Email = new System.Windows.Forms.TextBox();
            this.TextBox6Phone = new System.Windows.Forms.TextBox();
            this.TextBox7Address = new System.Windows.Forms.TextBox();
            this.editInfo = new System.Windows.Forms.Button();
            this.partBtn = new System.Windows.Forms.Button();
            this.newAccButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.createNewUser = new System.Windows.Forms.Button();
            this.allUsersBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox1Username
            // 
            this.TextBox1Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox1Username.Location = new System.Drawing.Point(169, 44);
            this.TextBox1Username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox1Username.Multiline = true;
            this.TextBox1Username.Name = "TextBox1Username";
            this.TextBox1Username.ReadOnly = true;
            this.TextBox1Username.Size = new System.Drawing.Size(157, 30);
            this.TextBox1Username.TabIndex = 0;
            this.TextBox1Username.Enter += new System.EventHandler(this.usernameTextBox_Enter);
            // 
            // TextBox2Password
            // 
            this.TextBox2Password.Location = new System.Drawing.Point(169, 87);
            this.TextBox2Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox2Password.Multiline = true;
            this.TextBox2Password.Name = "TextBox2Password";
            this.TextBox2Password.PasswordChar = '*';
            this.TextBox2Password.ReadOnly = true;
            this.TextBox2Password.Size = new System.Drawing.Size(157, 30);
            this.TextBox2Password.TabIndex = 1;
            this.TextBox2Password.Enter += new System.EventHandler(this.usernameTextBox_Enter);
            // 
            // TextBox3FirstName
            // 
            this.TextBox3FirstName.Location = new System.Drawing.Point(169, 132);
            this.TextBox3FirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox3FirstName.Multiline = true;
            this.TextBox3FirstName.Name = "TextBox3FirstName";
            this.TextBox3FirstName.ReadOnly = true;
            this.TextBox3FirstName.Size = new System.Drawing.Size(157, 30);
            this.TextBox3FirstName.TabIndex = 2;
            this.TextBox3FirstName.Enter += new System.EventHandler(this.EnterInfo);
            this.TextBox3FirstName.Leave += new System.EventHandler(this.LeaveInfo);
            // 
            // TextBox4LastName
            // 
            this.TextBox4LastName.Location = new System.Drawing.Point(169, 175);
            this.TextBox4LastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox4LastName.Multiline = true;
            this.TextBox4LastName.Name = "TextBox4LastName";
            this.TextBox4LastName.ReadOnly = true;
            this.TextBox4LastName.Size = new System.Drawing.Size(157, 30);
            this.TextBox4LastName.TabIndex = 3;
            this.TextBox4LastName.Enter += new System.EventHandler(this.EnterInfo);
            this.TextBox4LastName.Leave += new System.EventHandler(this.LeaveInfo);
            // 
            // TextBox5Email
            // 
            this.TextBox5Email.Location = new System.Drawing.Point(169, 217);
            this.TextBox5Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox5Email.Multiline = true;
            this.TextBox5Email.Name = "TextBox5Email";
            this.TextBox5Email.ReadOnly = true;
            this.TextBox5Email.Size = new System.Drawing.Size(157, 30);
            this.TextBox5Email.TabIndex = 4;
            this.TextBox5Email.Enter += new System.EventHandler(this.EnterInfo);
            this.TextBox5Email.Leave += new System.EventHandler(this.LeaveInfo);
            // 
            // TextBox6Phone
            // 
            this.TextBox6Phone.Location = new System.Drawing.Point(169, 261);
            this.TextBox6Phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox6Phone.Multiline = true;
            this.TextBox6Phone.Name = "TextBox6Phone";
            this.TextBox6Phone.ReadOnly = true;
            this.TextBox6Phone.Size = new System.Drawing.Size(157, 30);
            this.TextBox6Phone.TabIndex = 5;
            this.TextBox6Phone.Enter += new System.EventHandler(this.EnterInfo);
            this.TextBox6Phone.Leave += new System.EventHandler(this.LeaveInfo);
            // 
            // TextBox7Address
            // 
            this.TextBox7Address.Location = new System.Drawing.Point(169, 304);
            this.TextBox7Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox7Address.Multiline = true;
            this.TextBox7Address.Name = "TextBox7Address";
            this.TextBox7Address.ReadOnly = true;
            this.TextBox7Address.Size = new System.Drawing.Size(157, 30);
            this.TextBox7Address.TabIndex = 7;
            this.TextBox7Address.Enter += new System.EventHandler(this.EnterInfo);
            this.TextBox7Address.Leave += new System.EventHandler(this.LeaveInfo);
            // 
            // editInfo
            // 
            this.editInfo.Location = new System.Drawing.Point(213, 354);
            this.editInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editInfo.Name = "editInfo";
            this.editInfo.Size = new System.Drawing.Size(92, 34);
            this.editInfo.TabIndex = 6;
            this.editInfo.Text = "Edit";
            this.editInfo.UseVisualStyleBackColor = true;
            this.editInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // partBtn
            // 
            this.partBtn.Location = new System.Drawing.Point(404, 383);
            this.partBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partBtn.Name = "partBtn";
            this.partBtn.Size = new System.Drawing.Size(96, 34);
            this.partBtn.TabIndex = 9;
            this.partBtn.Text = "Part Catalog";
            this.partBtn.UseVisualStyleBackColor = true;
            this.partBtn.Click += new System.EventHandler(this.partBtn_Click);
            // 
            // newAccButton
            // 
            this.newAccButton.Location = new System.Drawing.Point(404, 11);
            this.newAccButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newAccButton.Name = "newAccButton";
            this.newAccButton.Size = new System.Drawing.Size(96, 34);
            this.newAccButton.TabIndex = 10;
            this.newAccButton.Text = "New User";
            this.newAccButton.UseVisualStyleBackColor = true;
            this.newAccButton.Visible = false;
            this.newAccButton.Click += new System.EventHandler(this.newAccButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 265);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 308);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(165, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "You need to fill your info";
            this.label8.Visible = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(213, 354);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(92, 34);
            this.saveBtn.TabIndex = 19;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Visible = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // createNewUser
            // 
            this.createNewUser.Location = new System.Drawing.Point(404, 91);
            this.createNewUser.Name = "createNewUser";
            this.createNewUser.Size = new System.Drawing.Size(99, 34);
            this.createNewUser.TabIndex = 20;
            this.createNewUser.Text = "Create";
            this.createNewUser.UseVisualStyleBackColor = true;
            this.createNewUser.Visible = false;
            this.createNewUser.Click += new System.EventHandler(this.createNewUser_Click);
            // 
            // allUsersBtn
            // 
            this.allUsersBtn.Location = new System.Drawing.Point(404, 50);
            this.allUsersBtn.Name = "allUsersBtn";
            this.allUsersBtn.Size = new System.Drawing.Size(99, 34);
            this.allUsersBtn.TabIndex = 21;
            this.allUsersBtn.Text = "Users";
            this.allUsersBtn.UseVisualStyleBackColor = true;
            this.allUsersBtn.Visible = false;
            this.allUsersBtn.Click += new System.EventHandler(this.allUsersBtn_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 431);
            this.Controls.Add(this.allUsersBtn);
            this.Controls.Add(this.createNewUser);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newAccButton);
            this.Controls.Add(this.partBtn);
            this.Controls.Add(this.TextBox7Address);
            this.Controls.Add(this.editInfo);
            this.Controls.Add(this.TextBox6Phone);
            this.Controls.Add(this.TextBox5Email);
            this.Controls.Add(this.TextBox4LastName);
            this.Controls.Add(this.TextBox3FirstName);
            this.Controls.Add(this.TextBox2Password);
            this.Controls.Add(this.TextBox1Username);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProfileForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProfileForm_FormClosed);
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox1Username;
        private System.Windows.Forms.TextBox TextBox2Password;
        private System.Windows.Forms.TextBox TextBox3FirstName;
        private System.Windows.Forms.TextBox TextBox4LastName;
        private System.Windows.Forms.TextBox TextBox5Email;
        private System.Windows.Forms.TextBox TextBox6Phone;
        private System.Windows.Forms.TextBox TextBox7Address;
        private System.Windows.Forms.Button editInfo;
        private System.Windows.Forms.Button partBtn;
        private System.Windows.Forms.Button newAccButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button createNewUser;
        private System.Windows.Forms.Button allUsersBtn;
    }
}