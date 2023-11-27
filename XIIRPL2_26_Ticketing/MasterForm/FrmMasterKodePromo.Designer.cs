namespace XIIRPL2_26_Ticketing.MasterForm
{
    partial class FrmMasterKodePromo
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
            txtPersentaseDiskon = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            txtKodePromo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            txtBerlakuSampai = new DateTimePicker();
            txtMaksimumDiskon = new NumericUpDown();
            label6 = new Label();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)txtPersentaseDiskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaksimumDiskon).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(580, 372);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(61, 23);
            btnSimpan.TabIndex = 46;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(493, 372);
            button1.Name = "button1";
            button1.Size = new Size(63, 23);
            button1.TabIndex = 45;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(458, 272);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(253, 82);
            txtDeskripsi.TabIndex = 44;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(398, 283);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 43;
            label8.Text = "Deskripsi";
            // 
            // txtPersentaseDiskon
            // 
            txtPersentaseDiskon.Location = new Point(130, 345);
            txtPersentaseDiskon.Name = "txtPersentaseDiskon";
            txtPersentaseDiskon.Size = new Size(222, 23);
            txtPersentaseDiskon.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 347);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 40;
            label5.Text = "Persentase Diskon";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 317);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 39;
            label4.Text = "Berlaku Sampai";
            // 
            // txtKodePromo
            // 
            txtKodePromo.Location = new Point(130, 280);
            txtKodePromo.Name = "txtKodePromo";
            txtKodePromo.Size = new Size(222, 23);
            txtKodePromo.TabIndex = 38;
            txtKodePromo.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 283);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 37;
            label3.Text = "Kode Promo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 73);
            label2.Name = "label2";
            label2.Size = new Size(297, 15);
            label2.TabIndex = 36;
            label2.Text = "Semua kode promo yang terdaftar akan muncul di sini ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(48, 32);
            label1.Name = "label1";
            label1.Size = new Size(243, 32);
            label1.TabIndex = 35;
            label1.Text = "Master Kode Promo";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(22, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(757, 150);
            dataGridView1.TabIndex = 34;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtBerlakuSampai
            // 
            txtBerlakuSampai.Location = new Point(130, 313);
            txtBerlakuSampai.Name = "txtBerlakuSampai";
            txtBerlakuSampai.Size = new Size(222, 23);
            txtBerlakuSampai.TabIndex = 47;
            // 
            // txtMaksimumDiskon
            // 
            txtMaksimumDiskon.Location = new Point(130, 383);
            txtMaksimumDiskon.Name = "txtMaksimumDiskon";
            txtMaksimumDiskon.Size = new Size(222, 23);
            txtMaksimumDiskon.TabIndex = 48;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 385);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 49;
            label6.Text = "Maksimum Diskon";
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
            // FrmMasterKodePromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(txtMaksimumDiskon);
            Controls.Add(txtBerlakuSampai);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(txtDeskripsi);
            Controls.Add(label8);
            Controls.Add(txtPersentaseDiskon);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtKodePromo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FrmMasterKodePromo";
            Text = "FrmMasterKodePromo";
            Load += FrmMasterKodePromo_Load;
            ((System.ComponentModel.ISupportInitialize)txtPersentaseDiskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMaksimumDiskon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox4;
        private Label label8;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown2;
        private Label label6;
        private Button btnSimpan;
        private TextBox txtDeskripsi;
        private NumericUpDown txtPersentaseDiskon;
        private TextBox txtKodePromo;
        private DateTimePicker txtBerlakuSampai;
        private NumericUpDown txtMaksimumDiskon;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}