namespace crimemanagement
{
    partial class user1
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
            this.label1 = new System.Windows.Forms.Label();
            this.aadhaarBox = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.GoHomeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "AadhaarNo";
            // 
            // aadhaarBox
            // 
            this.aadhaarBox.Location = new System.Drawing.Point(135, 66);
            this.aadhaarBox.Name = "aadhaarBox";
            this.aadhaarBox.Size = new System.Drawing.Size(100, 20);
            this.aadhaarBox.TabIndex = 1;
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EnterButton.Location = new System.Drawing.Point(2, 138);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(91, 47);
            this.EnterButton.TabIndex = 2;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // GoHomeButton
            // 
            this.GoHomeButton.BackColor = System.Drawing.Color.Brown;
            this.GoHomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoHomeButton.Location = new System.Drawing.Point(137, 138);
            this.GoHomeButton.Name = "GoHomeButton";
            this.GoHomeButton.Size = new System.Drawing.Size(98, 47);
            this.GoHomeButton.TabIndex = 3;
            this.GoHomeButton.Text = "Go Back";
            this.GoHomeButton.UseVisualStyleBackColor = false;
            this.GoHomeButton.Click += new System.EventHandler(this.GoHomeButton_Click);
            // 
            // user1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::crimemanagement.Properties.Resources.gcpd_grey;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.GoHomeButton);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.aadhaarBox);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "user1";
            this.Text = "user1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aadhaarBox;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button GoHomeButton;
    }
}