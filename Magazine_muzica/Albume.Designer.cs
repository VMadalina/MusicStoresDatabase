namespace Magazine_muzica
{
    partial class Albume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Albume));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Cautare_albume = new System.Windows.Forms.TextBox();
            this.SearchMagazine = new System.Windows.Forms.Label();
            this.DeleteAlbume = new System.Windows.Forms.Button();
            this.InsertAlbume = new System.Windows.Forms.Button();
            this.UpdateAlbume = new System.Windows.Forms.Button();
            this.ID_casa = new System.Windows.Forms.TextBox();
            this.Nume_album = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DataLansare = new System.Windows.Forms.Label();
            this.FormatAlbum = new System.Windows.Forms.Label();
            this.NumeAlbum = new System.Windows.Forms.Label();
            this.Album = new System.Windows.Forms.Label();
            this.Format_album = new System.Windows.Forms.ComboBox();
            this.Data_lansare = new System.Windows.Forms.DateTimePicker();
            this.CautareIDCasa = new System.Windows.Forms.Label();
            this.Cautare_id_casa = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.PictureBox();
            this.DateAlbume = new System.Windows.Forms.DataGridView();
            this.Date_IDcasa = new System.Windows.Forms.DataGridView();
            this.IDAlbum = new System.Windows.Forms.Label();
            this.ID_album = new System.Windows.Forms.TextBox();
            this.Nume_artist = new System.Windows.Forms.TextBox();
            this.NumeArtist = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tip_sortare = new System.Windows.Forms.ComboBox();
            this.Sortare_coloana = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateAlbume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date_IDcasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cautare_albume
            // 
            this.Cautare_albume.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cautare_albume.Location = new System.Drawing.Point(551, 119);
            this.Cautare_albume.Name = "Cautare_albume";
            this.Cautare_albume.Size = new System.Drawing.Size(474, 31);
            this.Cautare_albume.TabIndex = 8;
            this.Cautare_albume.TextChanged += new System.EventHandler(this.Cautare_albume_TextChanged);
            // 
            // SearchMagazine
            // 
            this.SearchMagazine.AutoSize = true;
            this.SearchMagazine.BackColor = System.Drawing.Color.Transparent;
            this.SearchMagazine.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMagazine.Location = new System.Drawing.Point(449, 119);
            this.SearchMagazine.Name = "SearchMagazine";
            this.SearchMagazine.Size = new System.Drawing.Size(93, 28);
            this.SearchMagazine.TabIndex = 34;
            this.SearchMagazine.Text = "Căutare";
            this.SearchMagazine.Click += new System.EventHandler(this.SearchMagazine_Click);
            // 
            // DeleteAlbume
            // 
            this.DeleteAlbume.BackColor = System.Drawing.Color.White;
            this.DeleteAlbume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteAlbume.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DeleteAlbume.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAlbume.Location = new System.Drawing.Point(881, 553);
            this.DeleteAlbume.Name = "DeleteAlbume";
            this.DeleteAlbume.Size = new System.Drawing.Size(97, 42);
            this.DeleteAlbume.TabIndex = 7;
            this.DeleteAlbume.Text = "Ștergere";
            this.DeleteAlbume.UseVisualStyleBackColor = false;
            this.DeleteAlbume.Click += new System.EventHandler(this.DeleteAlbume_Click);
            // 
            // InsertAlbume
            // 
            this.InsertAlbume.BackColor = System.Drawing.Color.White;
            this.InsertAlbume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InsertAlbume.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.InsertAlbume.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertAlbume.Location = new System.Drawing.Point(520, 553);
            this.InsertAlbume.Name = "InsertAlbume";
            this.InsertAlbume.Size = new System.Drawing.Size(97, 42);
            this.InsertAlbume.TabIndex = 5;
            this.InsertAlbume.Text = "Adăugare";
            this.InsertAlbume.UseVisualStyleBackColor = false;
            this.InsertAlbume.Click += new System.EventHandler(this.InsertAlbume_Click);
            // 
            // UpdateAlbume
            // 
            this.UpdateAlbume.BackColor = System.Drawing.Color.White;
            this.UpdateAlbume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UpdateAlbume.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UpdateAlbume.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateAlbume.Location = new System.Drawing.Point(690, 553);
            this.UpdateAlbume.Name = "UpdateAlbume";
            this.UpdateAlbume.Size = new System.Drawing.Size(118, 42);
            this.UpdateAlbume.TabIndex = 6;
            this.UpdateAlbume.Text = "Modificare";
            this.UpdateAlbume.UseVisualStyleBackColor = false;
            this.UpdateAlbume.Click += new System.EventHandler(this.UpdateAlbume_Click);
            // 
            // ID_casa
            // 
            this.ID_casa.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_casa.Location = new System.Drawing.Point(195, 302);
            this.ID_casa.Name = "ID_casa";
            this.ID_casa.Size = new System.Drawing.Size(248, 29);
            this.ID_casa.TabIndex = 3;
            // 
            // Nume_album
            // 
            this.Nume_album.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nume_album.Location = new System.Drawing.Point(195, 121);
            this.Nume_album.Name = "Nume_album";
            this.Nume_album.Size = new System.Drawing.Size(248, 29);
            this.Nume_album.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "CUI casă discuri";
            // 
            // DataLansare
            // 
            this.DataLansare.AutoSize = true;
            this.DataLansare.BackColor = System.Drawing.Color.Transparent;
            this.DataLansare.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataLansare.Location = new System.Drawing.Point(14, 258);
            this.DataLansare.Name = "DataLansare";
            this.DataLansare.Size = new System.Drawing.Size(141, 26);
            this.DataLansare.TabIndex = 21;
            this.DataLansare.Text = "Dată lansare*";
            // 
            // FormatAlbum
            // 
            this.FormatAlbum.AutoSize = true;
            this.FormatAlbum.BackColor = System.Drawing.Color.Transparent;
            this.FormatAlbum.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormatAlbum.Location = new System.Drawing.Point(14, 215);
            this.FormatAlbum.Name = "FormatAlbum";
            this.FormatAlbum.Size = new System.Drawing.Size(154, 26);
            this.FormatAlbum.TabIndex = 20;
            this.FormatAlbum.Text = "Format album*";
            // 
            // NumeAlbum
            // 
            this.NumeAlbum.AutoSize = true;
            this.NumeAlbum.BackColor = System.Drawing.Color.Transparent;
            this.NumeAlbum.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeAlbum.Location = new System.Drawing.Point(14, 124);
            this.NumeAlbum.Name = "NumeAlbum";
            this.NumeAlbum.Size = new System.Drawing.Size(140, 26);
            this.NumeAlbum.TabIndex = 19;
            this.NumeAlbum.Text = "Nume album*";
            // 
            // Album
            // 
            this.Album.AutoSize = true;
            this.Album.BackColor = System.Drawing.Color.Transparent;
            this.Album.Font = new System.Drawing.Font("Cambria", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Album.Location = new System.Drawing.Point(423, 25);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(165, 49);
            this.Album.TabIndex = 18;
            this.Album.Text = "Albume";
            // 
            // Format_album
            // 
            this.Format_album.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Format_album.FormattingEnabled = true;
            this.Format_album.Location = new System.Drawing.Point(195, 215);
            this.Format_album.Name = "Format_album";
            this.Format_album.Size = new System.Drawing.Size(248, 29);
            this.Format_album.TabIndex = 1;
            // 
            // Data_lansare
            // 
            this.Data_lansare.CalendarFont = new System.Drawing.Font("Cambria", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_lansare.Location = new System.Drawing.Point(195, 262);
            this.Data_lansare.Name = "Data_lansare";
            this.Data_lansare.Size = new System.Drawing.Size(248, 22);
            this.Data_lansare.TabIndex = 2;
            // 
            // CautareIDCasa
            // 
            this.CautareIDCasa.AutoSize = true;
            this.CautareIDCasa.BackColor = System.Drawing.Color.Transparent;
            this.CautareIDCasa.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CautareIDCasa.Location = new System.Drawing.Point(9, 356);
            this.CautareIDCasa.Name = "CautareIDCasa";
            this.CautareIDCasa.Size = new System.Drawing.Size(228, 26);
            this.CautareIDCasa.TabIndex = 38;
            this.CautareIDCasa.Text = "Căutare ID casă discuri";
            this.CautareIDCasa.Click += new System.EventHandler(this.CautareIDCasa_Click);
            // 
            // Cautare_id_casa
            // 
            this.Cautare_id_casa.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cautare_id_casa.Location = new System.Drawing.Point(14, 386);
            this.Cautare_id_casa.Name = "Cautare_id_casa";
            this.Cautare_id_casa.Size = new System.Drawing.Size(265, 29);
            this.Cautare_id_casa.TabIndex = 4;
            this.Cautare_id_casa.TextChanged += new System.EventHandler(this.Cautare_id_casa_TextChanged);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Location = new System.Drawing.Point(27, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(51, 50);
            this.Back.TabIndex = 70;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // DateAlbume
            // 
            this.DateAlbume.AllowUserToResizeColumns = false;
            this.DateAlbume.AllowUserToResizeRows = false;
            this.DateAlbume.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DateAlbume.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DateAlbume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateAlbume.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DateAlbume.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DateAlbume.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DateAlbume.DefaultCellStyle = dataGridViewCellStyle5;
            this.DateAlbume.EnableHeadersVisualStyles = false;
            this.DateAlbume.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DateAlbume.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DateAlbume.Location = new System.Drawing.Point(454, 169);
            this.DateAlbume.Name = "DateAlbume";
            this.DateAlbume.ReadOnly = true;
            this.DateAlbume.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateAlbume.RowHeadersVisible = false;
            this.DateAlbume.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle6.NullValue = "null";
            this.DateAlbume.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DateAlbume.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DateAlbume.RowTemplate.Height = 24;
            this.DateAlbume.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DateAlbume.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DateAlbume.Size = new System.Drawing.Size(571, 375);
            this.DateAlbume.TabIndex = 145;
            this.DateAlbume.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DateAlbume_CellContentClick);
            // 
            // Date_IDcasa
            // 
            this.Date_IDcasa.AllowUserToResizeColumns = false;
            this.Date_IDcasa.AllowUserToResizeRows = false;
            this.Date_IDcasa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Date_IDcasa.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Date_IDcasa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Date_IDcasa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Date_IDcasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Date_IDcasa.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Date_IDcasa.DefaultCellStyle = dataGridViewCellStyle7;
            this.Date_IDcasa.EnableHeadersVisualStyles = false;
            this.Date_IDcasa.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Date_IDcasa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Date_IDcasa.Location = new System.Drawing.Point(14, 421);
            this.Date_IDcasa.Name = "Date_IDcasa";
            this.Date_IDcasa.ReadOnly = true;
            this.Date_IDcasa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Date_IDcasa.RowHeadersVisible = false;
            this.Date_IDcasa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle8.NullValue = "null";
            this.Date_IDcasa.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.Date_IDcasa.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Date_IDcasa.RowTemplate.Height = 24;
            this.Date_IDcasa.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Date_IDcasa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Date_IDcasa.Size = new System.Drawing.Size(265, 174);
            this.Date_IDcasa.TabIndex = 146;
            this.Date_IDcasa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Date_IDcasa_CellContentClick);
            // 
            // IDAlbum
            // 
            this.IDAlbum.AutoSize = true;
            this.IDAlbum.BackColor = System.Drawing.Color.Transparent;
            this.IDAlbum.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDAlbum.Location = new System.Drawing.Point(13, 79);
            this.IDAlbum.Name = "IDAlbum";
            this.IDAlbum.Size = new System.Drawing.Size(97, 26);
            this.IDAlbum.TabIndex = 147;
            this.IDAlbum.Text = "ID album";
            this.IDAlbum.Visible = false;
            this.IDAlbum.Click += new System.EventHandler(this.IDAlbum_Click);
            // 
            // ID_album
            // 
            this.ID_album.AcceptsReturn = true;
            this.ID_album.Enabled = false;
            this.ID_album.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_album.Location = new System.Drawing.Point(195, 77);
            this.ID_album.Name = "ID_album";
            this.ID_album.Size = new System.Drawing.Size(248, 29);
            this.ID_album.TabIndex = 148;
            this.ID_album.Visible = false;
            this.ID_album.TextChanged += new System.EventHandler(this.ID_album_TextChanged);
            // 
            // Nume_artist
            // 
            this.Nume_artist.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nume_artist.Location = new System.Drawing.Point(195, 168);
            this.Nume_artist.Name = "Nume_artist";
            this.Nume_artist.Size = new System.Drawing.Size(248, 29);
            this.Nume_artist.TabIndex = 149;
            // 
            // NumeArtist
            // 
            this.NumeArtist.AutoSize = true;
            this.NumeArtist.BackColor = System.Drawing.Color.Transparent;
            this.NumeArtist.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeArtist.Location = new System.Drawing.Point(14, 171);
            this.NumeArtist.Name = "NumeArtist";
            this.NumeArtist.Size = new System.Drawing.Size(132, 26);
            this.NumeArtist.TabIndex = 150;
            this.NumeArtist.Text = "Nume artist*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(976, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 42);
            this.pictureBox1.TabIndex = 172;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Tip_sortare
            // 
            this.Tip_sortare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tip_sortare.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tip_sortare.FormattingEnabled = true;
            this.Tip_sortare.Items.AddRange(new object[] {
            "asc",
            "desc"});
            this.Tip_sortare.Location = new System.Drawing.Point(288, 421);
            this.Tip_sortare.Name = "Tip_sortare";
            this.Tip_sortare.Size = new System.Drawing.Size(119, 28);
            this.Tip_sortare.TabIndex = 181;
            this.Tip_sortare.SelectedIndexChanged += new System.EventHandler(this.Tip_sortare_SelectedIndexChanged);
            // 
            // Sortare_coloana
            // 
            this.Sortare_coloana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sortare_coloana.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sortare_coloana.FormattingEnabled = true;
            this.Sortare_coloana.Items.AddRange(new object[] {
            "id_album",
            "nume_album",
            "nume_artist",
            "format_album",
            "data_lansare",
            "CUI_casa"});
            this.Sortare_coloana.Location = new System.Drawing.Point(288, 387);
            this.Sortare_coloana.Name = "Sortare_coloana";
            this.Sortare_coloana.Size = new System.Drawing.Size(160, 28);
            this.Sortare_coloana.TabIndex = 180;
            this.Sortare_coloana.SelectedIndexChanged += new System.EventHandler(this.Sortare_coloana_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 179;
            this.label1.Text = "Sortare după";
            // 
            // Albume
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
            this.Controls.Add(this.Nume_artist);
            this.Controls.Add(this.NumeArtist);
            this.Controls.Add(this.ID_album);
            this.Controls.Add(this.IDAlbum);
            this.Controls.Add(this.Date_IDcasa);
            this.Controls.Add(this.DateAlbume);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Cautare_id_casa);
            this.Controls.Add(this.CautareIDCasa);
            this.Controls.Add(this.Data_lansare);
            this.Controls.Add(this.Format_album);
            this.Controls.Add(this.Cautare_albume);
            this.Controls.Add(this.SearchMagazine);
            this.Controls.Add(this.DeleteAlbume);
            this.Controls.Add(this.InsertAlbume);
            this.Controls.Add(this.UpdateAlbume);
            this.Controls.Add(this.ID_casa);
            this.Controls.Add(this.Nume_album);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataLansare);
            this.Controls.Add(this.FormatAlbum);
            this.Controls.Add(this.NumeAlbum);
            this.Controls.Add(this.Album);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Albume";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Albume_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateAlbume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date_IDcasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Cautare_albume;
        private System.Windows.Forms.Label SearchMagazine;
        private System.Windows.Forms.Button DeleteAlbume;
        private System.Windows.Forms.Button InsertAlbume;
        private System.Windows.Forms.Button UpdateAlbume;
        private System.Windows.Forms.TextBox ID_casa;
        private System.Windows.Forms.TextBox Nume_album;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DataLansare;
        private System.Windows.Forms.Label FormatAlbum;
        private System.Windows.Forms.Label NumeAlbum;
        private System.Windows.Forms.Label Album;
        private System.Windows.Forms.ComboBox Format_album;
        private System.Windows.Forms.DateTimePicker Data_lansare;
        private System.Windows.Forms.Label CautareIDCasa;
        private System.Windows.Forms.TextBox Cautare_id_casa;
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.DataGridView DateAlbume;
        private System.Windows.Forms.DataGridView Date_IDcasa;
        private System.Windows.Forms.Label IDAlbum;
        private System.Windows.Forms.TextBox ID_album;
        private System.Windows.Forms.TextBox Nume_artist;
        private System.Windows.Forms.Label NumeArtist;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Tip_sortare;
        private System.Windows.Forms.ComboBox Sortare_coloana;
        private System.Windows.Forms.Label label1;
    }
}