namespace Sbb_App_2._0
{
    partial class StandartFahrplan
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
            this.gbStandart = new System.Windows.Forms.GroupBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblNach = new System.Windows.Forms.Label();
            this.lblVon = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.dgvStandartFahrplan = new System.Windows.Forms.DataGridView();
            this.abfahrtsortColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zielortColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abfahrtszeitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ankunftszeitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dauerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtVon = new System.Windows.Forms.TextBox();
            this.txtNach = new System.Windows.Forms.TextBox();
            this.gbStandart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandartFahrplan)).BeginInit();
            this.SuspendLayout();
            // 
            // gbStandart
            // 
            this.gbStandart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStandart.Controls.Add(this.txtNach);
            this.gbStandart.Controls.Add(this.txtVon);
            this.gbStandart.Controls.Add(this.btnSuchen);
            this.gbStandart.Controls.Add(this.dtpDatum);
            this.gbStandart.Controls.Add(this.lblDatum);
            this.gbStandart.Controls.Add(this.lblNach);
            this.gbStandart.Controls.Add(this.lblVon);
            this.gbStandart.Location = new System.Drawing.Point(19, 23);
            this.gbStandart.Name = "gbStandart";
            this.gbStandart.Size = new System.Drawing.Size(786, 302);
            this.gbStandart.TabIndex = 0;
            this.gbStandart.TabStop = false;
            this.gbStandart.Text = "Fahrplan ";
            // 
            // lblDatum
            // 
            this.lblDatum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(19, 211);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(77, 17);
            this.lblDatum.TabIndex = 2;
            this.lblDatum.Text = "Datum/Zeit";
            // 
            // lblNach
            // 
            this.lblNach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNach.AutoSize = true;
            this.lblNach.Location = new System.Drawing.Point(19, 111);
            this.lblNach.Name = "lblNach";
            this.lblNach.Size = new System.Drawing.Size(41, 17);
            this.lblNach.TabIndex = 1;
            this.lblNach.Text = "Nach";
            // 
            // lblVon
            // 
            this.lblVon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVon.AutoSize = true;
            this.lblVon.Location = new System.Drawing.Point(19, 43);
            this.lblVon.Name = "lblVon";
            this.lblVon.Size = new System.Drawing.Size(33, 17);
            this.lblVon.TabIndex = 0;
            this.lblVon.Text = "Von";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDatum.Location = new System.Drawing.Point(161, 206);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(249, 22);
            this.dtpDatum.TabIndex = 5;
            // 
            // btnSuchen
            // 
            this.btnSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSuchen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuchen.Location = new System.Drawing.Point(501, 36);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(186, 92);
            this.btnSuchen.TabIndex = 6;
            this.btnSuchen.Text = "Verbindung suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
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
            this.zielortColumn,
            this.abfahrtszeitColumn,
            this.ankunftszeitColumn,
            this.dauerColumn});
            this.dgvStandartFahrplan.Location = new System.Drawing.Point(19, 344);
            this.dgvStandartFahrplan.Name = "dgvStandartFahrplan";
            this.dgvStandartFahrplan.ReadOnly = true;
            this.dgvStandartFahrplan.RowHeadersVisible = false;
            this.dgvStandartFahrplan.RowTemplate.Height = 24;
            this.dgvStandartFahrplan.Size = new System.Drawing.Size(762, 231);
            this.dgvStandartFahrplan.TabIndex = 1;
            // 
            // abfahrtsortColumn
            // 
            this.abfahrtsortColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.abfahrtsortColumn.HeaderText = "Abfahrtsort";
            this.abfahrtsortColumn.Name = "abfahrtsortColumn";
            this.abfahrtsortColumn.ReadOnly = true;
            // 
            // zielortColumn
            // 
            this.zielortColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.zielortColumn.HeaderText = "Zielort";
            this.zielortColumn.Name = "zielortColumn";
            this.zielortColumn.ReadOnly = true;
            // 
            // abfahrtszeitColumn
            // 
            this.abfahrtszeitColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.abfahrtszeitColumn.HeaderText = "Abfahrtszeit";
            this.abfahrtszeitColumn.Name = "abfahrtszeitColumn";
            this.abfahrtszeitColumn.ReadOnly = true;
            // 
            // ankunftszeitColumn
            // 
            this.ankunftszeitColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ankunftszeitColumn.HeaderText = "Ankunftszeit";
            this.ankunftszeitColumn.Name = "ankunftszeitColumn";
            this.ankunftszeitColumn.ReadOnly = true;
            // 
            // dauerColumn
            // 
            this.dauerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dauerColumn.HeaderText = "Dauer";
            this.dauerColumn.Name = "dauerColumn";
            this.dauerColumn.ReadOnly = true;
            // 
            // txtVon
            // 
            this.txtVon.Location = new System.Drawing.Point(161, 37);
            this.txtVon.Name = "txtVon";
            this.txtVon.Size = new System.Drawing.Size(249, 22);
            this.txtVon.TabIndex = 7;
            // 
            // txtNach
            // 
            this.txtNach.Location = new System.Drawing.Point(161, 106);
            this.txtNach.Name = "txtNach";
            this.txtNach.Size = new System.Drawing.Size(249, 22);
            this.txtNach.TabIndex = 8;
            // 
            // StandartFahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.dgvStandartFahrplan);
            this.Controls.Add(this.gbStandart);
            this.Name = "StandartFahrplan";
            this.Size = new System.Drawing.Size(800, 600);
            this.gbStandart.ResumeLayout(false);
            this.gbStandart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandartFahrplan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStandart;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblNach;
        private System.Windows.Forms.Label lblVon;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.DataGridView dgvStandartFahrplan;
        private System.Windows.Forms.DataGridViewTextBoxColumn abfahrtsortColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zielortColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abfahrtszeitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ankunftszeitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dauerColumn;
        private System.Windows.Forms.TextBox txtNach;
        private System.Windows.Forms.TextBox txtVon;
    }
}
