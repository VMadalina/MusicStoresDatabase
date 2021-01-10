namespace Magazine_muzica
{
    partial class Accesorii
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accesorii));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DeleteAccesoriu = new System.Windows.Forms.Button();
            this.InsertAccesoriu = new System.Windows.Forms.Button();
            this.UpdateAccesoriu = new System.Windows.Forms.Button();
            this.Obiect_compatibil = new System.Windows.Forms.TextBox();
            this.Cautare_accesorii = new System.Windows.Forms.TextBox();
            this.SearchAccesoriu = new System.Windows.Forms.Label();
            this.Nume_accesoriu = new System.Windows.Forms.TextBox();
            this.TipInstrument = new System.Windows.Forms.Label();
            this.ObiectCompatibil = new System.Windows.Forms.Label();
            this.NumeAccesoriu = new System.Windows.Forms.Label();
            this.Accesoriu = new System.Windows.Forms.Label();
            this.Tip_instrument = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.PictureBox();
            this.DateAccesorii = new System.Windows.Forms.DataGridView();
            this.IDAccesoriu = new System.Windows.Forms.Label();
            this.ID_accesoriu = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sortare_coloana = new System.Windows.Forms.ComboBox();
            this.Tip_sortare = new System.Windows.Forms.ComboBox();
            this.magazine_muzicaDataSet = new Magazine_muzica.Magazine_muzicaDataSet();
            this.accesoriiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accesoriiTableAdapter = new Magazine_muzica.Magazine_muzicaDataSetTableAdapters.accesoriiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateAccesorii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazine_muzicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accesoriiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteAccesoriu
            // 
            this.DeleteAccesoriu.BackColor = System.Drawing.Color.White;
            this.DeleteAccesoriu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteAccesoriu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DeleteAccesoriu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAccesoriu.Location = new System.Drawing.Point(299, 435);
            this.DeleteAccesoriu.Name = "DeleteAccesoriu";
            this.DeleteAccesoriu.Size = new System.Drawing.Size(97, 42);
            this.DeleteAccesoriu.TabIndex = 6;
            this.DeleteAccesoriu.Text = "Ștergere";
            this.DeleteAccesoriu.UseVisualStyleBackColor = false;
            this.DeleteAccesoriu.Click += new System.EventHandler(this.DeleteEdituri_Click);
            // 
            // InsertAccesoriu
            // 
            this.InsertAccesoriu.BackColor = System.Drawing.Color.White;
            this.InsertAccesoriu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InsertAccesoriu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.InsertAccesoriu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertAccesoriu.Location = new System.Drawing.Point(33, 435);
            this.InsertAccesoriu.Name = "InsertAccesoriu";
            this.InsertAccesoriu.Size = new System.Drawing.Size(97, 42);
            this.InsertAccesoriu.TabIndex = 4;
            this.InsertAccesoriu.Text = "Adăugare";
            this.InsertAccesoriu.UseVisualStyleBackColor = false;
            this.InsertAccesoriu.Click += new System.EventHandler(this.InsertEditura_Click);
            // 
            // UpdateAccesoriu
            // 
            this.UpdateAccesoriu.BackColor = System.Drawing.Color.White;
            this.UpdateAccesoriu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UpdateAccesoriu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UpdateAccesoriu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateAccesoriu.Location = new System.Drawing.Point(166, 435);
            this.UpdateAccesoriu.Name = "UpdateAccesoriu";
            this.UpdateAccesoriu.Size = new System.Drawing.Size(106, 42);
            this.UpdateAccesoriu.TabIndex = 5;
            this.UpdateAccesoriu.Text = "Modificare";
            this.UpdateAccesoriu.UseVisualStyleBackColor = false;
            this.UpdateAccesoriu.Click += new System.EventHandler(this.UpdateAccesoriu_Click);
            // 
            // Obiect_compatibil
            // 
            this.Obiect_compatibil.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Obiect_compatibil.Location = new System.Drawing.Point(223, 282);
            this.Obiect_compatibil.Name = "Obiect_compatibil";
            this.Obiect_compatibil.Size = new System.Drawing.Size(219, 31);
            this.Obiect_compatibil.TabIndex = 2;
            // 
            // Cautare_accesorii
            // 
            this.Cautare_accesorii.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cautare_accesorii.Location = new System.Drawing.Point(569, 167);
            this.Cautare_accesorii.Name = "Cautare_accesorii";
            this.Cautare_accesorii.Size = new System.Drawing.Size(450, 31);
            this.Cautare_accesorii.TabIndex = 7;
            this.Cautare_accesorii.TextChanged += new System.EventHandler(this.Cautare_accesorii_TextChanged);
            // 
            // SearchAccesoriu
            // 
            this.SearchAccesoriu.AutoSize = true;
            this.SearchAccesoriu.BackColor = System.Drawing.Color.Transparent;
            this.SearchAccesoriu.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchAccesoriu.Location = new System.Drawing.Point(470, 167);
            this.SearchAccesoriu.Name = "SearchAccesoriu";
            this.SearchAccesoriu.Size = new System.Drawing.Size(93, 28);
            this.SearchAccesoriu.TabIndex = 77;
            this.SearchAccesoriu.Text = "Căutare";
            this.SearchAccesoriu.Click += new System.EventHandler(this.SearchAccesoriu_Click);
            // 
            // Nume_accesoriu
            // 
            this.Nume_accesoriu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nume_accesoriu.Location = new System.Drawing.Point(223, 216);
            this.Nume_accesoriu.Name = "Nume_accesoriu";
            this.Nume_accesoriu.Size = new System.Drawing.Size(219, 31);
            this.Nume_accesoriu.TabIndex = 1;
            // 
            // TipInstrument
            // 
            this.TipInstrument.AutoSize = true;
            this.TipInstrument.BackColor = System.Drawing.Color.Transparent;
            this.TipInstrument.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipInstrument.Location = new System.Drawing.Point(12, 350);
            this.TipInstrument.Name = "TipInstrument";
            this.TipInstrument.Size = new System.Drawing.Size(162, 28);
            this.TipInstrument.TabIndex = 73;
            this.TipInstrument.Text = "Tip instrument";
            // 
            // ObiectCompatibil
            // 
            this.ObiectCompatibil.AutoSize = true;
            this.ObiectCompatibil.BackColor = System.Drawing.Color.Transparent;
            this.ObiectCompatibil.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObiectCompatibil.Location = new System.Drawing.Point(12, 282);
            this.ObiectCompatibil.Name = "ObiectCompatibil";
            this.ObiectCompatibil.Size = new System.Drawing.Size(189, 28);
            this.ObiectCompatibil.TabIndex = 72;
            this.ObiectCompatibil.Text = "Obiect compatibil";
            // 
            // NumeAccesoriu
            // 
            this.NumeAccesoriu.AutoSize = true;
            this.NumeAccesoriu.BackColor = System.Drawing.Color.Transparent;
            this.NumeAccesoriu.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeAccesoriu.Location = new System.Drawing.Point(12, 216);
            this.NumeAccesoriu.Name = "NumeAccesoriu";
            this.NumeAccesoriu.Size = new System.Drawing.Size(181, 28);
            this.NumeAccesoriu.TabIndex = 71;
            this.NumeAccesoriu.Text = "Nume accesoriu*";
            // 
            // Accesoriu
            // 
            this.Accesoriu.AutoSize = true;
            this.Accesoriu.BackColor = System.Drawing.Color.Transparent;
            this.Accesoriu.Font = new System.Drawing.Font("Cambria", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accesoriu.Location = new System.Drawing.Point(421, 46);
            this.Accesoriu.Name = "Accesoriu";
            this.Accesoriu.Size = new System.Drawing.Size(193, 49);
            this.Accesoriu.TabIndex = 70;
            this.Accesoriu.Text = "Accesorii";
            // 
            // Tip_instrument
            // 
            this.Tip_instrument.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tip_instrument.FormattingEnabled = true;
            this.Tip_instrument.Items.AddRange(new object[] {
            "acustic",
            "clasic",
            "electric"});
            this.Tip_instrument.Location = new System.Drawing.Point(223, 350);
            this.Tip_instrument.Name = "Tip_instrument";
            this.Tip_instrument.Size = new System.Drawing.Size(219, 31);
            this.Tip_instrument.TabIndex = 3;
            this.Tip_instrument.SelectedIndexChanged += new System.EventHandler(this.Tip_instrument_SelectedIndexChanged);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Location = new System.Drawing.Point(35, 46);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(51, 50);
            this.Back.TabIndex = 142;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // DateAccesorii
            // 
            this.DateAccesorii.AllowUserToResizeColumns = false;
            this.DateAccesorii.AllowUserToResizeRows = false;
            this.DateAccesorii.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DateAccesorii.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DateAccesorii.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateAccesorii.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DateAccesorii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DateAccesorii.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DateAccesorii.DefaultCellStyle = dataGridViewCellStyle3;
            this.DateAccesorii.EnableHeadersVisualStyles = false;
            this.DateAccesorii.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DateAccesorii.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DateAccesorii.Location = new System.Drawing.Point(475, 216);
            this.DateAccesorii.Name = "DateAccesorii";
            this.DateAccesorii.ReadOnly = true;
            this.DateAccesorii.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateAccesorii.RowHeadersVisible = false;
            this.DateAccesorii.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.NullValue = "null";
            this.DateAccesorii.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DateAccesorii.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DateAccesorii.RowTemplate.Height = 24;
            this.DateAccesorii.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DateAccesorii.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DateAccesorii.Size = new System.Drawing.Size(544, 353);
            this.DateAccesorii.TabIndex = 8;
            this.DateAccesorii.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DateAccesorii_CellContentClick);
            // 
            // IDAccesoriu
            // 
            this.IDAccesoriu.AutoSize = true;
            this.IDAccesoriu.BackColor = System.Drawing.Color.Transparent;
            this.IDAccesoriu.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDAccesoriu.Location = new System.Drawing.Point(12, 127);
            this.IDAccesoriu.Name = "IDAccesoriu";
            this.IDAccesoriu.Size = new System.Drawing.Size(136, 28);
            this.IDAccesoriu.TabIndex = 146;
            this.IDAccesoriu.Text = "ID accesoriu";
            this.IDAccesoriu.Visible = false;
            // 
            // ID_accesoriu
            // 
            this.ID_accesoriu.AcceptsReturn = true;
            this.ID_accesoriu.Enabled = false;
            this.ID_accesoriu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_accesoriu.Location = new System.Drawing.Point(223, 127);
            this.ID_accesoriu.Name = "ID_accesoriu";
            this.ID_accesoriu.Size = new System.Drawing.Size(219, 31);
            this.ID_accesoriu.TabIndex = 0;
            this.ID_accesoriu.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(976, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 42);
            this.pictureBox1.TabIndex = 172;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 545);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 173;
            this.label1.Text = "Sortare după";
            // 
            // Sortare_coloana
            // 
            this.Sortare_coloana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sortare_coloana.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sortare_coloana.FormattingEnabled = true;
            this.Sortare_coloana.Items.AddRange(new object[] {
            "id_accesoriu",
            "nume_accesoriu",
            "obiect_compatibil",
            "tip_instrument"});
            this.Sortare_coloana.Location = new System.Drawing.Point(133, 540);
            this.Sortare_coloana.Name = "Sortare_coloana";
            this.Sortare_coloana.Size = new System.Drawing.Size(172, 29);
            this.Sortare_coloana.TabIndex = 174;
            this.Sortare_coloana.SelectedIndexChanged += new System.EventHandler(this.Sortare_coloana_SelectedIndexChanged);
            // 
            // Tip_sortare
            // 
            this.Tip_sortare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tip_sortare.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tip_sortare.FormattingEnabled = true;
            this.Tip_sortare.Items.AddRange(new object[] {
            "asc",
            "desc"});
            this.Tip_sortare.Location = new System.Drawing.Point(323, 540);
            this.Tip_sortare.Name = "Tip_sortare";
            this.Tip_sortare.Size = new System.Drawing.Size(119, 29);
            this.Tip_sortare.TabIndex = 175;
            this.Tip_sortare.SelectedIndexChanged += new System.EventHandler(this.Tip_sortare_SelectedIndexChanged);
            // 
            // magazine_muzicaDataSet
            // 
            this.magazine_muzicaDataSet.DataSetName = "Magazine_muzicaDataSet";
            this.magazine_muzicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accesoriiBindingSource
            // 
            this.accesoriiBindingSource.DataMember = "accesorii";
            this.accesoriiBindingSource.DataSource = this.magazine_muzicaDataSet;
            // 
            // accesoriiTableAdapter
            // 
            this.accesoriiTableAdapter.ClearBeforeFill = true;
            // 
            // Accesorii
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
            this.Controls.Add(this.ID_accesoriu);
            this.Controls.Add(this.IDAccesoriu);
            this.Controls.Add(this.DateAccesorii);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Tip_instrument);
            this.Controls.Add(this.DeleteAccesoriu);
            this.Controls.Add(this.InsertAccesoriu);
            this.Controls.Add(this.UpdateAccesoriu);
            this.Controls.Add(this.Obiect_compatibil);
            this.Controls.Add(this.Cautare_accesorii);
            this.Controls.Add(this.SearchAccesoriu);
            this.Controls.Add(this.Nume_accesoriu);
            this.Controls.Add(this.TipInstrument);
            this.Controls.Add(this.ObiectCompatibil);
            this.Controls.Add(this.NumeAccesoriu);
            this.Controls.Add(this.Accesoriu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Accesorii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Accesorii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateAccesorii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazine_muzicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accesoriiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DeleteAccesoriu;
        private System.Windows.Forms.Button InsertAccesoriu;
        private System.Windows.Forms.Button UpdateAccesoriu;
        private System.Windows.Forms.TextBox Obiect_compatibil;
        private System.Windows.Forms.TextBox Cautare_accesorii;
        private System.Windows.Forms.Label SearchAccesoriu;
        private System.Windows.Forms.TextBox Nume_accesoriu;
        private System.Windows.Forms.Label TipInstrument;
        private System.Windows.Forms.Label ObiectCompatibil;
        private System.Windows.Forms.Label NumeAccesoriu;
        private System.Windows.Forms.Label Accesoriu;
        private System.Windows.Forms.ComboBox Tip_instrument;
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.DataGridView DateAccesorii;
        private System.Windows.Forms.Label IDAccesoriu;
        private System.Windows.Forms.TextBox ID_accesoriu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Sortare_coloana;
        private System.Windows.Forms.ComboBox Tip_sortare;
        private Magazine_muzicaDataSet magazine_muzicaDataSet;
        private System.Windows.Forms.BindingSource accesoriiBindingSource;
        private Magazine_muzicaDataSetTableAdapters.accesoriiTableAdapter accesoriiTableAdapter;
    }
}