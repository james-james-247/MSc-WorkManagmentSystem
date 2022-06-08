
namespace N0817034_SoftEng2_Project
{
    partial class userHome
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Feature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Done = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.projectCombo = new System.Windows.Forms.ComboBox();
            this.projectLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.newFeatureBox = new System.Windows.Forms.GroupBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.featureNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comBox = new System.Windows.Forms.TextBox();
            this.featureName = new System.Windows.Forms.TextBox();
            this.featureGroupBox = new System.Windows.Forms.GroupBox();
            this.featureCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.commentBoxChange = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.newFeatureBox.SuspendLayout();
            this.featureGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Feature,
            this.Done,
            this.Comments});
            this.dataGrid.Location = new System.Drawing.Point(0, 144);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 62;
            this.dataGrid.RowTemplate.Height = 28;
            this.dataGrid.Size = new System.Drawing.Size(817, 317);
            this.dataGrid.TabIndex = 0;
            // 
            // Feature
            // 
            this.Feature.HeaderText = "Feature";
            this.Feature.MinimumWidth = 8;
            this.Feature.Name = "Feature";
            this.Feature.ReadOnly = true;
            this.Feature.Width = 150;
            // 
            // Done
            // 
            this.Done.HeaderText = "Done?";
            this.Done.Name = "Done";
            this.Done.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Done.Width = 200;
            // 
            // Comments
            // 
            this.Comments.HeaderText = "Comments";
            this.Comments.MinimumWidth = 8;
            this.Comments.Name = "Comments";
            this.Comments.Width = 350;
            // 
            // commentBox
            // 
            this.commentBox.Enabled = false;
            this.commentBox.Location = new System.Drawing.Point(289, 11);
            this.commentBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.commentBox.Multiline = true;
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(528, 126);
            this.commentBox.TabIndex = 1;
            this.commentBox.Text = "Comments on this project: ";
            // 
            // projectCombo
            // 
            this.projectCombo.FormattingEnabled = true;
            this.projectCombo.Location = new System.Drawing.Point(10, 116);
            this.projectCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.projectCombo.Name = "projectCombo";
            this.projectCombo.Size = new System.Drawing.Size(275, 21);
            this.projectCombo.TabIndex = 2;
            this.projectCombo.SelectedIndexChanged += new System.EventHandler(this.projectCombo_SelectedIndexChanged);
            // 
            // projectLabel
            // 
            this.projectLabel.AutoSize = true;
            this.projectLabel.Location = new System.Drawing.Point(7, 101);
            this.projectLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(136, 13);
            this.projectLabel.TabIndex = 3;
            this.projectLabel.Text = "Select one of your projects:";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(89, 23);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "<- Log Out";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // newFeatureBox
            // 
            this.newFeatureBox.Controls.Add(this.confirmButton);
            this.newFeatureBox.Controls.Add(this.featureNameLabel);
            this.newFeatureBox.Controls.Add(this.label2);
            this.newFeatureBox.Controls.Add(this.comBox);
            this.newFeatureBox.Controls.Add(this.featureName);
            this.newFeatureBox.Enabled = false;
            this.newFeatureBox.Location = new System.Drawing.Point(839, 8);
            this.newFeatureBox.Name = "newFeatureBox";
            this.newFeatureBox.Size = new System.Drawing.Size(405, 228);
            this.newFeatureBox.TabIndex = 8;
            this.newFeatureBox.TabStop = false;
            this.newFeatureBox.Text = "Add a New Feature to Current Project";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(48, 159);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(326, 23);
            this.confirmButton.TabIndex = 12;
            this.confirmButton.Text = "Add Feature";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // featureNameLabel
            // 
            this.featureNameLabel.AutoSize = true;
            this.featureNameLabel.Location = new System.Drawing.Point(47, 44);
            this.featureNameLabel.Name = "featureNameLabel";
            this.featureNameLabel.Size = new System.Drawing.Size(94, 13);
            this.featureNameLabel.TabIndex = 17;
            this.featureNameLabel.Text = "Add feature name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Add Comment: (Leave \'Not Completed\' if no comment)";
            // 
            // comBox
            // 
            this.comBox.Location = new System.Drawing.Point(50, 117);
            this.comBox.Name = "comBox";
            this.comBox.Size = new System.Drawing.Size(323, 20);
            this.comBox.TabIndex = 15;
            this.comBox.Text = "Not Completed";
            // 
            // featureName
            // 
            this.featureName.Location = new System.Drawing.Point(48, 59);
            this.featureName.Name = "featureName";
            this.featureName.Size = new System.Drawing.Size(325, 20);
            this.featureName.TabIndex = 14;
            // 
            // featureGroupBox
            // 
            this.featureGroupBox.Controls.Add(this.changeButton);
            this.featureGroupBox.Controls.Add(this.label3);
            this.featureGroupBox.Controls.Add(this.commentBoxChange);
            this.featureGroupBox.Controls.Add(this.featureCombo);
            this.featureGroupBox.Controls.Add(this.label4);
            this.featureGroupBox.Location = new System.Drawing.Point(839, 253);
            this.featureGroupBox.Name = "featureGroupBox";
            this.featureGroupBox.Size = new System.Drawing.Size(405, 208);
            this.featureGroupBox.TabIndex = 18;
            this.featureGroupBox.TabStop = false;
            this.featureGroupBox.Text = "Change Status of a Feature";
            // 
            // featureCombo
            // 
            this.featureCombo.Enabled = false;
            this.featureCombo.FormattingEnabled = true;
            this.featureCombo.Location = new System.Drawing.Point(50, 46);
            this.featureCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.featureCombo.Name = "featureCombo";
            this.featureCombo.Size = new System.Drawing.Size(323, 21);
            this.featureCombo.TabIndex = 12;
            this.featureCombo.SelectedIndexChanged += new System.EventHandler(this.featureCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Select Feature From Above Project:";
            // 
            // commentBoxChange
            // 
            this.commentBoxChange.Enabled = false;
            this.commentBoxChange.Location = new System.Drawing.Point(48, 106);
            this.commentBoxChange.Margin = new System.Windows.Forms.Padding(2);
            this.commentBoxChange.Multiline = true;
            this.commentBoxChange.Name = "commentBoxChange";
            this.commentBoxChange.Size = new System.Drawing.Size(326, 35);
            this.commentBoxChange.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Add Closing comment:";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(47, 163);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(326, 23);
            this.changeButton.TabIndex = 18;
            this.changeButton.Text = "Change Status";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // userHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1258, 470);
            this.Controls.Add(this.featureGroupBox);
            this.Controls.Add(this.newFeatureBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.projectLabel);
            this.Controls.Add(this.projectCombo);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.dataGrid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "userHome";
            this.Text = "Homepage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.newFeatureBox.ResumeLayout(false);
            this.newFeatureBox.PerformLayout();
            this.featureGroupBox.ResumeLayout(false);
            this.featureGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox commentBox;
        private System.Windows.Forms.ComboBox projectCombo;
        private System.Windows.Forms.Label projectLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox newFeatureBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label featureNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox comBox;
        private System.Windows.Forms.TextBox featureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Feature;
        private System.Windows.Forms.DataGridViewTextBoxColumn Done;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.GroupBox featureGroupBox;
        private System.Windows.Forms.ComboBox featureCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox commentBoxChange;
        private System.Windows.Forms.Button changeButton;
    }
}