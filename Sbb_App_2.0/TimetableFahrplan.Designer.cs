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
            this.txtAbfahrtsort = new System.Windows.Forms.TextBox();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.lblAbfahrtsort = new System.Windows.Forms.Label();
            this.dgvStandartFahrplan = new System.Windows.Forms.DataGridView();
            this.abfahrtsortColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ankunftsortColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abfahrtszeitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTimetable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandartFahrplan)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTimetable
            // 
            this.gbTimetable.Controls.Add(this.txtAbfahrtsort);
            this.gbTimetable.Controls.Add(this.btnSuchen);
            this.gbTimetable.Controls.Add(this.lblAbfahrtsort);
            this.gbTimetable.Location = new System.Drawing.Point(28, 26);
            this.gbTimetable.Name = "gbTimetable";
            this.gbTimetable.Size = new System.Drawing.Size(861, 251);
            this.gbTimetable.TabIndex = 0;
            this.gbTimetable.TabStop = false;
            this.gbTimetable.Text = "Fahrplan";
            // 
            // txtAbfahrtsort
            // 
            this.txtAbfahrtsort.Location = new System.Drawing.Point(204, 52);
            this.txtAbfahrtsort.Name = "txtAbfahrtsort";
            this.txtAbfahrtsort.Size = new System.Drawing.Size(249, 22);
            this.txtAbfahrtsort.TabIndex = 8;
            // 
            // btnSuchen
            // 
            this.btnSuchen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuchen.Location = new System.Drawing.Point(33, 142);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(186, 92);
            this.btnSuchen.TabIndex = 7;
            this.btnSuchen.Text = "Verbindung suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
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
            // dgvStandartFahrplan
            // 
            this.dgvStandartFahrplan.AllowUserToAddRows = false;
            this.dgvStandartFahrplan.AllowUserToDeleteRows = false;
            this.dgvStandartFahrplan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStandartFahrplan.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvStandartFahrplan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStandartFahrplan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.abfahrtsortColumn,
            this.ankunftsortColumn,
            this.abfahrtszeitColumn});
            this.dgvStandartFahrplan.Location = new System.Drawing.Point(28, 296);
            this.dgvStandartFahrplan.Name = "dgvStandartFahrplan";
            this.dgvStandartFahrplan.ReadOnly = true;
            this.dgvStandartFahrplan.RowHeadersVisible = false;
            this.dgvStandartFahrplan.RowTemplate.Height = 24;
            this.dgvStandartFahrplan.Size = new System.Drawing.Size(861, 286);
            this.dgvStandartFahrplan.TabIndex = 2;
            // 
            // abfahrtsortColumn
            // 
            this.abfahrtsortColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.abfahrtsortColumn.HeaderText = "Abfahrtsort";
            this.abfahrtsortColumn.Name = "abfahrtsortColumn";
            this.abfahrtsortColumn.ReadOnly = true;
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
            this.Controls.Add(this.dgvStandartFahrplan);
            this.Controls.Add(this.gbTimetable);
            this.Name = "TimetableFahrplan";
            this.Size = new System.Drawing.Size(916, 600);
            this.gbTimetable.ResumeLayout(false);
            this.gbTimetable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandartFahrplan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTimetable;
        private System.Windows.Forms.Label lblAbfahrtsort;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.DataGridView dgvStandartFahrplan;
        private System.Windows.Forms.DataGridViewTextBoxColumn abfahrtsortColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ankunftsortColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abfahrtszeitColumn;
        private System.Windows.Forms.TextBox txtAbfahrtsort;
    }
}
