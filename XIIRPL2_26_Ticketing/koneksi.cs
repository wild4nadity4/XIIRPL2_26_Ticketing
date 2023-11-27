using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace XIIRPL2_26_Ticketing
{
     class koneksi
    {
        public static NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=db_ticket_xii_rpl_2_26;" + "User Id=postgres;Password=admin;");
          
    }
}
