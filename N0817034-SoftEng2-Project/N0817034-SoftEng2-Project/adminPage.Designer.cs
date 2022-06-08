
namespace N0817034_SoftEng2_Project
{
    partial class adminPage
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
            this.adminNewProject = new System.Windows.Forms.Button();
            this.projectSelector = new System.Windows.Forms.ComboBox();
            this.selectorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.commentbox = new System.Windows.Forms.TextBox();
            this.commentButton = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.Feature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.newUser = new System.Windows.Forms.Button();
            this.timelineButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // adminNewProject
            // 
            this.adminNewProject.Location = new System.Drawing.Point(290, 12);
            this.adminNewProject.Name = "adminNewProject";
            this.adminNewProject.Size = new System.Drawing.Size(177, 23);
            this.adminNewProject.TabIndex = 0;
            this.adminNewProject.Text = "Create a new project ->";
            this.adminNewProject.UseVisualStyleBackColor = true;
            this.adminNewProject.Click += new System.EventHandler(this.adminNewProject_Click);
            // 
            // projectSelector
            // 
            this.projectSelector.FormattingEnabled = true;
            this.projectSelector.Location = new System.Drawing.Point(12, 80);
            this.projectSelector.Name = "projectSelector";
            this.projectSelector.Size = new System.Drawing.Size(231, 21);
            this.projectSelector.TabIndex = 1;
            this.projectSelector.SelectedIndexChanged += new System.EventHandler(this.projectSelector_SelectedIndexChanged);
            // 
            // selectorLabel
            // 
            this.selectorLabel.AutoSize = true;
            this.selectorLabel.Location = new System.Drawing.Point(9, 64);
            this.selectorLabel.Name = "selectorLabel";
            this.selectorLabel.Size = new System.Drawing.Size(162, 13);
            this.selectorLabel.TabIndex = 2;
            this.selectorLabel.Text = "Select an active project to view: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add a comment for this project:";
            // 
            // commentbox
            // 
            this.commentbox.Enabled = false;
            this.commentbox.Location = new System.Drawing.Point(539, 137);
            this.commentbox.Multiline = true;
            this.commentbox.Name = "commentbox";
            this.commentbox.Size = new System.Drawing.Size(231, 190);
            this.commentbox.TabIndex = 4;
            // 
            // commentButton
            // 
            this.commentButton.Enabled = false;
            this.commentButton.Location = new System.Drawing.Point(539, 343);
            this.commentButton.Name = "commentButton";
            this.commentButton.Size = new System.Drawing.Size(231, 34);
            this.commentButton.TabIndex = 5;
            this.commentButton.Text = "Add Coment";
            this.commentButton.UseVisualStyleBackColor = true;
            this.commentButton.Click += new System.EventHandler(this.commentButton_Click);
            // 
            // table
            // 
            this.table.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Feature,
            this.Compeleted,
            this.Comments});
            this.table.Location = new System.Drawing.Point(12, 119);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(494, 327);
            this.table.TabIndex = 6;
            // 
            // Feature
            // 
            this.Feature.HeaderText = "Feature";
            this.Feature.Name = "Feature";
            this.Feature.Width = 150;
            // 
            // Compeleted
            // 
            this.Compeleted.HeaderText = "Completed?";
            this.Compeleted.Name = "Compeleted";
            this.Compeleted.Width = 150;
            // 
            // Comments
            // 
            this.Comments.HeaderText = "Comments";
            this.Comments.Name = "Comments";
            this.Comments.Width = 150;
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(559, 397);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(191, 13);
            this.commentLabel.TabIndex = 7;
            this.commentLabel.Text = "Check This Projects Comment Timeline";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(89, 23);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "<- Log Out";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // newUser
            // 
            this.newUser.Location = new System.Drawing.Point(107, 12);
            this.newUser.Name = "newUser";
            this.newUser.Size = new System.Drawing.Size(177, 23);
            this.newUser.TabIndex = 10;
            this.newUser.Text = "Add New User or Edit Current ->";
            this.newUser.UseVisualStyleBackColor = true;
            this.newUser.Click += new System.EventHandler(this.newUser_Click);
            // 
            // timelineButton
            // 
            this.timelineButton.Enabled = false;
            this.timelineButton.Location = new System.Drawing.Point(539, 413);
            this.timelineButton.Name = "timelineButton";
            this.timelineButton.Size = new System.Drawing.Size(231, 34);
            this.timelineButton.TabIndex = 11;
            this.timelineButton.Text = "Timeline";
            this.timelineButton.UseVisualStyleBackColor = true;
            this.timelineButton.Click += new System.EventHandler(this.timelineButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(249, 78);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(257, 23);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Close This Project";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // adminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 456);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.timelineButton);
            this.Controls.Add(this.newUser);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.table);
            this.Controls.Add(this.commentButton);
            this.Controls.Add(this.commentbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectorLabel);
            this.Controls.Add(this.projectSelector);
            this.Controls.Add(this.adminNewProject);
            this.Name = "adminPage";
            this.Text = "Admin Console";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adminNewProject;
        private System.Windows.Forms.ComboBox projectSelector;
        private System.Windows.Forms.Label selectorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox commentbox;
        private System.Windows.Forms.Button commentButton;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Feature;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compeleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button newUser;
        private System.Windows.Forms.Button timelineButton;
        private System.Windows.Forms.Button deleteButton;
    }
}