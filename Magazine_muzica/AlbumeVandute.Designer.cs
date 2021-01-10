namespace Magazine_muzica
{
    partial class AlbumeVandute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumeVandute));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Back = new System.Windows.Forms.PictureBox();
            this.ID_album = new System.Windows.Forms.TextBox();
            this.IDAlbum = new System.Windows.Forms.Label();
            this.ID_magazin = new System.Windows.Forms.TextBox();
            this.IDMagazin = new System.Windows.Forms.Label();
            this.Cautare_ID_magazin = new System.Windows.Forms.TextBox();
            this.CautareIDMagazin = new System.Windows.Forms.Label();
            this.Cautare_ID_album = new System.Windows.Forms.TextBox();
            this.CautareIDAlbum = new System.Windows.Forms.Label();
            this.Data_achizitie = new System.Windows.Forms.DateTimePicker();
            this.DataAchizitie = new System.Windows.Forms.Label();
            this.DeleteAlbum = new System.Windows.Forms.Button();
            this.InsertAlbum = new System.Windows.Forms.Button();
            this.UpdateAlbum = new System.Windows.Forms.Button();
            this.Cantitate_vanduta = new System.Windows.Forms.TextBox();
            this.Cautare_album_vandut = new System.Windows.Forms.TextBox();
            this.SearchAccesoriu = new System.Windows.Forms.Label();
            this.Pret_album = new System.Windows.Forms.TextBox();
            this.CantitateVanduta = new System.Windows.Forms.Label();
            this.PretAlbum = new System.Windows.Forms.Label();
            this.Album = new System.Windows.Forms.Label();
            this.DateAlbumeVandute = new System.Windows.Forms.DataGridView();
            this.DateIDMagazin = new System.Windows.Forms.DataGridView();
            this.DateIDAlbum = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tip_sortare = new System.Windows.Forms.ComboBox();
            this.Sortare_coloana = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateAlbumeVandute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateIDMagazin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateIDAlbum)).BeginInit();
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
            this.Back.TabIndex = 117;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ID_album
            // 
            this.ID_album.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_album.Location = new System.Drawing.Point(252, 149);
            this.ID_album.Name = "ID_album";
            this.ID_album.Size = new System.Drawing.Size(244, 31);
            this.ID_album.TabIndex = 1;
            // 
            // IDAlbum
            // 
            this.IDAlbum.AutoSize = true;
            this.IDAlbum.BackColor = System.Drawing.Color.Transparent;
            this.IDAlbum.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDAlbum.Location = new System.Drawing.Point(33, 149);
            this.IDAlbum.Name = "IDAlbum";
            this.IDAlbum.Size = new System.Drawing.Size(115, 28);
            this.IDAlbum.TabIndex = 114;
            this.IDAlbum.Text = "ID album*";
            // 
            // ID_magazin
            // 
            this.ID_magazin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_magazin.Location = new System.Drawing.Point(252, 112);
            this.ID_magazin.Name = "ID_magazin";
            this.ID_magazin.Size = new System.Drawing.Size(244, 31);
            this.ID_magazin.TabIndex = 0;
            // 
            // IDMagazin
            // 
            this.IDMagazin.AutoSize = true;
            this.IDMagazin.BackColor = System.Drawing.Color.Transparent;
            this.IDMagazin.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDMagazin.Location = new System.Drawing.Point(33, 112);
            this.IDMagazin.Name = "IDMagazin";
            this.IDMagazin.Size = new System.Drawing.Size(140, 28);
            this.IDMagazin.TabIndex = 113;
            this.IDMagazin.Text = "ID magazin*";
            // 
            // Cautare_ID_magazin
            // 
            this.Cautare_ID_magazin.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cautare_ID_magazin.Location = new System.Drawing.Point(273, 319);
            this.Cautare_ID_magazin.Name = "Cautare_ID_magazin";
            this.Cautare_ID_magazin.Size = new System.Drawing.Size(224, 27);
            this.Cautare_ID_magazin.TabIndex = 6;
            this.Cautare_ID_magazin.TextChanged += new System.EventHandler(this.Cautare_ID_magazin_TextChanged);
            // 
            // CautareIDMagazin
            // 
            this.CautareIDMagazin.AutoSize = true;
            this.CautareIDMagazin.BackColor = System.Drawing.Color.Transparent;
            this.CautareIDMagazin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CautareIDMagazin.Location = new System.Drawing.Point(270, 293);
            this.CautareIDMagazin.Name = "CautareIDMagazin";
            this.CautareIDMagazin.Size = new System.Drawing.Size(178, 23);
            this.CautareIDMagazin.TabIndex = 110;
            this.CautareIDMagazin.Text = "Căutare ID magazin";
            // 
            // Cautare_ID_album
            // 
            this.Cautare_ID_album.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cautare_ID_album.Location = new System.Drawing.Point(18, 319);
            this.Cautare_ID_album.Name = "Cautare_ID_album";
            this.Cautare_ID_album.Size = new System.Drawing.Size(249, 27);
            this.Cautare_ID_album.TabIndex = 5;
            this.Cautare_ID_album.TextChanged += new System.EventHandler(this.Cautare_ID_album_TextChanged);
            // 
            // CautareIDAlbum
            // 
            this.CautareIDAlbum.AutoSize = true;
            this.CautareIDAlbum.BackColor = System.Drawing.Color.Transparent;
            this.CautareIDAlbum.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CautareIDAlbum.Location = new System.Drawing.Point(15, 293);
            this.CautareIDAlbum.Name = "CautareIDAlbum";
            this.CautareIDAlbum.Size = new System.Drawing.Size(158, 23);
            this.CautareIDAlbum.TabIndex = 107;
            this.CautareIDAlbum.Text = "Căutare ID album";
            // 
            // Data_achizitie
            // 
            this.Data_achizitie.CalendarFont = new System.Drawing.Font("Cambria", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_achizitie.Location = new System.Drawing.Point(252, 186);
            this.Data_achizitie.Name = "Data_achizitie";
            this.Data_achizitie.Size = new System.Drawing.Size(244, 22);
            this.Data_achizitie.TabIndex = 2;
            // 
            // DataAchizitie
            // 
            this.DataAchizitie.AutoSize = true;
            this.DataAchizitie.BackColor = System.Drawing.Color.Transparent;
            this.DataAchizitie.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataAchizitie.Location = new System.Drawing.Point(33, 182);
            this.DataAchizitie.Name = "DataAchizitie";
            this.DataAchizitie.Size = new System.Drawing.Size(171, 28);
            this.DataAchizitie.TabIndex = 105;
            this.DataAchizitie.Text = "Data achiziției*";
            // 
            // DeleteAlbum
            // 
            this.DeleteAlbum.BackColor = System.Drawing.Color.White;
            this.DeleteAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteAlbum.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DeleteAlbum.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAlbum.Location = new System.Drawing.Point(877, 563);
            this.DeleteAlbum.Name = "DeleteAlbum";
            this.DeleteAlbum.Size = new System.Drawing.Size(97, 42);
            this.DeleteAlbum.TabIndex = 9;
            this.DeleteAlbum.Text = "Ștergere";
            this.DeleteAlbum.UseVisualStyleBackColor = false;
            this.DeleteAlbum.Click += new System.EventHandler(this.DeleteAlbum_Click);
            // 
            // InsertAlbum
            // 
            this.InsertAlbum.BackColor = System.Drawing.Color.White;
            this.InsertAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InsertAlbum.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.InsertAlbum.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertAlbum.Location = new System.Drawing.Point(570, 563);
            this.InsertAlbum.Name = "InsertAlbum";
            this.InsertAlbum.Size = new System.Drawing.Size(97, 42);
            this.InsertAlbum.TabIndex = 7;
            this.InsertAlbum.Text = "Adăugare";
            this.InsertAlbum.UseVisualStyleBackColor = false;
            this.InsertAlbum.Click += new System.EventHandler(this.InsertAlbum_Click);
            // 
            // UpdateAlbum
            // 
            this.UpdateAlbum.BackColor = System.Drawing.Color.White;
            this.UpdateAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UpdateAlbum.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UpdateAlbum.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateAlbum.Location = new System.Drawing.Point(717, 563);
            this.UpdateAlbum.Name = "UpdateAlbum";
            this.UpdateAlbum.Size = new System.Drawing.Size(106, 42);
            this.UpdateAlbum.TabIndex = 8;
            this.UpdateAlbum.Text = "Modificare";
            this.UpdateAlbum.UseVisualStyleBackColor = false;
            this.UpdateAlbum.Click += new System.EventHandler(this.UpdateAlbum_Click);
            // 
            // Cantitate_vanduta
            // 
            this.Cantitate_vanduta.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantitate_vanduta.Location = new System.Drawing.Point(252, 251);
            this.Cantitate_vanduta.Name = "Cantitate_vanduta";
            this.Cantitate_vanduta.Size = new System.Drawing.Size(244, 31);
            this.Cantitate_vanduta.TabIndex = 4;
            // 
            // Cautare_album_vandut
            // 
            this.Cautare_album_vandut.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cautare_album_vandut.Location = new System.Drawing.Point(613, 109);
            this.Cautare_album_vandut.Name = "Cautare_album_vandut";
            this.Cautare_album_vandut.Size = new System.Drawing.Size(406, 31);
            this.Cautare_album_vandut.TabIndex = 10;
            this.Cautare_album_vandut.TextChanged += new System.EventHandler(this.Cautare_album_vandut_TextChanged);
            // 
            // SearchAccesoriu
            // 
            this.SearchAccesoriu.AutoSize = true;
            this.SearchAccesoriu.BackColor = System.Drawing.Color.Transparent;
            this.SearchAccesoriu.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchAccesoriu.Location = new System.Drawing.Point(514, 109);
            this.SearchAccesoriu.Name = "SearchAccesoriu";
            this.SearchAccesoriu.Size = new System.Drawing.Size(93, 28);
            this.SearchAccesoriu.TabIndex = 99;
            this.SearchAccesoriu.Text = "Căutare";
            // 
            // Pret_album
            // 
            this.Pret_album.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pret_album.Location = new System.Drawing.Point(252, 214);
            this.Pret_album.Name = "Pret_album";
            this.Pret_album.Size = new System.Drawing.Size(244, 31);
            this.Pret_album.TabIndex = 3;
            // 
            // CantitateVanduta
            // 
            this.CantitateVanduta.AutoSize = true;
            this.CantitateVanduta.BackColor = System.Drawing.Color.Transparent;
            this.CantitateVanduta.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantitateVanduta.Location = new System.Drawing.Point(32, 251);
            this.CantitateVanduta.Name = "CantitateVanduta";
            this.CantitateVanduta.Size = new System.Drawing.Size(205, 28);
            this.CantitateVanduta.TabIndex = 96;
            this.CantitateVanduta.Text = "Cantitate vândută*";
            // 
            // PretAlbum
            // 
            this.PretAlbum.AutoSize = true;
            this.PretAlbum.BackColor = System.Drawing.Color.Transparent;
            this.PretAlbum.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PretAlbum.Location = new System.Drawing.Point(33, 214);
            this.PretAlbum.Name = "PretAlbum";
            this.PretAlbum.Size = new System.Drawing.Size(133, 28);
            this.PretAlbum.TabIndex = 95;
            this.PretAlbum.Text = "Preț album*";
            // 
            // Album
            // 
            this.Album.AutoSize = true;
            this.Album.BackColor = System.Drawing.Color.Transparent;
            this.Album.Font = new System.Drawing.Font("Cambria", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Album.Location = new System.Drawing.Point(349, 17);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(329, 49);
            this.Album.TabIndex = 94;
            this.Album.Text = "Albume vândute";
            // 
            // DateAlbumeVandute
            // 
            this.DateAlbumeVandute.AllowUserToResizeColumns = false;
            this.DateAlbumeVandute.AllowUserToResizeRows = false;
            this.DateAlbumeVandute.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DateAlbumeVandute.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DateAlbumeVandute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateAlbumeVandute.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DateAlbumeVandute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DateAlbumeVandute.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.NullValue = null;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DateAlbumeVandute.DefaultCellStyle = dataGridViewCellStyle13;
            this.DateAlbumeVandute.EnableHeadersVisualStyles = false;
            this.DateAlbumeVandute.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DateAlbumeVandute.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DateAlbumeVandute.Location = new System.Drawing.Point(519, 146);
            this.DateAlbumeVandute.Name = "DateAlbumeVandute";
            this.DateAlbumeVandute.ReadOnly = true;
            this.DateAlbumeVandute.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateAlbumeVandute.RowHeadersVisible = false;
            this.DateAlbumeVandute.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle14.NullValue = "null";
            this.DateAlbumeVandute.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.DateAlbumeVandute.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DateAlbumeVandute.RowTemplate.Height = 24;
            this.DateAlbumeVandute.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DateAlbumeVandute.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DateAlbumeVandute.Size = new System.Drawing.Size(500, 397);
            this.DateAlbumeVandute.TabIndex = 143;
            this.DateAlbumeVandute.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DateAlbumeVandute_CellContentClick);
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
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.NullValue = null;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DateIDMagazin.DefaultCellStyle = dataGridViewCellStyle15;
            this.DateIDMagazin.EnableHeadersVisualStyles = false;
            this.DateIDMagazin.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DateIDMagazin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DateIDMagazin.Location = new System.Drawing.Point(273, 352);
            this.DateIDMagazin.Name = "DateIDMagazin";
            this.DateIDMagazin.ReadOnly = true;
            this.DateIDMagazin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateIDMagazin.RowHeadersVisible = false;
            this.DateIDMagazin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle16.NullValue = "null";
            this.DateIDMagazin.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.DateIDMagazin.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DateIDMagazin.RowTemplate.Height = 24;
            this.DateIDMagazin.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DateIDMagazin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DateIDMagazin.Size = new System.Drawing.Size(224, 191);
            this.DateIDMagazin.TabIndex = 144;
            this.DateIDMagazin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DateIDMagazin_CellContentClick);
            // 
            // DateIDAlbum
            // 
            this.DateIDAlbum.AllowUserToResizeColumns = false;
            this.DateIDAlbum.AllowUserToResizeRows = false;
            this.DateIDAlbum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DateIDAlbum.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DateIDAlbum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateIDAlbum.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DateIDAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DateIDAlbum.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.NullValue = null;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DateIDAlbum.DefaultCellStyle = dataGridViewCellStyle17;
            this.DateIDAlbum.EnableHeadersVisualStyles = false;
            this.DateIDAlbum.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DateIDAlbum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DateIDAlbum.Location = new System.Drawing.Point(18, 352);
            this.DateIDAlbum.Name = "DateIDAlbum";
            this.DateIDAlbum.ReadOnly = true;
            this.DateIDAlbum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateIDAlbum.RowHeadersVisible = false;
            this.DateIDAlbum.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle18.NullValue = "null";
            this.DateIDAlbum.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.DateIDAlbum.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DateIDAlbum.RowTemplate.Height = 24;
            this.DateIDAlbum.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DateIDAlbum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DateIDAlbum.Size = new System.Drawing.Size(249, 191);
            this.DateIDAlbum.TabIndex = 145;
            this.DateIDAlbum.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DateIDAlbum_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(968, 16);
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
            this.Tip_sortare.Location = new System.Drawing.Point(343, 572);
            this.Tip_sortare.Name = "Tip_sortare";
            this.Tip_sortare.Size = new System.Drawing.Size(119, 29);
            this.Tip_sortare.TabIndex = 178;
            this.Tip_sortare.SelectedIndexChanged += new System.EventHandler(this.Tip_sortare_SelectedIndexChanged);
            // 
            // Sortare_coloana
            // 
            this.Sortare_coloana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sortare_coloana.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sortare_coloana.FormattingEnabled = true;
            this.Sortare_coloana.Items.AddRange(new object[] {
            "id_magazin",
            "id_album",
            "data_achizitiei",
            "pret_album",
            "cantitate_vanduta"});
            this.Sortare_coloana.Location = new System.Drawing.Point(153, 572);
            this.Sortare_coloana.Name = "Sortare_coloana";
            this.Sortare_coloana.Size = new System.Drawing.Size(172, 29);
            this.Sortare_coloana.TabIndex = 177;
            this.Sortare_coloana.SelectedIndexChanged += new System.EventHandler(this.Sortare_coloana_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 573);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 176;
            this.label1.Text = "Sortare după";
            // 
            // AlbumeVandute
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
            this.Controls.Add(this.DateIDAlbum);
            this.Controls.Add(this.DateIDMagazin);
            this.Controls.Add(this.DateAlbumeVandute);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.ID_album);
            this.Controls.Add(this.IDAlbum);
            this.Controls.Add(this.ID_magazin);
            this.Controls.Add(this.IDMagazin);
            this.Controls.Add(this.Cautare_ID_magazin);
            this.Controls.Add(this.CautareIDMagazin);
            this.Controls.Add(this.Cautare_ID_album);
            this.Controls.Add(this.CautareIDAlbum);
            this.Controls.Add(this.Data_achizitie);
            this.Controls.Add(this.DataAchizitie);
            this.Controls.Add(this.DeleteAlbum);
            this.Controls.Add(this.InsertAlbum);
            this.Controls.Add(this.UpdateAlbum);
            this.Controls.Add(this.Cantitate_vanduta);
            this.Controls.Add(this.Cautare_album_vandut);
            this.Controls.Add(this.SearchAccesoriu);
            this.Controls.Add(this.Pret_album);
            this.Controls.Add(this.CantitateVanduta);
            this.Controls.Add(this.PretAlbum);
            this.Controls.Add(this.Album);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlbumeVandute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlbumeVandute";
            this.Load += new System.EventHandler(this.AlbumeVandute_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateAlbumeVandute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateIDMagazin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateIDAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.TextBox ID_album;
        private System.Windows.Forms.Label IDAlbum;
        private System.Windows.Forms.TextBox ID_magazin;
        private System.Windows.Forms.Label IDMagazin;
        private System.Windows.Forms.TextBox Cautare_ID_magazin;
        private System.Windows.Forms.Label CautareIDMagazin;
        private System.Windows.Forms.TextBox Cautare_ID_album;
        private System.Windows.Forms.Label CautareIDAlbum;
        private System.Windows.Forms.DateTimePicker Data_achizitie;
        private System.Windows.Forms.Label DataAchizitie;
        private System.Windows.Forms.Button DeleteAlbum;
        private System.Windows.Forms.Button InsertAlbum;
        private System.Windows.Forms.Button UpdateAlbum;
        private System.Windows.Forms.TextBox Cantitate_vanduta;
        private System.Windows.Forms.TextBox Cautare_album_vandut;
        private System.Windows.Forms.Label SearchAccesoriu;
        private System.Windows.Forms.TextBox Pret_album;
        private System.Windows.Forms.Label CantitateVanduta;
        private System.Windows.Forms.Label PretAlbum;
        private System.Windows.Forms.Label Album;
        private System.Windows.Forms.DataGridView DateAlbumeVandute;
        private System.Windows.Forms.DataGridView DateIDMagazin;
        private System.Windows.Forms.DataGridView DateIDAlbum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Tip_sortare;
        private System.Windows.Forms.ComboBox Sortare_coloana;
        private System.Windows.Forms.Label label1;
    }
}