namespace Midterm
{
    partial class MainMenu
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
            this.studListButton = new System.Windows.Forms.Button();
            this.gradeBookButton = new System.Windows.Forms.Button();
            this.descLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studListButton
            // 
            this.studListButton.Location = new System.Drawing.Point(79, 25);
            this.studListButton.Name = "studListButton";
            this.studListButton.Size = new System.Drawing.Size(75, 23);
            this.studListButton.TabIndex = 0;
            this.studListButton.Text = "Student List";
            this.studListButton.UseVisualStyleBackColor = true;
            this.studListButton.Click += new System.EventHandler(this.studListButton_Click);
            // 
            // gradeBookButton
            // 
            this.gradeBookButton.Location = new System.Drawing.Point(79, 54);
            this.gradeBookButton.Name = "gradeBookButton";
            this.gradeBookButton.Size = new System.Drawing.Size(75, 23);
            this.gradeBookButton.TabIndex = 1;
            this.gradeBookButton.Text = "Grade Book";
            this.gradeBookButton.UseVisualStyleBackColor = true;
            this.gradeBookButton.Click += new System.EventHandler(this.gradeBookButton_Click);
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(9, 9);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(215, 13);
            this.descLabel.TabIndex = 3;
            this.descLabel.Text = "Press a button to access teacher resources.";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(236, 86);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.gradeBookButton);
            this.Controls.Add(this.studListButton);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button studListButton;
        private System.Windows.Forms.Button gradeBookButton;
        private System.Windows.Forms.Label descLabel;
    }
}

