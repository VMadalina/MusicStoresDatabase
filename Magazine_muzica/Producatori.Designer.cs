namespace Magazine_muzica
{
    partial class Producatori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producatori));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Cautare_producatori = new System.Windows.Forms.TextBox();
            this.SearchProducatori = new System.Windows.Forms.Label();
            this.DeleteProducator = new System.Windows.Forms.Button();
            this.InsertProducator = new System.Windows.Forms.Button();
            this.UpdateProducator = new System.Windows.Forms.Button();
            this.An_producator = new System.Windows.Forms.TextBox();
            this.Sediu_central = new System.Windows.Forms.TextBox();
            this.Nume_producator = new System.Windows.Forms.TextBox();
            this.CUI_producator = new System.Windows.Forms.TextBox();
            this.AnProducator = new System.Windows.Forms.Label();
            this.SediuCentral = new System.Windows.Forms.Label();
            this.TelProducator = new System.Windows.Forms.Label();
            this.NumeProducator = new System.Windows.Forms.Label();
            this.CUI = new System.Windows.Forms.Label();
            this.Producator = new System.Windows.Forms.Label();
            this.Tel_producator = new System.Windows.Forms.TextBox();
            this.Text3 = new System.Windows.Forms.Label();
            this.Text2 = new System.Windows.Forms.Label();
            this.Text1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.PictureBox();
            this.DateProducator = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tip_sortare = new System.Windows.Forms.ComboBox();
            this.Sortare_coloana = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateProducator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cautare_producatori
            // 
            this.Cautare_producatori.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cautare_producatori.Location = new System.Drawing.Point(533, 117);
            this.Cautare_producatori.Name = "Cautare_producatori";
            this.Cautare_producatori.Size = new System.Drawing.Size(477, 31);
            this.Cautare_producatori.TabIndex = 8;
            this.Cautare_producatori.TextChanged += new System.EventHandler(this.Cautare_producatori_TextChanged);
            // 
            // SearchProducatori
            // 
            this.SearchProducatori.AutoSize = true;
            this.SearchProducatori.BackColor = System.Drawing.Color.Transparent;
            this.SearchProducatori.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchProducatori.Location = new System.Drawing.Point(432, 120);
            this.SearchProducatori.Name = "SearchProducatori";
            this.SearchProducatori.Size = new System.Drawing.Size(93, 28);
            this.SearchProducatori.TabIndex = 33;
            this.SearchProducatori.Text = "Căutare";
            // 
            // DeleteProducator
            // 
            this.DeleteProducator.BackColor = System.Drawing.Color.White;
            this.DeleteProducator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteProducator.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DeleteProducator.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProducator.Location = new System.Drawing.Point(825, 563);
            this.DeleteProducator.Name = "DeleteProducator";
            this.DeleteProducator.Size = new System.Drawing.Size(97, 42);
            this.DeleteProducator.TabIndex = 7;
            this.DeleteProducator.Text = "Ștergere";
            this.DeleteProducator.UseVisualStyleBackColor = false;
            this.DeleteProducator.Click += new System.EventHandler(this.DeleteProducator_Click);
            // 
            // InsertProducator
            // 
            this.InsertProducator.BackColor = System.Drawing.Color.White;
            this.InsertProducator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InsertProducator.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.InsertProducator.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertProducator.Location = new System.Drawing.Point(524, 563);
            this.InsertProducator.Name = "InsertProducator";
            this.InsertProducator.Size = new System.Drawing.Size(97, 42);
            this.InsertProducator.TabIndex = 5;
            this.InsertProducator.Text = "Adăugare";
            this.InsertProducator.UseVisualStyleBackColor = false;
            this.InsertProducator.Click += new System.EventHandler(this.InsertProducator_Click);
            // 
            // UpdateProducator
            // 
            this.UpdateProducator.BackColor = System.Drawing.Color.White;
            this.UpdateProducator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UpdateProducator.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UpdateProducator.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateProducator.Location = new System.Drawing.Point(672, 563);
            this.UpdateProducator.Name = "UpdateProducator";
            this.UpdateProducator.Size = new System.Drawing.Size(106, 42);
            this.UpdateProducator.TabIndex = 6;
            this.UpdateProducator.Text = "Modificare";
            this.UpdateProducator.UseVisualStyleBackColor = false;
            this.UpdateProducator.Click += new System.EventHandler(this.UpdateProducator_Click);
            // 
            // An_producator
            // 
            this.An_producator.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.An_producator.Location = new System.Drawing.Point(227, 291);
            this.An_producator.Name = "An_producator";
            this.An_producator.Size = new System.Drawing.Size(193, 31);
            this.An_producator.TabIndex = 2;
            // 
            // Sediu_central
            // 
            this.Sediu_central.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sediu_central.Location = new System.Drawing.Point(227, 412);
            this.Sediu_central.Name = "Sediu_central";
            this.Sediu_central.Size = new System.Drawing.Size(193, 31);
            this.Sediu_central.TabIndex = 4;
            // 
            // Nume_producator
            // 
            this.Nume_producator.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nume_producator.Location = new System.Drawing.Point(227, 227);
            this.Nume_producator.Name = "Nume_producator";
            this.Nume_producator.Size = new System.Drawing.Size(193, 31);
            this.Nume_producator.TabIndex = 1;
            // 
            // CUI_producator
            // 
            this.CUI_producator.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUI_producator.Location = new System.Drawing.Point(227, 166);
            this.CUI_producator.Name = "CUI_producator";
            this.CUI_producator.Size = new System.Drawing.Size(193, 31);
            this.CUI_producator.TabIndex = 0;
            // 
            // AnProducator
            // 
            this.AnProducator.AutoSize = true;
            this.AnProducator.BackColor = System.Drawing.Color.Transparent;
            this.AnProducator.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnProducator.Location = new System.Drawing.Point(17, 291);
            this.AnProducator.Name = "AnProducator";
            this.AnProducator.Size = new System.Drawing.Size(162, 28);
            this.AnProducator.TabIndex = 24;
            this.AnProducator.Text = "Anul înființării";
            // 
            // SediuCentral
            // 
            this.SediuCentral.AutoSize = true;
            this.SediuCentral.BackColor = System.Drawing.Color.Transparent;
            this.SediuCentral.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SediuCentral.Location = new System.Drawing.Point(17, 412);
            this.SediuCentral.Name = "SediuCentral";
            this.SediuCentral.Size = new System.Drawing.Size(144, 28);
            this.SediuCentral.TabIndex = 23;
            this.SediuCentral.Text = "Sediu central";
            // 
            // TelProducator
            // 
            this.TelProducator.AutoSize = true;
            this.TelProducator.BackColor = System.Drawing.Color.Transparent;
            this.TelProducator.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelProducator.Location = new System.Drawing.Point(17, 354);
            this.TelProducator.Name = "TelProducator";
            this.TelProducator.Size = new System.Drawing.Size(166, 28);
            this.TelProducator.TabIndex = 21;
            this.TelProducator.Text = "Număr telefon*";
            // 
            // NumeProducator
            // 
            this.NumeProducator.AutoSize = true;
            this.NumeProducator.BackColor = System.Drawing.Color.Transparent;
            this.NumeProducator.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeProducator.Location = new System.Drawing.Point(17, 230);
            this.NumeProducator.Name = "NumeProducator";
            this.NumeProducator.Size = new System.Drawing.Size(200, 28);
            this.NumeProducator.TabIndex = 20;
            this.NumeProducator.Text = "Nume producător*";
            // 
            // CUI
            // 
            this.CUI.AutoSize = true;
            this.CUI.BackColor = System.Drawing.Color.Transparent;
            this.CUI.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUI.Location = new System.Drawing.Point(17, 166);
            this.CUI.Name = "CUI";
            this.CUI.Size = new System.Drawing.Size(58, 28);
            this.CUI.TabIndex = 19;
            this.CUI.Text = "CUI*";
            // 
            // Producator
            // 
            this.Producator.AutoSize = true;
            this.Producator.BackColor = System.Drawing.Color.Transparent;
            this.Producator.Font = new System.Drawing.Font("Cambria", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Producator.Location = new System.Drawing.Point(353, 28);
            this.Producator.Name = "Producator";
            this.Producator.Size = new System.Drawing.Size(251, 49);
            this.Producator.TabIndex = 18;
            this.Producator.Text = "Producători";
            // 
            // Tel_producator
            // 
            this.Tel_producator.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tel_producator.Location = new System.Drawing.Point(227, 354);
            this.Tel_producator.Name = "Tel_producator";
            this.Tel_producator.Size = new System.Drawing.Size(193, 31);
            this.Tel_producator.TabIndex = 3;
            // 
            // Text3
            // 
            this.Text3.AutoEllipsis = true;
            this.Text3.AutoSize = true;
            this.Text3.BackColor = System.Drawing.Color.Transparent;
            this.Text3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text3.Location = new System.Drawing.Point(19, 507);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(150, 17);
            this.Text3.TabIndex = 72;
            this.Text3.Text = "Exemplu: 0367891234";
            // 
            // Text2
            // 
            this.Text2.AutoEllipsis = true;
            this.Text2.AutoSize = true;
            this.Text2.BackColor = System.Drawing.Color.Transparent;
            this.Text2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text2.Location = new System.Drawing.Point(19, 477);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(281, 17);
            this.Text2.TabIndex = 71;
            this.Text2.Text = "utiliza caractere pentru despărțirea cifrelor.";
            // 
            // Text1
            // 
            this.Text1.AutoEllipsis = true;
            this.Text1.AutoSize = true;
            this.Text1.BackColor = System.Drawing.Color.Transparent;
            this.Text1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text1.Location = new System.Drawing.Point(19, 460);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(291, 17);
            this.Text1.TabIndex = 70;
            this.Text1.Text = "*Numărul de telefon va fi trecut simplu, fără a";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Location = new System.Drawing.Point(22, 27);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(51, 50);
            this.Back.TabIndex = 73;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // DateProducator
            // 
            this.DateProducator.AllowUserToResizeColumns = false;
            this.DateProducator.AllowUserToResizeRows = false;
            this.DateProducator.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DateProducator.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DateProducator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateProducator.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DateProducator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DateProducator.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DateProducator.DefaultCellStyle = dataGridViewCellStyle7;
            this.DateProducator.EnableHeadersVisualStyles = false;
            this.DateProducator.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DateProducator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DateProducator.Location = new System.Drawing.Point(437, 166);
            this.DateProducator.Name = "DateProducator";
            this.DateProducator.ReadOnly = true;
            this.DateProducator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateProducator.RowHeadersVisible = false;
            this.DateProducator.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle8.NullValue = "null";
            this.DateProducator.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DateProducator.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DateProducator.RowTemplate.Height = 24;
            this.DateProducator.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DateProducator.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DateProducator.Size = new System.Drawing.Size(573, 391);
            this.DateProducator.TabIndex = 9;
            this.DateProducator.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DateProducator_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(976, 27);
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
            this.Tip_sortare.Location = new System.Drawing.Point(321, 576);
            this.Tip_sortare.Name = "Tip_sortare";
            this.Tip_sortare.Size = new System.Drawing.Size(119, 29);
            this.Tip_sortare.TabIndex = 190;
            this.Tip_sortare.SelectedIndexChanged += new System.EventHandler(this.Tip_sortare_SelectedIndexChanged);
            // 
            // Sortare_coloana
            // 
            this.Sortare_coloana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sortare_coloana.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sortare_coloana.FormattingEnabled = true;
            this.Sortare_coloana.Items.AddRange(new object[] {
            "CUI",
            "nume_producator",
            "an_infiintare",
            "numar_telefon",
            "sediu_central"});
            this.Sortare_coloana.Location = new System.Drawing.Point(138, 576);
            this.Sortare_coloana.Name = "Sortare_coloana";
            this.Sortare_coloana.Size = new System.Drawing.Size(172, 29);
            this.Sortare_coloana.TabIndex = 189;
            this.Sortare_coloana.SelectedIndexChanged += new System.EventHandler(this.Sortare_coloana_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 579);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 188;
            this.label1.Text = "Sortare după";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Producatori
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
            this.Controls.Add(this.DateProducator);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.Tel_producator);
            this.Controls.Add(this.Cautare_producatori);
            this.Controls.Add(this.SearchProducatori);
            this.Controls.Add(this.DeleteProducator);
            this.Controls.Add(this.InsertProducator);
            this.Controls.Add(this.UpdateProducator);
            this.Controls.Add(this.An_producator);
            this.Controls.Add(this.Sediu_central);
            this.Controls.Add(this.Nume_producator);
            this.Controls.Add(this.CUI_producator);
            this.Controls.Add(this.AnProducator);
            this.Controls.Add(this.SediuCentral);
            this.Controls.Add(this.TelProducator);
            this.Controls.Add(this.NumeProducator);
            this.Controls.Add(this.CUI);
            this.Controls.Add(this.Producator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Producatori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producatori";
            this.Load += new System.EventHandler(this.Producatori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateProducator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Cautare_producatori;
        private System.Windows.Forms.Label SearchProducatori;
        private System.Windows.Forms.Button DeleteProducator;
        private System.Windows.Forms.Button InsertProducator;
        private System.Windows.Forms.Button UpdateProducator;
        private System.Windows.Forms.TextBox An_producator;
        private System.Windows.Forms.TextBox Sediu_central;
        private System.Windows.Forms.TextBox Nume_producator;
        private System.Windows.Forms.TextBox CUI_producator;
        private System.Windows.Forms.Label AnProducator;
        private System.Windows.Forms.Label SediuCentral;
        private System.Windows.Forms.Label TelProducator;
        private System.Windows.Forms.Label NumeProducator;
        private System.Windows.Forms.Label CUI;
        private System.Windows.Forms.Label Producator;
        private System.Windows.Forms.TextBox Tel_producator;
        private System.Windows.Forms.Label Text3;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.DataGridView DateProducator;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Tip_sortare;
        private System.Windows.Forms.ComboBox Sortare_coloana;
        private System.Windows.Forms.Label label1;
    }
}