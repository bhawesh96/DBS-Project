namespace crimemanagement
{
    partial class PoliceDetails
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
            this.DetailsBox = new System.Windows.Forms.RichTextBox();
            this.ViewCompButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DetailsBox
            // 
            this.DetailsBox.Location = new System.Drawing.Point(12, 12);
            this.DetailsBox.Name = "DetailsBox";
            this.DetailsBox.Size = new System.Drawing.Size(287, 160);
            this.DetailsBox.TabIndex = 0;
            this.DetailsBox.Text = "";
            // 
            // ViewCompButton
            // 
            this.ViewCompButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ViewCompButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCompButton.Location = new System.Drawing.Point(12, 178);
            this.ViewCompButton.Name = "ViewCompButton";
            this.ViewCompButton.Size = new System.Drawing.Size(157, 58);
            this.ViewCompButton.TabIndex = 1;
            this.ViewCompButton.Text = "VIEW COMPLAINTS";
            this.ViewCompButton.UseVisualStyleBackColor = false;
            this.ViewCompButton.Click += new System.EventHandler(this.ViewCompButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.Brown;
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.Location = new System.Drawing.Point(202, 263);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(118, 40);
            this.LogOutButton.TabIndex = 2;
            this.LogOutButton.Text = "LOG OUT";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // PoliceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::crimemanagement.Properties.Resources.gcpd_grey;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(332, 315);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.ViewCompButton);
            this.Controls.Add(this.DetailsBox);
            this.Name = "PoliceDetails";
            this.Text = "PoliceDetails";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox DetailsBox;
        private System.Windows.Forms.Button ViewCompButton;
        private System.Windows.Forms.Button LogOutButton;
    }
}