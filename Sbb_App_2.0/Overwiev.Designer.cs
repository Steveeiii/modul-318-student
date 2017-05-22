namespace Sbb_App_2._0
{
    partial class Overview
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
            this.btnTimetable = new System.Windows.Forms.Button();
            this.btnStandart = new System.Windows.Forms.Button();
            this.userControlPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnTimetable
            // 
            this.btnTimetable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimetable.Location = new System.Drawing.Point(669, 21);
            this.btnTimetable.Name = "btnTimetable";
            this.btnTimetable.Size = new System.Drawing.Size(213, 82);
            this.btnTimetable.TabIndex = 1;
            this.btnTimetable.Text = "Timetable ab Station";
            this.btnTimetable.UseVisualStyleBackColor = true;
            this.btnTimetable.Click += new System.EventHandler(this.btnTimetable_Click);
            // 
            // btnStandart
            // 
            this.btnStandart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnStandart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStandart.Location = new System.Drawing.Point(71, 21);
            this.btnStandart.Name = "btnStandart";
            this.btnStandart.Size = new System.Drawing.Size(213, 82);
            this.btnStandart.TabIndex = 2;
            this.btnStandart.Text = "Standartfahrplan";
            this.btnStandart.UseVisualStyleBackColor = true;
            this.btnStandart.Click += new System.EventHandler(this.btnStandart_Click);
            // 
            // userControlPanel
            // 
            this.userControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlPanel.Location = new System.Drawing.Point(1, 126);
            this.userControlPanel.Name = "userControlPanel";
            this.userControlPanel.Size = new System.Drawing.Size(973, 600);
            this.userControlPanel.TabIndex = 3;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(977, 731);
            this.Controls.Add(this.userControlPanel);
            this.Controls.Add(this.btnStandart);
            this.Controls.Add(this.btnTimetable);
            this.Name = "Overview";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTimetable;
        private System.Windows.Forms.Button btnStandart;
        private System.Windows.Forms.Panel userControlPanel;
    }
}

