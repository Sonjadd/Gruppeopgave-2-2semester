using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;


namespace Data
{

    class Data
    {
        private SqlConnection conn;
        private SqlDataReader rdr;
        private SqlCommand cmd;
        private const string db = "F17ST2ITS220160";
        public Data()
        {
            conn = new SqlConnection("Data Source =i4dab.ase.au.dk; Initial Catalog = " + db + "; Persist Security Info = True; User ID =" + db + "; Password = " + db + "");
        }

        public List<BS_DTO> getBS(string cpr)
        {
            List<BS_DTO> bsList = new List<BS_DTO>();
            // Oprette SQL kommando
            cmd = new SqlCommand("select * from Blodsukker where cpr ='" + cpr + "'", conn);

            // Åbne DB-forbindelsen
            conn.Open();

            // Udføre det ønskede SQL statement på DB
            rdr = cmd.ExecuteReader(); // nu indeholder rdr-objektet resultatet af forespørgslen

            while (rdr.Read())
            {
                bsList.Add(new BS_DTO(rdr.GetDouble(0), rdr.GetDateTime(1)));

            }
            conn.Close();
            return bsList;
        }
        public List<BT_DTO> getBT(string cpr)
        {
            List<BT_DTO> btList = new List<BT_DTO>();
            // Oprette SQL kommando
            cmd = new SqlCommand("select * from Blodtryk where cpr ='" + cpr + "'", conn);

            // Åbne DB-forbindelsen
            conn.Open();

            // Udføre det ønskede SQL statement på DB
            rdr = cmd.ExecuteReader(); // nu indeholder rdr-objektet resultatet af forespørgslen

            while (rdr.Read())
            {
                btList.Add(new BT_DTO(rdr.GetInt32(0), rdr.GetInt32(1), rdr.GetDateTime(2)));

            }
            conn.Close();
            return btList;

        }
        public List<Vægt_DTO> getVægt(string cpr)
        {
            List<Vægt_DTO> vægtList = new List<Vægt_DTO>();
            // Oprette SQL kommando
            cmd = new SqlCommand("select * from Vægt where cpr ='" + cpr + "'", conn);

            // Åbne DB-forbindelsen
            conn.Open();

            // Udføre det ønskede SQL statement på DB
            rdr = cmd.ExecuteReader(); // nu indeholder rdr-objektet resultatet af forespørgslen

            while (rdr.Read())
            {
                vægtList.Add(new Vægt_DTO(rdr.GetDouble(0), rdr.GetDateTime(1), rdr.GetInt32(3)));
            }
            conn.Close();

            return vægtList;
        }
     
    }
}
