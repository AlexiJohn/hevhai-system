using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace hevhai_system.payment
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
            string constring = "datasource =" + host + "; database =" + db + "; port =" + port + "; username=" + user + "; password=" + pass+";  AllowLoadLocalInfile=true";
            con = new MySqlConnection(constring);
        }

    }

    class paymentCRUD : mysql
    {
        // FOR ID
        public string or_no { set; get; }

        //GET SET FOR CREATING PAYMENT
        public string account_id { set; get; }
        public string date_of_payment { set; get; }
        public string amount { set; get; }
        public string mode_of_payment { set; get; }
        public string payment_for { set; get; }
        public string description { set; get; }


        // READ PROPERTIES
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        // FOR MOVING FILES SECURELY (MYSQL REQUIRED)
        public string secure_priv = "C:/Users/user/Documents/iscs30.50/hevhai-system/files/bulkcopy.csv";

        //SET INTANCE

        public void Create_payment()
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO payment_t(or_no, account_id, date_of_payment, amount, mode_of_payment, payment_for, description) VALUES (@or_no, @account_id, @date_of_payment, @amount, @mode_of_payment, @payment_for, @description)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@or_no", MySqlDbType.Int32).Value = Convert.ToInt32(or_no);
                cmd.Parameters.Add("@account_id", MySqlDbType.Int32).Value = Convert.ToInt32(account_id);
                cmd.Parameters.Add("@date_of_payment", MySqlDbType.VarChar).Value = date_of_payment;
                cmd.Parameters.Add("@amount", MySqlDbType.Int32).Value = Convert.ToInt32(amount);
                cmd.Parameters.Add("@mode_of_payment", MySqlDbType.VarChar).Value = mode_of_payment;
                cmd.Parameters.Add("@payment_for", MySqlDbType.VarChar).Value = payment_for;
                cmd.Parameters.Add("@description", MySqlDbType.VarChar).Value = description;

                cmd.ExecuteNonQuery();
                con.Close();
            }

        }

        public void Update_payment()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE payment_t SET or_no=@or_no, account_id=@account_id, date_of_payment=@date_of_payment, amount=@amount, mode_of_payment=@mode_of_payment, payment_for=@payment_for, description=@description WHERE or_no=@or_no";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@or_no", MySqlDbType.Int32).Value = Convert.ToInt32(or_no);
                cmd.Parameters.Add("@account_id", MySqlDbType.Int32).Value = Convert.ToInt32(account_id);
                cmd.Parameters.Add("@date_of_payment", MySqlDbType.VarChar).Value = date_of_payment;
                cmd.Parameters.Add("@amount", MySqlDbType.Int32).Value = Convert.ToInt32(amount);
                cmd.Parameters.Add("@mode_of_payment", MySqlDbType.VarChar).Value = mode_of_payment;
                cmd.Parameters.Add("@payment_for", MySqlDbType.VarChar).Value = payment_for;
                cmd.Parameters.Add("@description", MySqlDbType.VarChar).Value = description;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void Delete_payment()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "DELETE FROM payment_t WHERE or_no=@or_no";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@or_no", MySqlDbType.Int32).Value = or_no;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void Read_payment()
        {
            
            dt.Clear();
            string query = "SELECT * FROM payment_t";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];

        }

        public void Import_payment()
        {
            global_connect();
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                string filePath = hevhai_system.paymentsView.getForm.txtfilepath;
                cmd.CommandText = $"LOAD DATA LOCAL INFILE '{filePath}' INTO TABLE payment_t FIELDS TERMINATED BY ',' LINES TERMINATED BY '\n' IGNORE 1 LINES";
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
