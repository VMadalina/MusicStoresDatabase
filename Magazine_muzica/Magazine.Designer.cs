namespace Magazine_muzica
{
    partial class Magazine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Magazine));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Magazin = new System.Windows.Forms.Label();
            this.NumeMagazin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tip_strada = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nume_magazin = new System.Windows.Forms.TextBox();
            this.oras = new System.Windows.Forms.TextBox();
            this.Nume_strada = new System.Windows.Forms.TextBox();
            this.Numar_strada = new System.Windows.Forms.TextBox();
            this.UpdateMagazine = new System.Windows.Forms.Button();
            this.InsertMagazine = new System.Windows.Forms.Button();
            this.DeleteMagazine = new System.Windows.Forms.Button();
            this.SearchMagazine = new System.Windows.Forms.Label();
            this.Cautare_magazin = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IDMagazin = new System.Windows.Forms.Label();
            this.ID_magazin = new System.Windows.Forms.TextBox();
            this.DateMagazine = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Tip_sortare = new System.Windows.Forms.ComboBox();
            this.Sortare_coloana = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateMagazine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Magazin
            // 
            this.Magazin.AutoSize = true;
            this.Magazin.BackColor = System.Drawing.Color.Transparent;
            this.Magazin.Font = new System.Drawing.Font("Cambria", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Magazin.Location = new System.Drawing.Point(378, 24);
            this.Magazin.Name = "Magazin";
            this.Magazin.Size = new System.Drawing.Size(207, 49);
            this.Magazin.TabIndex = 0;
            this.Magazin.Text = "Magazine";
            // 
            // NumeMagazin
            // 
            this.NumeMagazin.AutoSize = true;
            this.NumeMagazin.BackColor = System.Drawing.Color.Transparent;
            this.NumeMagazin.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeMagazin.Location = new System.Drawing.Point(33, 170);
            this.NumeMagazin.Name = "NumeMagazin";
            this.NumeMagazin.Size = new System.Drawing.Size(175, 28);
            this.NumeMagazin.TabIndex = 1;
            this.NumeMagazin.Text = "Nume magazin*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Oraș*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tip stradă*";
            // 
            // Tip_strada
            // 
            this.Tip_strada.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tip_strada.FormattingEnabled = true;
            this.Tip_strada.Items.AddRange(new object[] {
            "Aleea",
            "Bulevardul",
            "Calea",
            "Piata",
            "Strada"});
            this.Tip_strada.Location = new System.Drawing.Point(232, 300);
            this.Tip_strada.Name = "Tip_strada";
            this.Tip_strada.Size = new System.Drawing.Size(204, 31);
            this.Tip_strada.TabIndex = 3;
            this.Tip_strada.SelectedIndexChanged += new System.EventHandler(this.Tip_strada_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nume stradă*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Număr stradă*";
            // 
            // Nume_magazin
            // 
            this.Nume_magazin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nume_magazin.Location = new System.Drawing.Point(232, 169);
            this.Nume_magazin.Name = "Nume_magazin";
            this.Nume_magazin.Size = new System.Drawing.Size(204, 31);
            this.Nume_magazin.TabIndex = 1;
            // 
            // oras
            // 
            this.oras.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oras.Location = new System.Drawing.Point(232, 235);
            this.oras.Name = "oras";
            this.oras.Size = new System.Drawing.Size(204, 31);
            this.oras.TabIndex = 2;
            // 
            // Nume_strada
            // 
            this.Nume_strada.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nume_strada.Location = new System.Drawing.Point(232, 367);
            this.Nume_strada.Name = "Nume_strada";
            this.Nume_strada.Size = new System.Drawing.Size(204, 31);
            this.Nume_strada.TabIndex = 4;
            // 
            // Numar_strada
            // 
            this.Numar_strada.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numar_strada.Location = new System.Drawing.Point(232, 433);
            this.Numar_strada.Name = "Numar_strada";
            this.Numar_strada.Size = new System.Drawing.Size(204, 31);
            this.Numar_strada.TabIndex = 5;
            // 
            // UpdateMagazine
            // 
            this.UpdateMagazine.BackColor = System.Drawing.Color.White;
            this.UpdateMagazine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UpdateMagazine.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UpdateMagazine.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateMagazine.Location = new System.Drawing.Point(182, 498);
            this.UpdateMagazine.Name = "UpdateMagazine";
            this.UpdateMagazine.Size = new System.Drawing.Size(106, 42);
            this.UpdateMagazine.TabIndex = 7;
            this.UpdateMagazine.Text = "Modificare";
            this.UpdateMagazine.UseVisualStyleBackColor = false;
            this.UpdateMagazine.Click += new System.EventHandler(this.UpdateMagazine_Click);
            // 
            // InsertMagazine
            // 
            this.InsertMagazine.BackColor = System.Drawing.Color.White;
            this.InsertMagazine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InsertMagazine.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.InsertMagazine.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertMagazine.Location = new System.Drawing.Point(34, 498);
            this.InsertMagazine.Name = "InsertMagazine";
            this.InsertMagazine.Size = new System.Drawing.Size(97, 42);
            this.InsertMagazine.TabIndex = 6;
            this.InsertMagazine.Text = "Adăugare";
            this.InsertMagazine.UseVisualStyleBackColor = false;
            this.InsertMagazine.Click += new System.EventHandler(this.InsertMagazine_Click);
            // 
            // DeleteMagazine
            // 
            this.DeleteMagazine.BackColor = System.Drawing.Color.White;
            this.DeleteMagazine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteMagazine.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DeleteMagazine.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteMagazine.Location = new System.Drawing.Point(335, 498);
            this.DeleteMagazine.Name = "DeleteMagazine";
            this.DeleteMagazine.Size = new System.Drawing.Size(97, 42);
            this.DeleteMagazine.TabIndex = 8;
            this.DeleteMagazine.Text = "Ștergere";
            this.DeleteMagazine.UseVisualStyleBackColor = false;
            this.DeleteMagazine.Click += new System.EventHandler(this.DeleteMagazine_Click);
            // 
            // SearchMagazine
            // 
            this.SearchMagazine.AutoSize = true;
            this.SearchMagazine.BackColor = System.Drawing.Color.Transparent;
            this.SearchMagazine.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMagazine.Location = new System.Drawing.Point(470, 123);
            this.SearchMagazine.Name = "SearchMagazine";
            this.SearchMagazine.Size = new System.Drawing.Size(93, 28);
            this.SearchMagazine.TabIndex = 16;
            this.SearchMagazine.Text = "Căutare";
            // 
            // Cautare_magazin
            // 
            this.Cautare_magazin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cautare_magazin.Location = new System.Drawing.Point(568, 120);
            this.Cautare_magazin.Name = "Cautare_magazin";
            this.Cautare_magazin.Size = new System.Drawing.Size(451, 31);
            this.Cautare_magazin.TabIndex = 9;
            this.Cautare_magazin.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(48, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // IDMagazin
            // 
            this.IDMagazin.AutoSize = true;
            this.IDMagazin.BackColor = System.Drawing.Color.Transparent;
            this.IDMagazin.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDMagazin.Location = new System.Drawing.Point(33, 102);
            this.IDMagazin.Name = "IDMagazin";
            this.IDMagazin.Size = new System.Drawing.Size(130, 28);
            this.IDMagazin.TabIndex = 72;
            this.IDMagazin.Text = "ID magazin";
            this.IDMagazin.Visible = false;
            // 
            // ID_magazin
            // 
            this.ID_magazin.AcceptsReturn = true;
            this.ID_magazin.Enabled = false;
            this.ID_magazin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_magazin.Location = new System.Drawing.Point(232, 102);
            this.ID_magazin.Name = "ID_magazin";
            this.ID_magazin.Size = new System.Drawing.Size(204, 31);
            this.ID_magazin.TabIndex = 0;
            this.ID_magazin.Visible = false;
            // 
            // DateMagazine
            // 
            this.DateMagazine.AllowUserToResizeColumns = false;
            this.DateMagazine.AllowUserToResizeRows = false;
            this.DateMagazine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DateMagazine.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DateMagazine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateMagazine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DateMagazine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DateMagazine.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DateMagazine.DefaultCellStyle = dataGridViewCellStyle3;
            this.DateMagazine.EnableHeadersVisualStyles = false;
            this.DateMagazine.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DateMagazine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DateMagazine.Location = new System.Drawing.Point(475, 169);
            this.DateMagazine.Name = "DateMagazine";
            this.DateMagazine.ReadOnly = true;
            this.DateMagazine.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateMagazine.RowHeadersVisible = false;
            this.DateMagazine.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.NullValue = "null";
            this.DateMagazine.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DateMagazine.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DateMagazine.RowTemplate.Height = 24;
            this.DateMagazine.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DateMagazine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DateMagazine.Size = new System.Drawing.Size(544, 436);
            this.DateMagazine.TabIndex = 73;
            this.DateMagazine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DateMagazine_CellContentClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(976, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 42);
            this.pictureBox2.TabIndex = 172;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Tip_sortare
            // 
            this.Tip_sortare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tip_sortare.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tip_sortare.FormattingEnabled = true;
            this.Tip_sortare.Items.AddRange(new object[] {
            "asc",
            "desc"});
            this.Tip_sortare.Location = new System.Drawing.Point(330, 565);
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
            "nume_magazin",
            "oras",
            "tip_strada",
            "numele_strazii",
            "numarul_strazii"});
            this.Sortare_coloana.Location = new System.Drawing.Point(140, 565);
            this.Sortare_coloana.Name = "Sortare_coloana";
            this.Sortare_coloana.Size = new System.Drawing.Size(172, 29);
            this.Sortare_coloana.TabIndex = 186;
            this.Sortare_coloana.SelectedIndexChanged += new System.EventHandler(this.Sortare_coloana_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 566);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 185;
            this.label5.Text = "Sortare după";
            // 
            // Magazine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 617);
            this.Controls.Add(this.Tip_sortare);
            this.Controls.Add(this.Sortare_coloana);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.DateMagazine);
            this.Controls.Add(this.ID_magazin);
            this.Controls.Add(this.IDMagazin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Cautare_magazin);
            this.Controls.Add(this.SearchMagazine);
            this.Controls.Add(this.DeleteMagazine);
            this.Controls.Add(this.InsertMagazine);
            this.Controls.Add(this.UpdateMagazine);
            this.Controls.Add(this.Numar_strada);
            this.Controls.Add(this.Nume_strada);
            this.Controls.Add(this.oras);
            this.Controls.Add(this.Nume_magazin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tip_strada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumeMagazin);
            this.Controls.Add(this.Magazin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Magazine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magazine";
            this.Load += new System.EventHandler(this.Magazine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateMagazine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label Magazin;
        private System.Windows.Forms.Label NumeMagazin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Tip_strada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nume_magazin;
        private System.Windows.Forms.TextBox oras;
        private System.Windows.Forms.TextBox Nume_strada;
        private System.Windows.Forms.TextBox Numar_strada;
        private System.Windows.Forms.Button UpdateMagazine;
        private System.Windows.Forms.Button InsertMagazine;
        private System.Windows.Forms.Button DeleteMagazine;
        private System.Windows.Forms.Label SearchMagazine;
        private System.Windows.Forms.TextBox Cautare_magazin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label IDMagazin;
        private System.Windows.Forms.TextBox ID_magazin;
        private System.Windows.Forms.DataGridView DateMagazine;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox Tip_sortare;
        private System.Windows.Forms.ComboBox Sortare_coloana;
        private System.Windows.Forms.Label label5;
    }
}