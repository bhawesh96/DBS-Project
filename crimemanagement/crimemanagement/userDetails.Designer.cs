namespace crimemanagement
{
    partial class userDetails
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
            this.LodgeComplaintButton = new System.Windows.Forms.Button();
            this.CheckChargesButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.detailsBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // LodgeComplaintButton
            // 
            this.LodgeComplaintButton.BackColor = System.Drawing.Color.SandyBrown;
            this.LodgeComplaintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LodgeComplaintButton.Location = new System.Drawing.Point(12, 199);
            this.LodgeComplaintButton.Name = "LodgeComplaintButton";
            this.LodgeComplaintButton.Size = new System.Drawing.Size(122, 53);
            this.LodgeComplaintButton.TabIndex = 0;
            this.LodgeComplaintButton.Text = "LODGE COMPLAINT";
            this.LodgeComplaintButton.UseVisualStyleBackColor = false;
            this.LodgeComplaintButton.Click += new System.EventHandler(this.LodgeComplaintButton_Click);
            // 
            // CheckChargesButton
            // 
            this.CheckChargesButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CheckChargesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckChargesButton.Location = new System.Drawing.Point(152, 198);
            this.CheckChargesButton.Name = "CheckChargesButton";
            this.CheckChargesButton.Size = new System.Drawing.Size(132, 54);
            this.CheckChargesButton.TabIndex = 1;
            this.CheckChargesButton.Text = "CHECK CHARGES";
            this.CheckChargesButton.UseVisualStyleBackColor = false;
            this.CheckChargesButton.Click += new System.EventHandler(this.CheckChargesButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.Brown;
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackButton.Location = new System.Drawing.Point(222, 278);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(90, 37);
            this.goBackButton.TabIndex = 2;
            this.goBackButton.Text = "BACK";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // detailsBox
            // 
            this.detailsBox.Location = new System.Drawing.Point(13, 13);
            this.detailsBox.Name = "detailsBox";
            this.detailsBox.Size = new System.Drawing.Size(241, 167);
            this.detailsBox.TabIndex = 3;
            this.detailsBox.Text = "";
            // 
            // userDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::crimemanagement.Properties.Resources.gcpd_grey;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(312, 327);
            this.Controls.Add(this.detailsBox);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.CheckChargesButton);
            this.Controls.Add(this.LodgeComplaintButton);
            this.DoubleBuffered = true;
            this.Name = "userDetails";
            this.Text = "userDetails";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LodgeComplaintButton;
        private System.Windows.Forms.Button CheckChargesButton;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.RichTextBox detailsBox;
    }
}