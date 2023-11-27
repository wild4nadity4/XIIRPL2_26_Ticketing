namespace XIIRPL2_26_Ticketing.MasterForm
{
    partial class FrmMasterJadwalPenerbangan
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
            btnSimpan = new Button();
            button1 = new Button();
            txtHargaperTiket = new NumericUpDown();
            label7 = new Label();
            txtDari = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtKodePenerbangan = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            txtKe = new ComboBox();
            txtMaskapai = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            txtTanggal = new DateTimePicker();
            txtDurasiPenerbangan = new TextBox();
            txtWaktuKeberangkatan = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)txtHargaperTiket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(649, 415);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(61, 23);
            btnSimpan.TabIndex = 33;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // button1
            // 
            button1.Location = new Point(571, 415);
            button1.Name = "button1";
            button1.Size = new Size(63, 23);
            button1.TabIndex = 32;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtHargaperTiket
            // 
            txtHargaperTiket.Location = new Point(551, 372);
            txtHargaperTiket.Name = "txtHargaperTiket";
            txtHargaperTiket.Size = new Size(200, 23);
            txtHargaperTiket.TabIndex = 29;
            txtHargaperTiket.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(412, 267);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 28;
            label7.Text = "Tanggal";
            // 
            // txtDari
            // 
            txtDari.FormattingEnabled = true;
            txtDari.Location = new Point(135, 301);
            txtDari.Name = "txtDari";
            txtDari.Size = new Size(220, 23);
            txtDari.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 380);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 24;
            label6.Text = "Maskapai";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 341);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 23;
            label5.Text = "Ke";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 304);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 22;
            label4.Text = "Dari";
            // 
            // txtKodePenerbangan
            // 
            txtKodePenerbangan.Location = new Point(135, 262);
            txtKodePenerbangan.Name = "txtKodePenerbangan";
            txtKodePenerbangan.Size = new Size(220, 23);
            txtKodePenerbangan.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 265);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 20;
            label3.Text = "Kode Penerbangan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 56);
            label2.Name = "label2";
            label2.Size = new Size(259, 15);
            label2.TabIndex = 19;
            label2.Text = "Semua jadwal penerbangan akan muncul di sini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(48, 14);
            label1.Name = "label1";
            label1.Size = new Size(336, 32);
            label1.TabIndex = 18;
            label1.Text = "Master Jadwal Penerbangan";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(22, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(757, 150);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellClick;
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
            // txtKe
            // 
            txtKe.FormattingEnabled = true;
            txtKe.Location = new Point(135, 341);
            txtKe.Name = "txtKe";
            txtKe.Size = new Size(220, 23);
            txtKe.TabIndex = 34;
            // 
            // txtMaskapai
            // 
            txtMaskapai.FormattingEnabled = true;
            txtMaskapai.Location = new Point(135, 382);
            txtMaskapai.Name = "txtMaskapai";
            txtMaskapai.Size = new Size(220, 23);
            txtMaskapai.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(412, 338);
            label9.Name = "label9";
            label9.Size = new Size(113, 15);
            label9.TabIndex = 36;
            label9.Text = "Durasi Penerbangan";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(412, 380);
            label10.Name = "label10";
            label10.Size = new Size(87, 15);
            label10.TabIndex = 37;
            label10.Text = "Harga per Tiket";
            // 
            // txtTanggal
            // 
            txtTanggal.Location = new Point(551, 262);
            txtTanggal.Name = "txtTanggal";
            txtTanggal.Size = new Size(200, 23);
            txtTanggal.TabIndex = 38;
            // 
            // txtDurasiPenerbangan
            // 
            txtDurasiPenerbangan.Location = new Point(551, 334);
            txtDurasiPenerbangan.Name = "txtDurasiPenerbangan";
            txtDurasiPenerbangan.Size = new Size(200, 23);
            txtDurasiPenerbangan.TabIndex = 40;
            // 
            // txtWaktuKeberangkatan
            // 
            txtWaktuKeberangkatan.Location = new Point(551, 301);
            txtWaktuKeberangkatan.Name = "txtWaktuKeberangkatan";
            txtWaktuKeberangkatan.Size = new Size(200, 23);
            txtWaktuKeberangkatan.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(412, 301);
            label8.Name = "label8";
            label8.Size = new Size(123, 15);
            label8.TabIndex = 42;
            label8.Text = "Waktu Keberangkatan";
            // 
            // FrmMasterJadwalPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(txtWaktuKeberangkatan);
            Controls.Add(txtDurasiPenerbangan);
            Controls.Add(txtTanggal);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtMaskapai);
            Controls.Add(txtKe);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(txtHargaperTiket);
            Controls.Add(label7);
            Controls.Add(txtDari);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtKodePenerbangan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FrmMasterJadwalPenerbangan";
            Text = "FrmMasterJadwalPenerbangan";
            Load += FrmMasterJadwalPenerbangan_Load;
            ((System.ComponentModel.ISupportInitialize)txtHargaperTiket).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Button button1;
        private NumericUpDown txtHargaperTiket;
        private Label label7;
        private ComboBox txtDari;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtKodePenerbangan;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private ComboBox txtKe;
        private ComboBox txtMaskapai;
        private Label label9;
        private Label label10;
        private DateTimePicker txtTanggal;
        private TextBox txtDurasiPenerbangan;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
        private TextBox txtWaktuKeberangkatan;
        private Label label8;
    }
}