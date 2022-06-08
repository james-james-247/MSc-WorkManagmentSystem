
namespace N0817034_SoftEng2_Project
{
    partial class adminNewUser
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
            this.backButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.newUserGroup = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adminCombo = new System.Windows.Forms.ComboBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.createUserButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.changeDrop = new System.Windows.Forms.ComboBox();
            this.changalbeBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.changeCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.userCombo = new System.Windows.Forms.ComboBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.newUserGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(89, 23);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "<- Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // newUserGroup
            // 
            this.newUserGroup.Controls.Add(this.label4);
            this.newUserGroup.Controls.Add(this.label3);
            this.newUserGroup.Controls.Add(this.groupCombo);
            this.newUserGroup.Controls.Add(this.label2);
            this.newUserGroup.Controls.Add(this.label1);
            this.newUserGroup.Controls.Add(this.adminCombo);
            this.newUserGroup.Controls.Add(this.passwordBox);
            this.newUserGroup.Controls.Add(this.usernameBox);
            this.newUserGroup.Controls.Add(this.createUserButton);
            this.newUserGroup.Location = new System.Drawing.Point(126, 36);
            this.newUserGroup.Name = "newUserGroup";
            this.newUserGroup.Size = new System.Drawing.Size(304, 335);
            this.newUserGroup.TabIndex = 11;
            this.newUserGroup.TabStop = false;
            this.newUserGroup.Text = "Create New User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Is the User an Admin?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Developer Group";
            // 
            // groupCombo
            // 
            this.groupCombo.FormattingEnabled = true;
            this.groupCombo.Location = new System.Drawing.Point(18, 180);
            this.groupCombo.Name = "groupCombo";
            this.groupCombo.Size = new System.Drawing.Size(268, 21);
            this.groupCombo.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Username";
            // 
            // adminCombo
            // 
            this.adminCombo.FormattingEnabled = true;
            this.adminCombo.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.adminCombo.Location = new System.Drawing.Point(16, 245);
            this.adminCombo.Name = "adminCombo";
            this.adminCombo.Size = new System.Drawing.Size(270, 21);
            this.adminCombo.TabIndex = 15;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(18, 117);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(270, 20);
            this.passwordBox.TabIndex = 14;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(18, 55);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(270, 20);
            this.usernameBox.TabIndex = 13;
            // 
            // createUserButton
            // 
            this.createUserButton.Location = new System.Drawing.Point(6, 294);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(292, 30);
            this.createUserButton.TabIndex = 12;
            this.createUserButton.Text = "Create User";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.changeDrop);
            this.groupBox1.Controls.Add(this.changalbeBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.changeCombo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.userCombo);
            this.groupBox1.Controls.Add(this.changeButton);
            this.groupBox1.Location = new System.Drawing.Point(516, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 335);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Current User";
            // 
            // changeDrop
            // 
            this.changeDrop.FormattingEnabled = true;
            this.changeDrop.Location = new System.Drawing.Point(18, 203);
            this.changeDrop.Name = "changeDrop";
            this.changeDrop.Size = new System.Drawing.Size(267, 21);
            this.changeDrop.TabIndex = 19;
            this.changeDrop.Visible = false;
            // 
            // changalbeBox
            // 
            this.changalbeBox.Enabled = false;
            this.changalbeBox.Location = new System.Drawing.Point(18, 203);
            this.changalbeBox.Name = "changalbeBox";
            this.changalbeBox.Size = new System.Drawing.Size(267, 20);
            this.changalbeBox.TabIndex = 18;
            this.changalbeBox.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "What Would You Like to Change?";
            // 
            // changeCombo
            // 
            this.changeCombo.Enabled = false;
            this.changeCombo.FormattingEnabled = true;
            this.changeCombo.Items.AddRange(new object[] {
            "Group",
            "Username",
            "Password",
            "Admin Status"});
            this.changeCombo.Location = new System.Drawing.Point(18, 156);
            this.changeCombo.Name = "changeCombo";
            this.changeCombo.Size = new System.Drawing.Size(267, 21);
            this.changeCombo.TabIndex = 16;
            this.changeCombo.SelectedIndexChanged += new System.EventHandler(this.changeCombo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Select a User";
            // 
            // userCombo
            // 
            this.userCombo.FormattingEnabled = true;
            this.userCombo.Location = new System.Drawing.Point(18, 93);
            this.userCombo.Name = "userCombo";
            this.userCombo.Size = new System.Drawing.Size(267, 21);
            this.userCombo.TabIndex = 14;
            this.userCombo.SelectedIndexChanged += new System.EventHandler(this.userCombo_SelectedIndexChanged);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(6, 294);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(292, 30);
            this.changeButton.TabIndex = 12;
            this.changeButton.Text = "Change Details";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(462, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "OR";
            // 
            // adminNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 387);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.newUserGroup);
            this.Controls.Add(this.backButton);
            this.Name = "adminNewUser";
            this.Text = "Create New User";
            this.newUserGroup.ResumeLayout(false);
            this.newUserGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox newUserGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox groupCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox adminCombo;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox userCombo;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox changeCombo;
        private System.Windows.Forms.TextBox changalbeBox;
        private System.Windows.Forms.ComboBox changeDrop;
    }
}