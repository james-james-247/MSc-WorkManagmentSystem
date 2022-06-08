
namespace N0817034_SoftEng2_Project
{
    partial class adminCreate
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.detailsButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.groupLabel = new System.Windows.Forms.Label();
            this.groupSelector = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.completeButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.featureNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.featureName = new System.Windows.Forms.TextBox();
            this.featureLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(116, 44);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(157, 20);
            this.nameBox.TabIndex = 0;
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(116, 70);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(350, 29);
            this.detailsButton.TabIndex = 1;
            this.detailsButton.Text = "Confirm Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(116, 28);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(71, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Project Name";
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(276, 28);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(121, 13);
            this.groupLabel.TabIndex = 3;
            this.groupLabel.Text = "Project Group Allocation";
            // 
            // groupSelector
            // 
            this.groupSelector.FormattingEnabled = true;
            this.groupSelector.Location = new System.Drawing.Point(279, 44);
            this.groupSelector.Name = "groupSelector";
            this.groupSelector.Size = new System.Drawing.Size(187, 21);
            this.groupSelector.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.completeButton);
            this.groupBox1.Controls.Add(this.confirmButton);
            this.groupBox1.Controls.Add(this.featureNameLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.commentBox);
            this.groupBox1.Controls.Add(this.featureName);
            this.groupBox1.Controls.Add(this.featureLabel);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(119, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 309);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "More details";
            // 
            // completeButton
            // 
            this.completeButton.Location = new System.Drawing.Point(6, 267);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(326, 23);
            this.completeButton.TabIndex = 11;
            this.completeButton.Text = "Complete";
            this.completeButton.UseVisualStyleBackColor = true;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(6, 238);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(326, 23);
            this.confirmButton.TabIndex = 6;
            this.confirmButton.Text = "Add Feature";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // featureNameLabel
            // 
            this.featureNameLabel.AutoSize = true;
            this.featureNameLabel.Location = new System.Drawing.Point(5, 90);
            this.featureNameLabel.Name = "featureNameLabel";
            this.featureNameLabel.Size = new System.Drawing.Size(91, 13);
            this.featureNameLabel.TabIndex = 10;
            this.featureNameLabel.Text = "Add feature name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add Comment (Leave \'Not Completed\' if no comment)";
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(9, 188);
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(323, 20);
            this.commentBox.TabIndex = 8;
            this.commentBox.Text = "Not Completed";
            // 
            // featureName
            // 
            this.featureName.Location = new System.Drawing.Point(6, 106);
            this.featureName.Name = "featureName";
            this.featureName.Size = new System.Drawing.Size(326, 20);
            this.featureName.TabIndex = 7;
            // 
            // featureLabel
            // 
            this.featureLabel.AutoSize = true;
            this.featureLabel.Location = new System.Drawing.Point(69, 46);
            this.featureLabel.Name = "featureLabel";
            this.featureLabel.Size = new System.Drawing.Size(195, 13);
            this.featureLabel.TabIndex = 6;
            this.featureLabel.Text = "Add one at a time your required features";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(89, 23);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "<- Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // adminCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupSelector);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.nameBox);
            this.Name = "adminCreate";
            this.Text = "Create a New Project";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.ComboBox groupSelector;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label featureNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox commentBox;
        private System.Windows.Forms.TextBox featureName;
        private System.Windows.Forms.Label featureLabel;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.Button backButton;
    }
}