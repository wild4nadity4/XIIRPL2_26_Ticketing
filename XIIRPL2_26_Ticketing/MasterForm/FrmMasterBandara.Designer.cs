namespace XIIRPL2_26_Ticketing.MasterForm
{
    partial class FrmMasterBandara
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNama = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtKodeIATA = new TextBox();
            txtKota = new TextBox();
            txtNegara = new ComboBox();
            label7 = new Label();
            txtJumlahTerminal = new NumericUpDown();
            label8 = new Label();
            txtAlamat = new TextBox();
            button1 = new Button();
            button2 = new Button();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlahTerminal).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(12, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(757, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 25);
            label1.Name = "label1";
            label1.Size = new Size(194, 32);
            label1.TabIndex = 1;
            label1.Text = "Master Bandara";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 67);
            label2.Name = "label2";
            label2.Size = new Size(272, 15);
            label2.TabIndex = 2;
            label2.Text = "Semua bandara yang terdaftar akan muncul di sini";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 276);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Nama";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(90, 273);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(220, 23);
            txtNama.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 315);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 5;
            label4.Text = "Kode !ATA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 346);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 6;
            label5.Text = "Kota";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 384);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 7;
            label6.Text = "Negara";
            // 
            // txtKodeIATA
            // 
            txtKodeIATA.Location = new Point(90, 305);
            txtKodeIATA.Name = "txtKodeIATA";
            txtKodeIATA.Size = new Size(220, 23);
            txtKodeIATA.TabIndex = 8;
            // 
            // txtKota
            // 
            txtKota.Location = new Point(90, 343);
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(220, 23);
            txtKota.TabIndex = 9;
            // 
            // txtNegara
            // 
            txtNegara.FormattingEnabled = true;
            txtNegara.Location = new Point(90, 383);
            txtNegara.Name = "txtNegara";
            txtNegara.Size = new Size(220, 23);
            txtNegara.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(412, 276);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 11;
            label7.Text = "Jumlah Terminal";
            // 
            // txtJumlahTerminal
            // 
            txtJumlahTerminal.Location = new Point(511, 276);
            txtJumlahTerminal.Name = "txtJumlahTerminal";
            txtJumlahTerminal.Size = new Size(174, 23);
            txtJumlahTerminal.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(412, 315);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 13;
            label8.Text = "Alamat";
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(511, 315);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(174, 91);
            txtAlamat.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(525, 425);
            button1.Name = "button1";
            button1.Size = new Size(63, 23);
            button1.TabIndex = 15;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(608, 425);
            button2.Name = "button2";
            button2.Size = new Size(61, 23);
            button2.TabIndex = 16;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.HeaderText = "Edit";
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Text = "Edit";
            BtnEdit.UseColumnTextForButtonValue = true;
            // 
            // BtnDelete
            // 
            BtnDelete.HeaderText = "Delete";
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Text = "Delete";
            BtnDelete.UseColumnTextForButtonValue = true;
            // 
            // FrmMasterBandara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 494);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtAlamat);
            Controls.Add(label8);
            Controls.Add(txtJumlahTerminal);
            Controls.Add(label7);
            Controls.Add(txtNegara);
            Controls.Add(txtKota);
            Controls.Add(txtKodeIATA);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtNama);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FrmMasterBandara";
            Text = "FrmMasterBandara";
            Load += FrmMasterBandara_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlahTerminal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNama;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtKodeIATA;
        private TextBox txtKota;
        private ComboBox txtNegara;
        private Label label7;
        private NumericUpDown txtJumlahTerminal;
        private Label label8;
        private TextBox txtAlamat;
        private Button button1;
        private Button button2;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}