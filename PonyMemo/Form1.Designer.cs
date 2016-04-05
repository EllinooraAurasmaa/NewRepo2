namespace PonyMemo
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelaa = new System.Windows.Forms.Button();
            this.textNimi = new System.Windows.Forms.TextBox();
            this.ponitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new PonyMemo.DatabaseDataSet();
            this.textRekNro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ponitTableAdapter = new PonyMemo.DatabaseDataSetTableAdapters.PonitTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmä = new System.Windows.Forms.TextBox();
            this.txtIsä = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.paneeli = new System.Windows.Forms.TextBox();
            this.Etsi = new System.Windows.Forms.Label();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.btnPeruuta = new System.Windows.Forms.Button();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnUusi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ponitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIsä);
            this.groupBox1.Controls.Add(this.txtEmä);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnSelaa);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textNimi);
            this.groupBox1.Controls.Add(this.textRekNro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lisää";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSelaa
            // 
            this.btnSelaa.Location = new System.Drawing.Point(471, 182);
            this.btnSelaa.Name = "btnSelaa";
            this.btnSelaa.Size = new System.Drawing.Size(73, 23);
            this.btnSelaa.TabIndex = 4;
            this.btnSelaa.Text = "Selaa";
            this.btnSelaa.UseVisualStyleBackColor = true;
            // 
            // textNimi
            // 
            this.textNimi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ponitBindingSource, "Nimi", true));
            this.textNimi.Location = new System.Drawing.Point(123, 38);
            this.textNimi.Name = "textNimi";
            this.textNimi.Size = new System.Drawing.Size(100, 20);
            this.textNimi.TabIndex = 3;
            // 
            // ponitBindingSource
            // 
            this.ponitBindingSource.DataMember = "Ponit";
            this.ponitBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textRekNro
            // 
            this.textRekNro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ponitBindingSource, "RekNro", true));
            this.textRekNro.Location = new System.Drawing.Point(123, 66);
            this.textRekNro.Name = "textRekNro";
            this.textRekNro.Size = new System.Drawing.Size(100, 20);
            this.textRekNro.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rekisterinumero:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nimi:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ponitTableAdapter
            // 
            this.ponitTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Emä:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Isä";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtEmä
            // 
            this.txtEmä.Location = new System.Drawing.Point(123, 100);
            this.txtEmä.Name = "txtEmä";
            this.txtEmä.Size = new System.Drawing.Size(100, 20);
            this.txtEmä.TabIndex = 7;
            this.txtEmä.TextChanged += new System.EventHandler(this.txtEmä_TextChanged);
            // 
            // txtIsä
            // 
            this.txtIsä.Location = new System.Drawing.Point(123, 135);
            this.txtIsä.Name = "txtIsä";
            this.txtIsä.Size = new System.Drawing.Size(100, 20);
            this.txtIsä.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(421, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(13, 277);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(597, 257);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // paneeli
            // 
            this.paneeli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ponitBindingSource, "Nimi", true));
            this.paneeli.Location = new System.Drawing.Point(51, 251);
            this.paneeli.Name = "paneeli";
            this.paneeli.Size = new System.Drawing.Size(562, 20);
            this.paneeli.TabIndex = 5;
            this.paneeli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // Etsi
            // 
            this.Etsi.AutoSize = true;
            this.Etsi.Location = new System.Drawing.Point(17, 254);
            this.Etsi.Name = "Etsi";
            this.Etsi.Size = new System.Drawing.Size(24, 13);
            this.Etsi.TabIndex = 4;
            this.Etsi.Text = "Etsi";
            // 
            // btnTallenna
            // 
            this.btnTallenna.Location = new System.Drawing.Point(534, 541);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(75, 23);
            this.btnTallenna.TabIndex = 6;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = true;
            // 
            // btnPeruuta
            // 
            this.btnPeruuta.Location = new System.Drawing.Point(434, 541);
            this.btnPeruuta.Name = "btnPeruuta";
            this.btnPeruuta.Size = new System.Drawing.Size(75, 23);
            this.btnPeruuta.TabIndex = 7;
            this.btnPeruuta.Text = "Peruuta";
            this.btnPeruuta.UseVisualStyleBackColor = true;
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(342, 541);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(75, 23);
            this.btnMuokkaa.TabIndex = 8;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            // 
            // btnUusi
            // 
            this.btnUusi.Location = new System.Drawing.Point(250, 541);
            this.btnUusi.Name = "btnUusi";
            this.btnUusi.Size = new System.Drawing.Size(75, 23);
            this.btnUusi.TabIndex = 9;
            this.btnUusi.Text = "Uusi";
            this.btnUusi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 608);
            this.Controls.Add(this.btnUusi);
            this.Controls.Add(this.btnMuokkaa);
            this.Controls.Add(this.btnPeruuta);
            this.Controls.Add(this.btnTallenna);
            this.Controls.Add(this.paneeli);
            this.Controls.Add(this.Etsi);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PonyMemo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ponitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelaa;
        private System.Windows.Forms.TextBox textNimi;
        private System.Windows.Forms.TextBox textRekNro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource ponitBindingSource;
        private DatabaseDataSetTableAdapters.PonitTableAdapter ponitTableAdapter;
        private System.Windows.Forms.TextBox txtIsä;
        private System.Windows.Forms.TextBox txtEmä;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox paneeli;
        private System.Windows.Forms.Label Etsi;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.Button btnPeruuta;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnUusi;

    }
}

