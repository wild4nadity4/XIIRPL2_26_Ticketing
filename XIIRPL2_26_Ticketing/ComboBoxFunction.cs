using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace XIIRPL2_26_Ticketing
{
    class ComboBoxFunction
    {
        static NpgsqlConnection conn;
        static NpgsqlDataReader reader;

        public static void Set_ComboBox(string Query, string row, ComboBox box)
        {
            try
            {
                conn = koneksi.conn;
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand(Query, conn);
                reader = command.ExecuteReader();
                box.Items.Clear();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        box.Items.Add(reader[row]);
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(reader != null)
                    reader.Close();
                conn.Close();
            }
            
        }
    }
}
