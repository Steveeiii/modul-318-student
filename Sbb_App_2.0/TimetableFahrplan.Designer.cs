namespace Sbb_App_2._0
{
    partial class TimetableFahrplan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbTimetable = new System.Windows.Forms.GroupBox();
            this.cbAbfahrtsort = new System.Windows.Forms.ComboBox();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.lblAbfahrtsort = new System.Windows.Forms.Label();
            this.dgvTimetableFahrplan = new System.Windows.Forms.DataGridView();
            this.VerbindungColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ankunftsortColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abfahrtszeitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTimetable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetableFahrplan)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTimetable
            // 
            this.gbTimetable.Controls.Add(this.cbAbfahrtsort);
            this.gbTimetable.Controls.Add(this.btnSuchen);
            this.gbTimetable.Controls.Add(this.lblAbfahrtsort);
            this.gbTimetable.Location = new System.Drawing.Point(28, 26);
            this.gbTimetable.Name = "gbTimetable";
            this.gbTimetable.Size = new System.Drawing.Size(861, 251);
            this.gbTimetable.TabIndex = 0;
            this.gbTimetable.TabStop = false;
            this.gbTimetable.Text = "Fahrplan";
            // 
            // cbAbfahrtsort
            // 
            this.cbAbfahrtsort.FormattingEnabled = true;
            this.cbAbfahrtsort.Location = new System.Drawing.Point(205, 50);
            this.cbAbfahrtsort.Name = "cbAbfahrtsort";
            this.cbAbfahrtsort.Size = new System.Drawing.Size(249, 24);
            this.cbAbfahrtsort.TabIndex = 13;
            this.cbAbfahrtsort.DropDown += new System.EventHandler(this.cbAbfahrtsort_Dropdown);
            // 
            // btnSuchen
            // 
            this.btnSuchen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuchen.Location = new System.Drawing.Point(33, 142);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(186, 92);
            this.btnSuchen.TabIndex = 14;
            this.btnSuchen.Text = "Verbindung suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // lblAbfahrtsort
            // 
            this.lblAbfahrtsort.AutoSize = true;
            this.lblAbfahrtsort.Location = new System.Drawing.Point(30, 57);
            this.lblAbfahrtsort.Name = "lblAbfahrtsort";
            this.lblAbfahrtsort.Size = new System.Drawing.Size(78, 17);
            this.lblAbfahrtsort.TabIndex = 0;
            this.lblAbfahrtsort.Text = "Abfahrtsort";
            // 
            // dgvTimetableFahrplan
            // 
            this.dgvTimetableFahrplan.AllowUserToAddRows = false;
            this.dgvTimetableFahrplan.AllowUserToDeleteRows = false;
            this.dgvTimetableFahrplan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTimetableFahrplan.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTimetableFahrplan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimetableFahrplan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VerbindungColumn,
            this.ankunftsortColumn,
            this.abfahrtszeitColumn});
            this.dgvTimetableFahrplan.Location = new System.Drawing.Point(28, 296);
            this.dgvTimetableFahrplan.Name = "dgvTimetableFahrplan";
            this.dgvTimetableFahrplan.ReadOnly = true;
            this.dgvTimetableFahrplan.RowHeadersVisible = false;
            this.dgvTimetableFahrplan.RowTemplate.Height = 24;
            this.dgvTimetableFahrplan.Size = new System.Drawing.Size(916, 286);
            this.dgvTimetableFahrplan.TabIndex = 2;
            // 
            // VerbindungColumn
            // 
            this.VerbindungColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VerbindungColumn.HeaderText = "Verbindung";
            this.VerbindungColumn.Name = "VerbindungColumn";
            this.VerbindungColumn.ReadOnly = true;
            // 
            // ankunftsortColumn
            // 
            this.ankunftsortColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ankunftsortColumn.HeaderText = "Ankunftsort";
            this.ankunftsortColumn.Name = "ankunftsortColumn";
            this.ankunftsortColumn.ReadOnly = true;
            // 
            // abfahrtszeitColumn
            // 
            this.abfahrtszeitColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.abfahrtszeitColumn.HeaderText = "Abfahrtszeit";
            this.abfahrtszeitColumn.Name = "abfahrtszeitColumn";
            this.abfahrtszeitColumn.ReadOnly = true;
            // 
            // TimetableFahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.dgvTimetableFahrplan);
            this.Controls.Add(this.gbTimetable);
            this.Name = "TimetableFahrplan";
            this.Size = new System.Drawing.Size(971, 600);
            this.gbTimetable.ResumeLayout(false);
            this.gbTimetable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetableFahrplan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTimetable;
        private System.Windows.Forms.Label lblAbfahrtsort;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.DataGridView dgvTimetableFahrplan;
        private System.Windows.Forms.DataGridViewTextBoxColumn VerbindungColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ankunftsortColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abfahrtszeitColumn;
        private System.Windows.Forms.ComboBox cbAbfahrtsort;
    }
}
