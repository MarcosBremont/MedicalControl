using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data; 

namespace MedicalControl
{
    public class Conexioncs
    {
        public MySqlConnection con = new MySqlConnection("Server=localhost; database=medicalcontrol; user=root; password=MarcosBremont");

        public void Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
    
        }

        public void Desconectar ()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }

    }

}
