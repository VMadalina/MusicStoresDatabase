namespace Magazine_muzica
{
    partial class CaseDiscuri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaseDiscuri));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Cautare_case = new System.Windows.Forms.TextBox();
            this.SearchCasa = new System.Windows.Forms.Label();
            this.Sediu_central = new System.Windows.Forms.TextBox();
            this.Nume_casa = new System.Windows.Forms.TextBox();
            this.SediuCentral = new System.Windows.Forms.Label();
            this.FormatAlbum = new System.Windows.Forms.Label();
            this.NumeCasa = new System.Windows.Forms.Label();
            this.Case_discuri = new System.Windows.Forms.Label();
            this.An_casa = new System.Windows.Forms.TextBox();
            this.DeleteCasa = new System.Windows.Forms.Button();
            this.InsertCasa = new System.Windows.Forms.Button();
            this.UpdateCasa = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.PictureBox();
            this.IDCasa = new System.Windows.Forms.Label();
            this.DateCasa = new System.Windows.Forms.DataGridView();
            this.ID_casa = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tip_sortare = new System.Windows.Forms.ComboBox();
            this.Sortare_coloana = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateCasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cautare_case
            // 
            this.Cautare_case.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cautare_case.Location = new System.Drawing.Point(567, 120);
            this.Cautare_case.Name = "Cautare_case";
            this.Cautare_case.Size = new System.Drawing.Size(452, 31);
            this.Cautare_case.TabIndex = 7;
            this.Cautare_case.TextChanged += new System.EventHandler(this.Cautare_albume_TextChanged);
            // 
            // SearchCasa
            // 
            this.SearchCasa.AutoSize = true;
            this.SearchCasa.BackColor = System.Drawing.Color.Transparent;
            this.SearchCasa.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCasa.Location = new System.Drawing.Point(468, 120);
            this.SearchCasa.Name = "SearchCasa";
            this.SearchCasa.Size = new System.Drawing.Size(93, 28);
            this.SearchCasa.TabIndex = 46;
            this.SearchCasa.Text = "Căutare";
            // 
            // Sediu_central
            // 
            this.Sediu_central.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sediu_central.Location = new System.Drawing.Point(236, 374);
            this.Sediu_central.Name = "Sediu_central";
            this.Sediu_central.Size = new System.Drawing.Size(219, 31);
            this.Sediu_central.TabIndex = 3;
            // 
            // Nume_casa
            // 
            this.Nume_casa.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nume_casa.Location = new System.Drawing.Point(236, 238);
            this.Nume_casa.Name = "Nume_casa";
            this.Nume_casa.Size = new System.Drawing.Size(219, 31);
            this.Nume_casa.TabIndex = 1;
            // 
            // SediuCentral
            // 
            this.SediuCentral.AutoSize = true;
            this.SediuCentral.BackColor = System.Drawing.Color.Transparent;
            this.SediuCentral.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SediuCentral.Location = new System.Drawing.Point(11, 374);
            this.SediuCentral.Name = "SediuCentral";
            this.SediuCentral.Size = new System.Drawing.Size(144, 28);
            this.SediuCentral.TabIndex = 42;
            this.SediuCentral.Text = "Sediu central";
            // 
            // FormatAlbum
            // 
            this.FormatAlbum.AutoSize = true;
            this.FormatAlbum.BackColor = System.Drawing.Color.Transparent;
            this.FormatAlbum.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormatAlbum.Location = new System.Drawing.Point(11, 308);
            this.FormatAlbum.Name = "FormatAlbum";
            this.FormatAlbum.Size = new System.Drawing.Size(162, 28);
            this.FormatAlbum.TabIndex = 40;
            this.FormatAlbum.Text = "Anul înființării";
            // 
            // NumeCasa
            // 
            this.NumeCasa.AutoSize = true;
            this.NumeCasa.BackColor = System.Drawing.Color.Transparent;
            this.NumeCasa.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeCasa.Location = new System.Drawing.Point(11, 238);
            this.NumeCasa.Name = "NumeCasa";
            this.NumeCasa.Size = new System.Drawing.Size(210, 28);
            this.NumeCasa.TabIndex = 39;
            this.NumeCasa.Text = "Nume casă discuri *";
            // 
            // Case_discuri
            // 
            this.Case_discuri.AutoSize = true;
            this.Case_discuri.BackColor = System.Drawing.Color.Transparent;
            this.Case_discuri.Font = new System.Drawing.Font("Cambria", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Case_discuri.Location = new System.Drawing.Point(357, 26);
            this.Case_discuri.Name = "Case_discuri";
            this.Case_discuri.Size = new System.Drawing.Size(303, 49);
            this.Case_discuri.TabIndex = 38;
            this.Case_discuri.Text = "Case de discuri";
            // 
            // An_casa
            // 
            this.An_casa.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.An_casa.Location = new System.Drawing.Point(236, 307);
            this.An_casa.Name = "An_casa";
            this.An_casa.Size = new System.Drawing.Size(219, 31);
            this.An_casa.TabIndex = 2;
            // 
            // DeleteCasa
            // 
            this.DeleteCasa.BackColor = System.Drawing.Color.White;
            this.DeleteCasa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteCasa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DeleteCasa.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCasa.Location = new System.Drawing.Point(345, 441);
            this.DeleteCasa.Name = "DeleteCasa";
            this.DeleteCasa.Size = new System.Drawing.Size(97, 42);
            this.DeleteCasa.TabIndex = 6;
            this.DeleteCasa.Text = "Ștergere";
            this.DeleteCasa.UseVisualStyleBackColor = false;
            this.DeleteCasa.Click += new System.EventHandler(this.DeleteCasa_Click);
            // 
            // InsertCasa
            // 
            this.InsertCasa.BackColor = System.Drawing.Color.White;
            this.InsertCasa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InsertCasa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.InsertCasa.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertCasa.Location = new System.Drawing.Point(38, 441);
            this.InsertCasa.Name = "InsertCasa";
            this.InsertCasa.Size = new System.Drawing.Size(97, 42);
            this.InsertCasa.TabIndex = 4;
            this.InsertCasa.Text = "Adăugare";
            this.InsertCasa.UseVisualStyleBackColor = false;
            this.InsertCasa.Click += new System.EventHandler(this.InsertCasa_Click);
            // 
            // UpdateCasa
            // 
            this.UpdateCasa.BackColor = System.Drawing.Color.White;
            this.UpdateCasa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UpdateCasa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UpdateCasa.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCasa.Location = new System.Drawing.Point(185, 441);
            this.UpdateCasa.Name = "UpdateCasa";
            this.UpdateCasa.Size = new System.Drawing.Size(106, 42);
            this.UpdateCasa.TabIndex = 5;
            this.UpdateCasa.Text = "Modificare";
            this.UpdateCasa.UseVisualStyleBackColor = false;
            this.UpdateCasa.Click += new System.EventHandler(this.UpdateCasa_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Location = new System.Drawing.Point(26, 18);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(51, 50);
            this.Back.TabIndex = 142;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // IDCasa
            // 
            this.IDCasa.AutoSize = true;
            this.IDCasa.BackColor = System.Drawing.Color.Transparent;
            this.IDCasa.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDCasa.Location = new System.Drawing.Point(11, 170);
            this.IDCasa.Name = "IDCasa";
            this.IDCasa.Size = new System.Drawing.Size(182, 28);
            this.IDCasa.TabIndex = 143;
            this.IDCasa.Text = "CUI casă discuri*";
            // 
            // DateCasa
            // 
            this.DateCasa.AllowUserToResizeColumns = false;
            this.DateCasa.AllowUserToResizeRows = false;
            this.DateCasa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DateCasa.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DateCasa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateCasa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DateCasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DateCasa.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DateCasa.DefaultCellStyle = dataGridViewCellStyle3;
            this.DateCasa.EnableHeadersVisualStyles = false;
            this.DateCasa.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DateCasa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DateCasa.Location = new System.Drawing.Point(473, 170);
            this.DateCasa.Name = "DateCasa";
            this.DateCasa.ReadOnly = true;
            this.DateCasa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateCasa.RowHeadersVisible = false;
            this.DateCasa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.NullValue = "null";
            this.DateCasa.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DateCasa.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DateCasa.RowTemplate.Height = 24;
            this.DateCasa.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DateCasa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DateCasa.Size = new System.Drawing.Size(546, 422);
            this.DateCasa.TabIndex = 144;
            this.DateCasa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DateCasa_CellContentClick);
            // 
            // ID_casa
            // 
            this.ID_casa.AcceptsReturn = true;
            this.ID_casa.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_casa.Location = new System.Drawing.Point(236, 170);
            this.ID_casa.Name = "ID_casa";
            this.ID_casa.Size = new System.Drawing.Size(219, 31);
            this.ID_casa.TabIndex = 0;
            this.ID_casa.TextChanged += new System.EventHandler(this.ID_casa_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(959, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 42);
            this.pictureBox1.TabIndex = 172;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Tip_sortare
            // 
            this.Tip_sortare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tip_sortare.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tip_sortare.FormattingEnabled = true;
            this.Tip_sortare.Items.AddRange(new object[] {
            "asc",
            "desc"});
            this.Tip_sortare.Location = new System.Drawing.Point(336, 532);
            this.Tip_sortare.Name = "Tip_sortare";
            this.Tip_sortare.Size = new System.Drawing.Size(119, 29);
            this.Tip_sortare.TabIndex = 181;
            this.Tip_sortare.SelectedIndexChanged += new System.EventHandler(this.Tip_sortare_SelectedIndexChanged);
            // 
            // Sortare_coloana
            // 
            this.Sortare_coloana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sortare_coloana.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sortare_coloana.FormattingEnabled = true;
            this.Sortare_coloana.Items.AddRange(new object[] {
            "CUI_casa",
            "nume_casa",
            "an_infiintare",
            "sediu_central"});
            this.Sortare_coloana.Location = new System.Drawing.Point(153, 532);
            this.Sortare_coloana.Name = "Sortare_coloana";
            this.Sortare_coloana.Size = new System.Drawing.Size(172, 29);
            this.Sortare_coloana.TabIndex = 180;
            this.Sortare_coloana.SelectedIndexChanged += new System.EventHandler(this.Sortare_coloana_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 535);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 179;
            this.label1.Text = "Sortare după";
            // 
            // CaseDiscuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 617);
            this.Controls.Add(this.Tip_sortare);
            this.Controls.Add(this.Sortare_coloana);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DateCasa);
            this.Controls.Add(this.ID_casa);
            this.Controls.Add(this.IDCasa);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.DeleteCasa);
            this.Controls.Add(this.InsertCasa);
            this.Controls.Add(this.UpdateCasa);
            this.Controls.Add(this.An_casa);
            this.Controls.Add(this.Cautare_case);
            this.Controls.Add(this.SearchCasa);
            this.Controls.Add(this.Sediu_central);
            this.Controls.Add(this.Nume_casa);
            this.Controls.Add(this.SediuCentral);
            this.Controls.Add(this.FormatAlbum);
            this.Controls.Add(this.NumeCasa);
            this.Controls.Add(this.Case_discuri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaseDiscuri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CaseDiscuri";
            this.Load += new System.EventHandler(this.CaseDiscuri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateCasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Cautare_case;
        private System.Windows.Forms.Label SearchCasa;
        private System.Windows.Forms.TextBox Sediu_central;
        private System.Windows.Forms.TextBox Nume_casa;
        private System.Windows.Forms.Label SediuCentral;
        private System.Windows.Forms.Label FormatAlbum;
        private System.Windows.Forms.Label NumeCasa;
        private System.Windows.Forms.Label Case_discuri;
        private System.Windows.Forms.TextBox An_casa;
        private System.Windows.Forms.Button DeleteCasa;
        private System.Windows.Forms.Button InsertCasa;
        private System.Windows.Forms.Button UpdateCasa;
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.Label IDCasa;
        private System.Windows.Forms.DataGridView DateCasa;
        private System.Windows.Forms.TextBox ID_casa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Tip_sortare;
        private System.Windows.Forms.ComboBox Sortare_coloana;
        private System.Windows.Forms.Label label1;
    }
}