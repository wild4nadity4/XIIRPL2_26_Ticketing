﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XIIRPL2_26_Ticketing.MasterForm
{
    public partial class FrmMasterJadwalPenerbangan : Form
    {
        public NpgsqlCommand cmd;
        public FrmMasterJadwalPenerbangan()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM tbl_jadwalpenerbangan", koneksi.conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String sql = "INSERT INTO tbl_jadwalpenerbangan" + "(kode_penerbangan,bandara_keberangkatan_id,bandara_tujuan_id,maskapai_id,tanggal_waktu_keberangkatan,durasi_penerbangan,harga_pertiket)" + "VALUES" + "('" + txtKodePenerbangan.Text + "','" + txtDari.Text + "','" + txtKe.Text + "','" + txtMaskapai.Text + "','" + txtTanggal.Text + "','" + txtDurasiPenerbangan.Text + "','" + txtHargaperTiket.Text + "')";
                cmd = new NpgsqlCommand(sql, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data JadwalPenerbangan");
                koneksi.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int id;
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    koneksi.conn.Open();
                    String sql = "DELETE FROM tbl_jadwalpenerbangan WHERE id=@id";
                    cmd = new NpgsqlCommand(sql, koneksi.conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data Berhasil Dihapus");
                        view_data();
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Berhasil Dihapus");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    koneksi.conn.Close();
                }
            }
        }

        private void FrmMasterJadwalPenerbangan_Load(object sender, EventArgs e)
        {
            view_data();
        }
    }
}
