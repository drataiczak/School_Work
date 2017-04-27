namespace Midterm
{
    partial class GradeBook
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
            this.gradeGrid = new System.Windows.Forms.DataGridView();
            this.updateButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.highButton = new System.Windows.Forms.Button();
            this.lowButton = new System.Windows.Forms.Button();
            this.aButton = new System.Windows.Forms.RadioButton();
            this.bButton = new System.Windows.Forms.RadioButton();
            this.cButton = new System.Windows.Forms.RadioButton();
            this.dButton = new System.Windows.Forms.RadioButton();
            this.eButton = new System.Windows.Forms.RadioButton();
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gradeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // gradeGrid
            // 
            this.gradeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradeGrid.Location = new System.Drawing.Point(93, 33);
            this.gradeGrid.Name = "gradeGrid";
            this.gradeGrid.ReadOnly = true;
            this.gradeGrid.Size = new System.Drawing.Size(642, 547);
            this.gradeGrid.TabIndex = 0;
            this.gradeGrid.TabStop = false;
            this.gradeGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeGrid_CellContentClick);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(660, 4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(12, 33);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 62);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Main Menu";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // highButton
            // 
            this.highButton.Location = new System.Drawing.Point(741, 33);
            this.highButton.Name = "highButton";
            this.highButton.Size = new System.Drawing.Size(75, 23);
            this.highButton.TabIndex = 4;
            this.highButton.Text = "Show High";
            this.highButton.UseVisualStyleBackColor = true;
            this.highButton.Click += new System.EventHandler(this.highButton_Click);
            // 
            // lowButton
            // 
            this.lowButton.Location = new System.Drawing.Point(741, 62);
            this.lowButton.Name = "lowButton";
            this.lowButton.Size = new System.Drawing.Size(75, 23);
            this.lowButton.TabIndex = 5;
            this.lowButton.Text = "Show Low";
            this.lowButton.UseVisualStyleBackColor = true;
            this.lowButton.Click += new System.EventHandler(this.lowButton_Click);
            // 
            // aButton
            // 
            this.aButton.AutoSize = true;
            this.aButton.Location = new System.Drawing.Point(847, 36);
            this.aButton.Name = "aButton";
            this.aButton.Size = new System.Drawing.Size(64, 17);
            this.aButton.TabIndex = 6;
            this.aButton.TabStop = true;
            this.aButton.Text = "Grade A";
            this.aButton.UseVisualStyleBackColor = true;
            // 
            // bButton
            // 
            this.bButton.AutoSize = true;
            this.bButton.Location = new System.Drawing.Point(847, 59);
            this.bButton.Name = "bButton";
            this.bButton.Size = new System.Drawing.Size(64, 17);
            this.bButton.TabIndex = 7;
            this.bButton.TabStop = true;
            this.bButton.Text = "Grade B";
            this.bButton.UseVisualStyleBackColor = true;
            // 
            // cButton
            // 
            this.cButton.AutoSize = true;
            this.cButton.Location = new System.Drawing.Point(847, 82);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(64, 17);
            this.cButton.TabIndex = 8;
            this.cButton.TabStop = true;
            this.cButton.Text = "Grade C";
            this.cButton.UseVisualStyleBackColor = true;
            // 
            // dButton
            // 
            this.dButton.AutoSize = true;
            this.dButton.Location = new System.Drawing.Point(847, 105);
            this.dButton.Name = "dButton";
            this.dButton.Size = new System.Drawing.Size(65, 17);
            this.dButton.TabIndex = 9;
            this.dButton.TabStop = true;
            this.dButton.Text = "Grade D";
            this.dButton.UseVisualStyleBackColor = true;
            // 
            // eButton
            // 
            this.eButton.AutoSize = true;
            this.eButton.Location = new System.Drawing.Point(847, 128);
            this.eButton.Name = "eButton";
            this.eButton.Size = new System.Drawing.Size(64, 17);
            this.eButton.TabIndex = 10;
            this.eButton.TabStop = true;
            this.eButton.Text = "Grade E";
            this.eButton.UseVisualStyleBackColor = true;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(741, 161);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 11;
            // 
            // GradeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(954, 608);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.eButton);
            this.Controls.Add(this.dButton);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.bButton);
            this.Controls.Add(this.aButton);
            this.Controls.Add(this.lowButton);
            this.Controls.Add(this.highButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.gradeGrid);
            this.Name = "GradeBook";
            this.Text = "Grade Book";
            this.Load += new System.EventHandler(this.GradeBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gradeGrid;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button highButton;
        private System.Windows.Forms.Button lowButton;
        private System.Windows.Forms.RadioButton aButton;
        private System.Windows.Forms.RadioButton bButton;
        private System.Windows.Forms.RadioButton cButton;
        private System.Windows.Forms.RadioButton dButton;
        private System.Windows.Forms.RadioButton eButton;
        private System.Windows.Forms.Label errorLabel;
    }
}