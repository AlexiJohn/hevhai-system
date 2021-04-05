using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace hevhai_system.summary
{
    class mysql
    {

        public MySqlConnection con;

        public void DB()
        {
            string host = "localhost";
            string db = "hevhai";
            string port = "3306";
            string user = "hevhai";
            string pass = "hevhai";
            string constring = "datasource =" + host + "; database =" + db + "; port =" + port + "; username=" + user + "; password=" + pass +"; AllowLoadLocalInfile = true";
            con = new MySqlConnection(constring);
        }

    }

    class summaryCRUD : mysql
    {
        public string outstanding_id { set; get; }
        public string account_id { set; get; }
        public string descript { set; get; }
        public string amount { set; get; }

        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public void Create_summary()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO summary_t(account_id, descript, amount) VALUES (@account_id, @descript, @amount)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@account_id", MySqlDbType.Int32).Value = Convert.ToInt32(account_id);
                cmd.Parameters.Add("@descript", MySqlDbType.VarChar).Value = descript;
                cmd.Parameters.Add("@amount", MySqlDbType.Int32).Value = Convert.ToInt32(amount);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void Update_summary()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE summary_t SET account_id=@account_id, descript=@descript, amount=@amount WHERE oustanding_id=@outstanding_id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@outstanding_id", MySqlDbType.Int32).Value = Convert.ToInt32(outstanding_id);
                cmd.Parameters.Add("@account_id", MySqlDbType.Int32).Value = Convert.ToInt32(account_id);
                cmd.Parameters.Add("@decript", MySqlDbType.VarChar).Value = descript;
                cmd.Parameters.Add("@amount", MySqlDbType.Int32).Value = Convert.ToInt32(amount);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void Delete_summary()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "DELETE FROM summary_t WHERE oustanding_id=@outstanding_id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@outstanding_id", MySqlDbType.Int32).Value = Convert.ToInt32(outstanding_id);
                
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void Read_summary()
        {

            dt.Clear();
            string query = "SELECT * FROM summary_t";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];

        }

        public void Import_summary()
        {
            global_connect();
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                string filePath = hevhai_system.summaryView.getForm.txtfilepath.Replace(@"\", "/");
                cmd.CommandText = $"LOAD DATA LOCAL INFILE '{filePath}' INTO TABLE summary_t FIELDS TERMINATED BY ',' LINES TERMINATED BY '\n' IGNORE 1 LINES";
                cmd.CommandTimeout = 86400;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void global_connect()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SET GLOBAL local_infile=1;";
                cmd.CommandTimeout = 86400;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
