namespace Projet_Achraf
{
    partial class APatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APatient));
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMeSu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCin = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.mnRechercher = new System.Windows.Forms.ToolStripButton();
            this.mnEnregistrer = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnLister = new System.Windows.Forms.ToolStripButton();
            this.mnModifier = new System.Windows.Forms.ToolStripButton();
            this.mnSupprimer = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.GroupBox1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new System.Drawing.Size(6, 37);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.GroupBox1.Controls.Add(this.cmbMeSu);
            this.GroupBox1.Controls.Add(this.label5);
            this.GroupBox1.Controls.Add(this.txtAdr);
            this.GroupBox1.Controls.Add(this.label4);
            this.GroupBox1.Controls.Add(this.dateTimePicker1);
            this.GroupBox1.Controls.Add(this.txtPre);
            this.GroupBox1.Controls.Add(this.txtnom);
            this.GroupBox1.Controls.Add(this.txtTel);
            this.GroupBox1.Controls.Add(this.label13);
            this.GroupBox1.Controls.Add(this.label7);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.cmbCin);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(9, 70);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(890, 220);
            this.GroupBox1.TabIndex = 20;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Information de Patient";
            // 
            // cmbMeSu
            // 
            this.cmbMeSu.FormattingEnabled = true;
            this.cmbMeSu.Location = new System.Drawing.Point(561, 113);
            this.cmbMeSu.Name = "cmbMeSu";
            this.cmbMeSu.Size = new System.Drawing.Size(166, 21);
            this.cmbMeSu.TabIndex = 11;
            this.cmbMeSu.Click += new System.EventHandler(this.cmbM_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(409, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Médecin superviseur";
            // 
            // txtAdr
            // 
            this.txtAdr.Location = new System.Drawing.Point(561, 34);
            this.txtAdr.Name = "txtAdr";
            this.txtAdr.Size = new System.Drawing.Size(166, 20);
            this.txtAdr.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(409, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adresse";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(561, 76);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(166, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // txtPre
            // 
            this.txtPre.Location = new System.Drawing.Point(198, 114);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(166, 20);
            this.txtPre.TabIndex = 6;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(198, 76);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(166, 20);
            this.txtnom.TabIndex = 5;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(198, 161);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(166, 20);
            this.txtTel.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(409, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Data R";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Prenom de Patient";
            // 
            // cmbCin
            // 
            this.cmbCin.FormattingEnabled = true;
            this.cmbCin.Location = new System.Drawing.Point(198, 33);
            this.cmbCin.Name = "cmbCin";
            this.cmbCin.Size = new System.Drawing.Size(166, 21);
            this.cmbCin.TabIndex = 1;
            this.cmbCin.SelectedIndexChanged += new System.EventHandler(this.cmbCin_SelectedIndexChanged);
            this.cmbCin.Click += new System.EventHandler(this.cmbCin_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(16, 80);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(92, 15);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Nom de Patient";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(20, 39);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(25, 15);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Cin";
            // 
            // mnRechercher
            // 
            this.mnRechercher.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnRechercher.Image = ((System.Drawing.Image)(resources.GetObject("mnRechercher.Image")));
            this.mnRechercher.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnRechercher.Name = "mnRechercher";
            this.mnRechercher.Size = new System.Drawing.Size(34, 34);
            this.mnRechercher.Text = "ToolStripButton3";
            this.mnRechercher.ToolTipText = "Rechercher";
            this.mnRechercher.Click += new System.EventHandler(this.mnRechercher_Click_1);
            // 
            // mnEnregistrer
            // 
            this.mnEnregistrer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnEnregistrer.Image = ((System.Drawing.Image)(resources.GetObject("mnEnregistrer.Image")));
            this.mnEnregistrer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnEnregistrer.Name = "mnEnregistrer";
            this.mnEnregistrer.Size = new System.Drawing.Size(34, 34);
            this.mnEnregistrer.Text = "ToolStripButton2";
            this.mnEnregistrer.ToolTipText = "Enregistrer";
            this.mnEnregistrer.Click += new System.EventHandler(this.mnEnregistrer_Click_1);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(6, 37);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // mnLister
            // 
            this.mnLister.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnLister.Image = ((System.Drawing.Image)(resources.GetObject("mnLister.Image")));
            this.mnLister.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnLister.Name = "mnLister";
            this.mnLister.Size = new System.Drawing.Size(34, 34);
            this.mnLister.Text = "ToolStripButton4";
            this.mnLister.ToolTipText = "Lister";
            this.mnLister.Click += new System.EventHandler(this.mnLister_Click_1);
            // 
            // mnModifier
            // 
            this.mnModifier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnModifier.Image = ((System.Drawing.Image)(resources.GetObject("mnModifier.Image")));
            this.mnModifier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnModifier.Name = "mnModifier";
            this.mnModifier.Size = new System.Drawing.Size(34, 34);
            this.mnModifier.Text = "ToolStripButton5";
            this.mnModifier.ToolTipText = "Modifier";
            this.mnModifier.Click += new System.EventHandler(this.mnModifier_Click_1);
            // 
            // mnSupprimer
            // 
            this.mnSupprimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("mnSupprimer.Image")));
            this.mnSupprimer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnSupprimer.Name = "mnSupprimer";
            this.mnSupprimer.Size = new System.Drawing.Size(34, 34);
            this.mnSupprimer.Text = "ToolStripButton6";
            this.mnSupprimer.ToolTipText = "Supprimer";
            this.mnSupprimer.Click += new System.EventHandler(this.mnSupprimer_Click_1);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripSeparator1,
            this.mnSupprimer,
            this.ToolStripSeparator2,
            this.toolStripButton1,
            this.ToolStripSeparator3,
            this.mnModifier,
            this.ToolStripSeparator4,
            this.mnLister,
            this.ToolStripSeparator5,
            this.mnRechercher,
            this.ToolStripSeparator6,
            this.mnEnregistrer});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(911, 37);
            this.ToolStrip1.TabIndex = 22;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 37);
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 34);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Nouveau";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.DataGridView1.Location = new System.Drawing.Point(9, 296);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.Size = new System.Drawing.Size(896, 194);
            this.DataGridView1.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CIN";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "prenom";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tel";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Adresee";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Date R";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "date N";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Medecin";
            this.Column8.Name = "Column8";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // APatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 520);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.DataGridView1);
            this.Name = "APatient";
            this.Text = "Ajouter un Patient ";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator6;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ComboBox cmbMeSu;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtAdr;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        internal System.Windows.Forms.TextBox txtPre;
        internal System.Windows.Forms.TextBox txtnom;
        internal System.Windows.Forms.TextBox txtTel;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cmbCin;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ToolStripButton mnRechercher;
        internal System.Windows.Forms.ToolStripButton mnEnregistrer;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton mnLister;
        internal System.Windows.Forms.ToolStripButton mnModifier;
        internal System.Windows.Forms.ToolStripButton mnSupprimer;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
        internal System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}