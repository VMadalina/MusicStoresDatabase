namespace Magazine_muzica
{
    partial class PartituriVandute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartituriVandute));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Back = new System.Windows.Forms.PictureBox();
            this.ISMN_partitura = new System.Windows.Forms.TextBox();
            this.TextISMN = new System.Windows.Forms.Label();
            this.ID_magazin = new System.Windows.Forms.TextBox();
            this.IDMagazin = new System.Windows.Forms.Label();
            this.Cautare_ID_magazin = new System.Windows.Forms.TextBox();
            this.CautareIDMagazin = new System.Windows.Forms.Label();
            this.Cautare_ISMN = new System.Windows.Forms.TextBox();
            this.CautareISMN = new System.Windows.Forms.Label();
            this.Data_achizitie = new System.Windows.Forms.DateTimePicker();
            this.DataAchizitie = new System.Windows.Forms.Label();
            this.DeletePartitura = new System.Windows.Forms.Button();
            this.InsertPartitura = new System.Windows.Forms.Button();
            this.UpdatePartitura = new System.Windows.Forms.Button();
            this.Cantitate_vanduta = new System.Windows.Forms.TextBox();
            this.Cautare_partitura_vandut = new System.Windows.Forms.TextBox();
            this.SearchAccesoriu = new System.Windows.Forms.Label();
            this.Pret_partitura = new System.Windows.Forms.TextBox();
            this.CantitateVanduta = new System.Windows.Forms.Label();
            this.PretPartitura = new System.Windows.Forms.Label();
            this.Partituri = new System.Windows.Forms.Label();
            this.DatePartituriVandute = new System.Windows.Forms.DataGridView();
            this.DateIDMagazin = new System.Windows.Forms.DataGridView();
            this.DateISMN = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tip_sortare = new System.Windows.Forms.ComboBox();
            this.Sortare_coloana = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatePartituriVandute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateIDMagazin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateISMN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Location = new System.Drawing.Point(38, 16);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(51, 50);
            this.Back.TabIndex = 141;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ISMN_partitura
            // 
            this.ISMN_partitura.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISMN_partitura.Location = new System.Drawing.Point(246, 152);
            this.ISMN_partitura.Name = "ISMN_partitura";
            this.ISMN_partitura.Size = new System.Drawing.Size(248, 31);
            this.ISMN_partitura.TabIndex = 1;
            // 
            // TextISMN
            // 
            this.TextISMN.AutoSize = true;
            this.TextISMN.BackColor = System.Drawing.Color.Transparent;
            this.TextISMN.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextISMN.Location = new System.Drawing.Point(18, 152);
            this.TextISMN.Name = "TextISMN";
            this.TextISMN.Size = new System.Drawing.Size(77, 28);
            this.TextISMN.TabIndex = 138;
            this.TextISMN.Text = "ISMN*";
            // 
            // ID_magazin
            // 
            this.ID_magazin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_magazin.Location = new System.Drawing.Point(246, 109);
            this.ID_magazin.Name = "ID_magazin";
            this.ID_magazin.Size = new System.Drawing.Size(248, 31);
            this.ID_magazin.TabIndex = 0;
            // 
            // IDMagazin
            // 
            this.IDMagazin.AutoSize = true;
            this.IDMagazin.BackColor = System.Drawing.Color.Transparent;
            this.IDMagazin.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDMagazin.Location = new System.Drawing.Point(18, 109);
            this.IDMagazin.Name = "IDMagazin";
            this.IDMagazin.Size = new System.Drawing.Size(140, 28);
            this.IDMagazin.TabIndex = 137;
            this.IDMagazin.Text = "ID magazin*";
            // 
            // Cautare_ID_magazin
            // 
            this.Cautare_ID_magazin.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cautare_ID_magazin.Location = new System.Drawing.Point(277, 341);
            this.Cautare_ID_magazin.Name = "Cautare_ID_magazin";
            this.Cautare_ID_magazin.Size = new System.Drawing.Size(217, 27);
            this.Cautare_ID_magazin.TabIndex = 6;
            this.Cautare_ID_magazin.TextChanged += new System.EventHandler(this.Cautare_ID_magazin_TextChanged);
            // 
            // CautareIDMagazin
            // 
            this.CautareIDMagazin.AutoSize = true;
            this.CautareIDMagazin.BackColor = System.Drawing.Color.Transparent;
            this.CautareIDMagazin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CautareIDMagazin.Location = new System.Drawing.Point(274, 315);
            this.CautareIDMagazin.Name = "CautareIDMagazin";
            this.CautareIDMagazin.Size = new System.Drawing.Size(178, 23);
            this.CautareIDMagazin.TabIndex = 134;
            this.CautareIDMagazin.Text = "Căutare ID magazin";
            // 
            // Cautare_ISMN
            // 
            this.Cautare_ISMN.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cautare_ISMN.Location = new System.Drawing.Point(22, 341);
            this.Cautare_ISMN.Name = "Cautare_ISMN";
            this.Cautare_ISMN.Size = new System.Drawing.Size(251, 27);
            this.Cautare_ISMN.TabIndex = 5;
            this.Cautare_ISMN.TextChanged += new System.EventHandler(this.Cautare_ISMN_TextChanged);
            // 
            // CautareISMN
            // 
            this.CautareISMN.AutoSize = true;
            this.CautareISMN.BackColor = System.Drawing.Color.Transparent;
            this.CautareISMN.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CautareISMN.Location = new System.Drawing.Point(19, 315);
            this.CautareISMN.Name = "CautareISMN";
            this.CautareISMN.Size = new System.Drawing.Size(127, 23);
            this.CautareISMN.TabIndex = 131;
            this.CautareISMN.Text = "Căutare ISMN";
            // 
            // Data_achizitie
            // 
            this.Data_achizitie.CalendarFont = new System.Drawing.Font("Cambria", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_achizitie.Location = new System.Drawing.Point(246, 194);
            this.Data_achizitie.Name = "Data_achizitie";
            this.Data_achizitie.Size = new System.Drawing.Size(248, 22);
            this.Data_achizitie.TabIndex = 2;
            // 
            // DataAchizitie
            // 
            this.DataAchizitie.AutoSize = true;
            this.DataAchizitie.BackColor = System.Drawing.Color.Transparent;
            this.DataAchizitie.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataAchizitie.Location = new System.Drawing.Point(18, 190);
            this.DataAchizitie.Name = "DataAchizitie";
            this.DataAchizitie.Size = new System.Drawing.Size(171, 28);
            this.DataAchizitie.TabIndex = 129;
            this.DataAchizitie.Text = "Data achiziției*";
            // 
            // DeletePartitura
            // 
            this.DeletePartitura.BackColor = System.Drawing.Color.White;
            this.DeletePartitura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeletePartitura.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DeletePartitura.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePartitura.Location = new System.Drawing.Point(892, 559);
            this.DeletePartitura.Name = "DeletePartitura";
            this.DeletePartitura.Size = new System.Drawing.Size(97, 42);
            this.DeletePartitura.TabIndex = 9;
            this.DeletePartitura.Text = "Ștergere";
            this.DeletePartitura.UseVisualStyleBackColor = false;
            this.DeletePartitura.Click += new System.EventHandler(this.DeletePartitura_Click);
            // 
            // InsertPartitura
            // 
            this.InsertPartitura.BackColor = System.Drawing.Color.White;
            this.InsertPartitura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InsertPartitura.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.InsertPartitura.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertPartitura.Location = new System.Drawing.Point(585, 559);
            this.InsertPartitura.Name = "InsertPartitura";
            this.InsertPartitura.Size = new System.Drawing.Size(97, 42);
            this.InsertPartitura.TabIndex = 7;
            this.InsertPartitura.Text = "Adăugare";
            this.InsertPartitura.UseVisualStyleBackColor = false;
            this.InsertPartitura.Click += new System.EventHandler(this.InsertPartitura_Click);
            // 
            // UpdatePartitura
            // 
            this.UpdatePartitura.BackColor = System.Drawing.Color.White;
            this.UpdatePartitura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UpdatePartitura.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UpdatePartitura.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatePartitura.Location = new System.Drawing.Point(732, 559);
            this.UpdatePartitura.Name = "UpdatePartitura";
            this.UpdatePartitura.Size = new System.Drawing.Size(106, 42);
            this.UpdatePartitura.TabIndex = 8;
            this.UpdatePartitura.Text = "Modificare";
            this.UpdatePartitura.UseVisualStyleBackColor = false;
            this.UpdatePartitura.Click += new System.EventHandler(this.UpdatePartitura_Click);
            // 
            // Cantitate_vanduta
            // 
            this.Cantitate_vanduta.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantitate_vanduta.Location = new System.Drawing.Point(246, 273);
            this.Cantitate_vanduta.Name = "Cantitate_vanduta";
            this.Cantitate_vanduta.Size = new System.Drawing.Size(248, 31);
            this.Cantitate_vanduta.TabIndex = 4;
            // 
            // Cautare_partitura_vandut
            // 
            this.Cautare_partitura_vandut.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cautare_partitura_vandut.Location = new System.Drawing.Point(612, 109);
            this.Cautare_partitura_vandut.Name = "Cautare_partitura_vandut";
            this.Cautare_partitura_vandut.Size = new System.Drawing.Size(399, 31);
            this.Cautare_partitura_vandut.TabIndex = 10;
            this.Cautare_partitura_vandut.TextChanged += new System.EventHandler(this.Cautare_partitura_vandut_TextChanged);
            // 
            // SearchAccesoriu
            // 
            this.SearchAccesoriu.AutoSize = true;
            this.SearchAccesoriu.BackColor = System.Drawing.Color.Transparent;
            this.SearchAccesoriu.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchAccesoriu.Location = new System.Drawing.Point(513, 109);
            this.SearchAccesoriu.Name = "SearchAccesoriu";
            this.SearchAccesoriu.Size = new System.Drawing.Size(93, 28);
            this.SearchAccesoriu.TabIndex = 123;
            this.SearchAccesoriu.Text = "Căutare";
            // 
            // Pret_partitura
            // 
            this.Pret_partitura.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pret_partitura.Location = new System.Drawing.Point(246, 229);
            this.Pret_partitura.Name = "Pret_partitura";
            this.Pret_partitura.Size = new System.Drawing.Size(248, 31);
            this.Pret_partitura.TabIndex = 3;
            // 
            // CantitateVanduta
            // 
            this.CantitateVanduta.AutoSize = true;
            this.CantitateVanduta.BackColor = System.Drawing.Color.Transparent;
            this.CantitateVanduta.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantitateVanduta.Location = new System.Drawing.Point(17, 273);
            this.CantitateVanduta.Name = "CantitateVanduta";
            this.CantitateVanduta.Size = new System.Drawing.Size(205, 28);
            this.CantitateVanduta.TabIndex = 120;
            this.CantitateVanduta.Text = "Cantitate vândută*";
            // 
            // PretPartitura
            // 
            this.PretPartitura.AutoSize = true;
            this.PretPartitura.BackColor = System.Drawing.Color.Transparent;
            this.PretPartitura.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PretPartitura.Location = new System.Drawing.Point(18, 229);
            this.PretPartitura.Name = "PretPartitura";
            this.PretPartitura.Size = new System.Drawing.Size(164, 28);
            this.PretPartitura.TabIndex = 119;
            this.PretPartitura.Text = "Preț partitură*";
            // 
            // Partituri
            // 
            this.Partituri.AutoSize = true;
            this.Partituri.BackColor = System.Drawing.Color.Transparent;
            this.Partituri.Font = new System.Drawing.Font("Cambria", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Partituri.Location = new System.Drawing.Point(349, 17);
            this.Partituri.Name = "Partituri";
            this.Partituri.Size = new System.Drawing.Size(353, 49);
            this.Partituri.TabIndex = 118;
            this.Partituri.Text = "Partituri vândute";
            // 
            // DatePartituriVandute
            // 
            this.DatePartituriVandute.AllowUserToResizeColumns = false;
            this.DatePartituriVandute.AllowUserToResizeRows = false;
            this.DatePartituriVandute.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DatePartituriVandute.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DatePartituriVandute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatePartituriVandute.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DatePartituriVandute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatePartituriVandute.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.NullValue = null;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatePartituriVandute.DefaultCellStyle = dataGridViewCellStyle19;
            this.DatePartituriVandute.EnableHeadersVisualStyles = false;
            this.DatePartituriVandute.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DatePartituriVandute.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DatePartituriVandute.Location = new System.Drawing.Point(518, 146);
            this.DatePartituriVandute.Name = "DatePartituriVandute";
            this.DatePartituriVandute.ReadOnly = true;
            this.DatePartituriVandute.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DatePartituriVandute.RowHeadersVisible = false;
            this.DatePartituriVandute.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle20.NullValue = "null";
            this.DatePartituriVandute.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.DatePartituriVandute.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DatePartituriVandute.RowTemplate.Height = 24;
            this.DatePartituriVandute.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DatePartituriVandute.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatePartituriVandute.Size = new System.Drawing.Size(493, 395);
            this.DatePartituriVandute.TabIndex = 142;
            this.DatePartituriVandute.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatePartituriVandute_CellContentClick);
            // 
            // DateIDMagazin
            // 
            this.DateIDMagazin.AllowUserToResizeColumns = false;
            this.DateIDMagazin.AllowUserToResizeRows = false;
            this.DateIDMagazin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DateIDMagazin.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DateIDMagazin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateIDMagazin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DateIDMagazin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DateIDMagazin.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.NullValue = null;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DateIDMagazin.DefaultCellStyle = dataGridViewCellStyle21;
            this.DateIDMagazin.EnableHeadersVisualStyles = false;
            this.DateIDMagazin.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DateIDMagazin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DateIDMagazin.Location = new System.Drawing.Point(278, 374);
            this.DateIDMagazin.Name = "DateIDMagazin";
            this.DateIDMagazin.ReadOnly = true;
            this.DateIDMagazin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateIDMagazin.RowHeadersVisible = false;
            this.DateIDMagazin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle22.NullValue = "null";
            this.DateIDMagazin.RowsDefaultCellStyle = dataGridViewCellStyle22;
            this.DateIDMagazin.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DateIDMagazin.RowTemplate.Height = 24;
            this.DateIDMagazin.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DateIDMagazin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DateIDMagazin.Size = new System.Drawing.Size(216, 181);
            this.DateIDMagazin.TabIndex = 143;
            this.DateIDMagazin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DateIDMagazin_CellContentClick);
            // 
            // DateISMN
            // 
            this.DateISMN.AllowUserToResizeColumns = false;
            this.DateISMN.AllowUserToResizeRows = false;
            this.DateISMN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DateISMN.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DateISMN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateISMN.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DateISMN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DateISMN.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.NullValue = null;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DateISMN.DefaultCellStyle = dataGridViewCellStyle23;
            this.DateISMN.EnableHeadersVisualStyles = false;
            this.DateISMN.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DateISMN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DateISMN.Location = new System.Drawing.Point(22, 374);
            this.DateISMN.Name = "DateISMN";
            this.DateISMN.ReadOnly = true;
            this.DateISMN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateISMN.RowHeadersVisible = false;
            this.DateISMN.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle24.NullValue = "null";
            this.DateISMN.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.DateISMN.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DateISMN.RowTemplate.Height = 24;
            this.DateISMN.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DateISMN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DateISMN.Size = new System.Drawing.Size(250, 181);
            this.DateISMN.TabIndex = 144;
            this.DateISMN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DateISMN_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(946, 17);
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
            this.Tip_sortare.Location = new System.Drawing.Point(352, 572);
            this.Tip_sortare.Name = "Tip_sortare";
            this.Tip_sortare.Size = new System.Drawing.Size(119, 29);
            this.Tip_sortare.TabIndex = 187;
            this.Tip_sortare.SelectedIndexChanged += new System.EventHandler(this.Tip_sortare_SelectedIndexChanged);
            // 
            // Sortare_coloana
            // 
            this.Sortare_coloana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sortare_coloana.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sortare_coloana.FormattingEnabled = true;
            this.Sortare_coloana.Items.AddRange(new object[] {
            "id_magazin",
            "ISMN",
            "data_achizitiei",
            "pret_partitura",
            "cantitate_vanduta"});
            this.Sortare_coloana.Location = new System.Drawing.Point(169, 572);
            this.Sortare_coloana.Name = "Sortare_coloana";
            this.Sortare_coloana.Size = new System.Drawing.Size(172, 29);
            this.Sortare_coloana.TabIndex = 186;
            this.Sortare_coloana.SelectedIndexChanged += new System.EventHandler(this.Sortare_coloana_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 575);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 185;
            this.label1.Text = "Sortare după";
            // 
            // PartituriVandute
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
            this.Controls.Add(this.DateISMN);
            this.Controls.Add(this.DateIDMagazin);
            this.Controls.Add(this.DatePartituriVandute);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.ISMN_partitura);
            this.Controls.Add(this.TextISMN);
            this.Controls.Add(this.ID_magazin);
            this.Controls.Add(this.IDMagazin);
            this.Controls.Add(this.Cautare_ID_magazin);
            this.Controls.Add(this.CautareIDMagazin);
            this.Controls.Add(this.Cautare_ISMN);
            this.Controls.Add(this.CautareISMN);
            this.Controls.Add(this.Data_achizitie);
            this.Controls.Add(this.DataAchizitie);
            this.Controls.Add(this.DeletePartitura);
            this.Controls.Add(this.InsertPartitura);
            this.Controls.Add(this.UpdatePartitura);
            this.Controls.Add(this.Cantitate_vanduta);
            this.Controls.Add(this.Cautare_partitura_vandut);
            this.Controls.Add(this.SearchAccesoriu);
            this.Controls.Add(this.Pret_partitura);
            this.Controls.Add(this.CantitateVanduta);
            this.Controls.Add(this.PretPartitura);
            this.Controls.Add(this.Partituri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PartituriVandute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PartituriVandute";
            this.Load += new System.EventHandler(this.PartituriVandute_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatePartituriVandute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateIDMagazin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateISMN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.TextBox ISMN_partitura;
        private System.Windows.Forms.Label TextISMN;
        private System.Windows.Forms.TextBox ID_magazin;
        private System.Windows.Forms.Label IDMagazin;
        private System.Windows.Forms.TextBox Cautare_ID_magazin;
        private System.Windows.Forms.Label CautareIDMagazin;
        private System.Windows.Forms.TextBox Cautare_ISMN;
        private System.Windows.Forms.Label CautareISMN;
        private System.Windows.Forms.DateTimePicker Data_achizitie;
        private System.Windows.Forms.Label DataAchizitie;
        private System.Windows.Forms.Button DeletePartitura;
        private System.Windows.Forms.Button InsertPartitura;
        private System.Windows.Forms.Button UpdatePartitura;
        private System.Windows.Forms.TextBox Cantitate_vanduta;
        private System.Windows.Forms.TextBox Cautare_partitura_vandut;
        private System.Windows.Forms.Label SearchAccesoriu;
        private System.Windows.Forms.TextBox Pret_partitura;
        private System.Windows.Forms.Label CantitateVanduta;
        private System.Windows.Forms.Label PretPartitura;
        private System.Windows.Forms.Label Partituri;
        private System.Windows.Forms.DataGridView DatePartituriVandute;
        private System.Windows.Forms.DataGridView DateIDMagazin;
        private System.Windows.Forms.DataGridView DateISMN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Tip_sortare;
        private System.Windows.Forms.ComboBox Sortare_coloana;
        private System.Windows.Forms.Label label1;
    }
}