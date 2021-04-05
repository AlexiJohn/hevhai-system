using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace hevhai_system.account
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
            string constring = "datasource =" + host + "; database =" + db + "; port =" + port + "; username=" + user + "; password=" + pass + ";  AllowLoadLocalInfile=true";
            con = new MySqlConnection(constring);
        }
        
    }

    class accountCRUD : mysql
    {
        //GET SET FOR CREATING ACCOUNT
        public string last_name { set; get; }
        public string spouse_fname_1 { set; get; }
        public string spouse_fname_2 { set; get; }
        public string address { set; get; }
        public string  fb_account { set; get; }
        public string email { set; get; }
        public string contact { set; get; }
        public string moved_in_date { set; get; }

        // FOR ID
        public string account_id { set; get; }

        // READ PROPERTIES
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        // FOR MOVING FILES SECURELY (MYSQL REQUIRED)
        public string secure_priv = "C:/Users/user/Documents/iscs30.50/hevhai-system/files/";

        //SET INTANCE

        public void Create_account()
        {
            
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO account_t(last_name, spouse_fname_1, spouse_fname_2, address, fb_account, email, contact, moved_in_date) VALUES (@last_name, @spouse_fname_1, @spouse_fname_2, @address, @fb_account, @email, @contact, @moved_in_date)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = last_name;
                cmd.Parameters.Add("@spouse_fname_1", MySqlDbType.VarChar).Value = spouse_fname_1;
                cmd.Parameters.Add("@spouse_fname_2", MySqlDbType.VarChar).Value = spouse_fname_2;
                cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
                cmd.Parameters.Add("@fb_account", MySqlDbType.VarChar).Value = fb_account;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@contact", MySqlDbType.VarChar).Value = contact;
                cmd.Parameters.Add("@moved_in_date", MySqlDbType.VarChar).Value = moved_in_date;

                cmd.ExecuteNonQuery();
                con.Close();
            }

        }

        public void Update_account()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE account_t SET last_name=@last_name, spouse_fname_1=@spouse_fname_1, spouse_fname_2=@spouse_fname_2, address=@address, fb_account=@fb_account, email=@email, contact=@contact, moved_in_date=@moved_in_date WHERE account_id=@account_id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = last_name;
                cmd.Parameters.Add("@spouse_fname_1", MySqlDbType.VarChar).Value = spouse_fname_1;
                cmd.Parameters.Add("@spouse_fname_2", MySqlDbType.VarChar).Value = spouse_fname_2;
                cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
                cmd.Parameters.Add("@fb_account", MySqlDbType.VarChar).Value = fb_account;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@contact", MySqlDbType.VarChar).Value = contact;
                cmd.Parameters.Add("@moved_in_date", MySqlDbType.VarChar).Value = moved_in_date;

                cmd.Parameters.Add("@account_id", MySqlDbType.Int64).Value = account_id;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void Delete_account()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "DELETE FROM account_t WHERE account_id=@account_id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@account_id", MySqlDbType.Int64).Value = account_id;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void Read_account()
        {
            
            dt.Clear();
            string query = "SELECT * FROM account_t";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];

        }

        public void Read_account_name()
        {
            dt.Clear();
            string query = "SELECT CONCAT(last_name, ', ', spouse_fname_1, '/', spouse_fname_2) AS name, account_id FROM account_t";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];
        }

        public void Import_account()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                string filePath = hevhai_system.accountsView.getForm.txtfilepath.Replace(@"\","/");
                cmd.CommandText = $"LOAD DATA LOCAL INFILE '{filePath}' INTO TABLE account_t FIELDS TERMINATED BY ',' LINES TERMINATED BY '\n' IGNORE 1 LINES";
                cmd.CommandTimeout = 86400;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        
    }
}
