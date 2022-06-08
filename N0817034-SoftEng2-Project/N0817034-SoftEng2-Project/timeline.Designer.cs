
namespace N0817034_SoftEng2_Project
{
    partial class timeline
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
            this.timelineTable = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.timelineTable)).BeginInit();
            this.SuspendLayout();
            // 
            // timelineTable
            // 
            this.timelineTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.timelineTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timelineTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Comment,
            this.commenter});
            this.timelineTable.Location = new System.Drawing.Point(-2, 1);
            this.timelineTable.Name = "timelineTable";
            this.timelineTable.Size = new System.Drawing.Size(743, 451);
            this.timelineTable.TabIndex = 7;
            // 
            // Time
            // 
            this.Time.HeaderText = "Comment Time";
            this.Time.Name = "Time";
            this.Time.Width = 200;
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            this.Comment.Width = 350;
            // 
            // commenter
            // 
            this.commenter.HeaderText = "Comment Made By";
            this.commenter.Name = "commenter";
            this.commenter.Width = 150;
            // 
            // timeline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.timelineTable);
            this.Name = "timeline";
            this.Text = "This Projects Timeline";
            ((System.ComponentModel.ISupportInitialize)(this.timelineTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView timelineTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn commenter;
    }
}