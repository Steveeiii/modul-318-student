using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StandartFahrplan));
            this.gbStandart = new System.Windows.Forms.GroupBox();
            this.btnWechseln = new System.Windows.Forms.Button();
            this.cbNach = new System.Windows.Forms.ComboBox();
            this.cbVon = new System.Windows.Forms.ComboBox();
            this.rbAnkunft = new System.Windows.Forms.RadioButton();
            this.rbAbfahrt = new System.Windows.Forms.RadioButton();
            this.lblZeit = new System.Windows.Forms.Label();
            this.dtpZeit = new System.Windows.Forms.DateTimePicker();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblNach = new System.Windows.Forms.Label();
            this.lblVon = new System.Windows.Forms.Label();
            this.dgvStandartFahrplan = new System.Windows.Forms.DataGridView();
            this.abfahrtsortColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zielortColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abfahrtszeitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ankunftszeitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dauerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKarteNach = new System.Windows.Forms.Button();
            this.btnKarteVon = new System.Windows.Forms.Button();
            this.gbStandart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandartFahrplan)).BeginInit();
            this.SuspendLayout();
            // 
            // gbStandart
            // 
            this.gbStandart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStandart.Controls.Add(this.btnKarteVon);
            this.gbStandart.Controls.Add(this.btnKarteNach);
            this.gbStandart.Controls.Add(this.btnWechseln);
            this.gbStandart.Controls.Add(this.cbNach);
            this.gbStandart.Controls.Add(this.cbVon);
            this.gbStandart.Controls.Add(this.rbAnkunft);
            this.gbStandart.Controls.Add(this.rbAbfahrt);
            this.gbStandart.Controls.Add(this.lblZeit);
            this.gbStandart.Controls.Add(this.dtpZeit);
            this.gbStandart.Controls.Add(this.btnSuchen);
            this.gbStandart.Controls.Add(this.dtpDatum);
            this.gbStandart.Controls.Add(this.lblDatum);
            this.gbStandart.Controls.Add(this.lblNach);
            this.gbStandart.Controls.Add(this.lblVon);
            this.gbStandart.Location = new System.Drawing.Point(19, 23);
            this.gbStandart.Name = "gbStandart";
            this.gbStandart.Size = new System.Drawing.Size(934, 302);
            this.gbStandart.TabIndex = 0;
            this.gbStandart.TabStop = false;
            this.gbStandart.Text = "Fahrplan ";
            // 
            // btnWechseln
            // 
            this.btnWechseln.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWechseln.Location = new System.Drawing.Point(427, 53);
            this.btnWechseln.Name = "btnWechseln";
            this.btnWechseln.Size = new System.Drawing.Size(49, 50);
            this.btnWechseln.TabIndex = 15;
            this.btnWechseln.Text = "↨";
            this.btnWechseln.UseVisualStyleBackColor = true;
            this.btnWechseln.Click += new System.EventHandler(this.btnWechseln_Click);
            // 
            // cbNach
            // 
            this.cbNach.FormattingEnabled = true;
            this.cbNach.Location = new System.Drawing.Point(161, 104);
            this.cbNach.Name = "cbNach";
            this.cbNach.Size = new System.Drawing.Size(249, 24);
            this.cbNach.TabIndex = 14;
            this.cbNach.DropDown += new System.EventHandler(this.cbNach_DropDown);
            // 
            // cbVon
            // 
            this.cbVon.FormattingEnabled = true;
            this.cbVon.Location = new System.Drawing.Point(161, 36);
            this.cbVon.Name = "cbVon";
            this.cbVon.Size = new System.Drawing.Size(249, 24);
            this.cbVon.TabIndex = 13;
            this.cbVon.DropDown += new System.EventHandler(this.cbVon_DropDown);
            // 
            // rbAnkunft
            // 
            this.rbAnkunft.AutoSize = true;
            this.rbAnkunft.Location = new System.Drawing.Point(322, 232);
            this.rbAnkunft.Name = "rbAnkunft";
            this.rbAnkunft.Size = new System.Drawing.Size(77, 21);
            this.rbAnkunft.TabIndex = 12;
            this.rbAnkunft.Text = "Ankunft";
            this.rbAnkunft.UseVisualStyleBackColor = true;
            // 
            // rbAbfahrt
            // 
            this.rbAbfahrt.AutoSize = true;
            this.rbAbfahrt.Checked = true;
            this.rbAbfahrt.Location = new System.Drawing.Point(322, 186);
            this.rbAbfahrt.Name = "rbAbfahrt";
            this.rbAbfahrt.Size = new System.Drawing.Size(75, 21);
            this.rbAbfahrt.TabIndex = 11;
            this.rbAbfahrt.TabStop = true;
            this.rbAbfahrt.Text = "Abfahrt";
            this.rbAbfahrt.UseVisualStyleBackColor = true;
            // 
            // lblZeit
            // 
            this.lblZeit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZeit.AutoSize = true;
            this.lblZeit.Location = new System.Drawing.Point(19, 236);
            this.lblZeit.Name = "lblZeit";
            this.lblZeit.Size = new System.Drawing.Size(53, 17);
            this.lblZeit.TabIndex = 10;
            this.lblZeit.Text = "Uhrzeit";
            // 
            // dtpZeit
            // 
            this.dtpZeit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpZeit.CustomFormat = "HH:mm ";
            this.dtpZeit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpZeit.Location = new System.Drawing.Point(161, 231);
            this.dtpZeit.Name = "dtpZeit";
            this.dtpZeit.ShowUpDown = true;
            this.dtpZeit.Size = new System.Drawing.Size(124, 22);
            this.dtpZeit.TabIndex = 9;
            // 
            // btnSuchen
            // 
            this.btnSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSuchen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuchen.Location = new System.Drawing.Point(504, 36);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(186, 92);
            this.btnSuchen.TabIndex = 6;
            this.btnSuchen.Text = "Verbindung suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDatum.CustomFormat = "";
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.Location = new System.Drawing.Point(161, 185);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(124, 22);
            this.dtpDatum.TabIndex = 5;
            // 
            // lblDatum
            // 
            this.lblDatum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(19, 190);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(49, 17);
            this.lblDatum.TabIndex = 2;
            this.lblDatum.Text = "Datum";
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
            this.dgvStandartFahrplan.Size = new System.Drawing.Size(934, 231);
            this.dgvStandartFahrplan.TabIndex = 1;
            // 
            // abfahrtsortColumn
            // 
            this.abfahrtsortColumn.HeaderText = "Abfahrtsort";
            this.abfahrtsortColumn.Name = "abfahrtsortColumn";
            this.abfahrtsortColumn.ReadOnly = true;
            this.abfahrtsortColumn.Width = 186;
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
            // btnKarteNach
            // 
            this.btnKarteNach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnKarteNach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKarteNach.Image = ((System.Drawing.Image)(resources.GetObject("btnKarteNach.Image")));
            this.btnKarteNach.Location = new System.Drawing.Point(99, 95);
            this.btnKarteNach.Name = "btnKarteNach";
            this.btnKarteNach.Size = new System.Drawing.Size(42, 41);
            this.btnKarteNach.TabIndex = 17;
            this.btnKarteNach.UseVisualStyleBackColor = true;
            // 
            // btnKarteVon
            // 
            this.btnKarteVon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnKarteVon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKarteVon.Image = ((System.Drawing.Image)(resources.GetObject("btnKarteVon.Image")));
            this.btnKarteVon.Location = new System.Drawing.Point(99, 27);
            this.btnKarteVon.Name = "btnKarteVon";
            this.btnKarteVon.Size = new System.Drawing.Size(42, 41);
            this.btnKarteVon.TabIndex = 18;
            this.btnKarteVon.UseVisualStyleBackColor = true;
            this.btnKarteVon.Click += new System.EventHandler(this.btnKarteVon_Click);
            // 
            // StandartFahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.dgvStandartFahrplan);
            this.Controls.Add(this.gbStandart);
            this.Name = "StandartFahrplan";
            this.Size = new System.Drawing.Size(972, 600);
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
        private System.Windows.Forms.Label lblZeit;
        private DateTimePicker dtpZeit;
        private RadioButton rbAnkunft;
        private RadioButton rbAbfahrt;
        private Button btnWechseln;
        private ComboBox cbNach;
        private ComboBox cbVon;
        private Button btnKarteVon;
        private Button btnKarteNach;
    }
}
