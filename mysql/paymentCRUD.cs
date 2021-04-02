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
            string constring = "datasource =" + host + "; database =" + db + "; port =" + port + "; username=" + user + "; password=" + pass;
            con = new MySqlConnection(constring);
        }

    }

    class accountCRUD : mysql
    {
        // FOR ID
        public string or_no { set; get; }

        //GET SET FOR CREATING PAYMENT
        public string account_id { set; get; }
        public string date_of_payment { set; get; }
        public string amount { set; get; }
        public string mode_of_payment { set; get; }
        public string payment_for { set; get; }


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
                
            }

        }

        public void Update_payment()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                
            }
        }

        public void Delete_payment()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                
            }
        }

        public void Read_payment()
        {



        }

        
    }
}
