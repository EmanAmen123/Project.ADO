using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace dataaccess_layer
{
    public class DBContext
    {
        SqlConnection con;
        public DBContext()
        {
            con = new SqlConnection("server=DESKTOP-AFGBK7M\\SQLEXPRESS01;database=adoDatabase;trusted_connection=True;Trust Server Certificate=True");
        }
        //sellect command 
        public DataTable select(string commandText)   // or executequery
        {
            //disconnected mode
            SqlDataAdapter adapter = new();
            DataTable dt = new();

            //define command
            SqlCommand command = new(commandText, con);
            //attach
            adapter.SelectCommand = command;

            //get data
            adapter.Fill(dt);

            return dt;
        }

        //insert , update , delete => returns int (num of rows affected)
        public int ExecuteNonQuery(string commandText)
        {
            int rowsAffected = -1;
            //connected mode 



            //define command 
            SqlCommand command = new(commandText,con);
            try
            {
                //open connection
                con.Open();
                //execute
                 rowsAffected = command.ExecuteNonQuery();
            }catch(Exception ex)
            {
                //log exeption on file 
                throw new Exception(ex.Message);
            }
            finally
            {//if there exeption or not=> colde the connection 
                //close connection
                con.Close();
            }
            

            return rowsAffected;
        }


    }
}
