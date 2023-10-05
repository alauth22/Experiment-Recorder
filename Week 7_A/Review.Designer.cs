
namespace Week_7_A
{
    partial class Review
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
            this.lblReviewSummary = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblReviewSummary
            // 
            this.lblReviewSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReviewSummary.Location = new System.Drawing.Point(59, 38);
            this.lblReviewSummary.Name = "lblReviewSummary";
            this.lblReviewSummary.Size = new System.Drawing.Size(289, 190);
            this.lblReviewSummary.TabIndex = 2;
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(56, 25);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(147, 13);
            this.lblSummary.TabIndex = 1;
            this.lblSummary.Text = "Experiment Review Summary:";
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(415, 296);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.lblReviewSummary);
            this.Name = "Review";
            this.Text = "Review";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblReviewSummary;
        private System.Windows.Forms.Label lblSummary;
    }
}