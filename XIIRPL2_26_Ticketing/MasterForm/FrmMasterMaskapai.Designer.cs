namespace XIIRPL2_26_Ticketing.MasterForm
{
    partial class FrmMasterMaskapai
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
            txtDeskripsi = new TextBox();
            label8 = new Label();
            txtJumlahKru = new NumericUpDown();
            txtPerusahaan = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtNama = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)txtJumlahKru).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(573, 377);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(61, 23);
            btnSimpan.TabIndex = 33;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(493, 377);
            button1.Name = "button1";
            button1.Size = new Size(63, 23);
            button1.TabIndex = 32;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(461, 262);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(197, 96);
            txtDeskripsi.TabIndex = 31;
            txtDeskripsi.TextChanged += textBox4_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(398, 265);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 30;
            label8.Text = "Deskripsi";
            label8.Click += label8_Click;
            // 
            // txtJumlahKru
            // 
            txtJumlahKru.Location = new Point(100, 335);
            txtJumlahKru.Name = "txtJumlahKru";
            txtJumlahKru.Size = new Size(220, 23);
            txtJumlahKru.TabIndex = 29;
            txtJumlahKru.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // txtPerusahaan
            // 
            txtPerusahaan.Location = new Point(100, 294);
            txtPerusahaan.Name = "txtPerusahaan";
            txtPerusahaan.Size = new Size(220, 23);
            txtPerusahaan.TabIndex = 25;
            txtPerusahaan.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 335);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 23;
            label5.Text = "Jumlah Kru";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 304);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 22;
            label4.Text = "Perusahaan";
            label4.Click += label4_Click;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(100, 262);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(220, 23);
            txtNama.TabIndex = 21;
            txtNama.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 265);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 20;
            label3.Text = "Nama";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 56);
            label2.Name = "label2";
            label2.Size = new Size(282, 15);
            label2.TabIndex = 19;
            label2.Text = "Semua maskapai yang terdaftar akan muncul di sini ";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(48, 14);
            label1.Name = "label1";
            label1.Size = new Size(208, 32);
            label1.TabIndex = 18;
            label1.Text = "Master Maskapai";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(22, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(757, 150);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // FrmMasterMaskapai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(txtDeskripsi);
            Controls.Add(label8);
            Controls.Add(txtJumlahKru);
            Controls.Add(txtPerusahaan);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtNama);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FrmMasterMaskapai";
            Text = "FrmMasterMaskapai";
            Load += FrmMasterMaskapai_Load;
            ((System.ComponentModel.ISupportInitialize)txtJumlahKru).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Button button1;
        private TextBox txtDeskripsi;
        private Label label8;
        private NumericUpDown txtJumlahKru;
        private TextBox txtPerusahaan;
        private Label label5;
        private Label label4;
        private TextBox txtNama;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}