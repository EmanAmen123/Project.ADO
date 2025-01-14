using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using dataaccess_layer;

namespace bussnise_layer
{
    public class UsersServices
    {
        DBContext dBContext;
        public UsersServices()
        {
            dBContext = new DBContext();
        }
        //select 
        public DataTable GetUsers()
        {
           

            string command = "select UserId,name,email,password,age,address,role from Users ";
            //this function cant execute command by itself => data access layer
            DataTable dt= dBContext.select(command);
            return dt;
        }

        //insert
        public int AddUser(string name , string email ,string pass ,int age , string address, string role)
        {
            string command = $"insert into Users(name,email,password,age,address,role) values('{name}','{email}','{pass}',{age},'{address}','{role}')";
            int rowsAffected = dBContext.ExecuteNonQuery(command);
            return rowsAffected;
        }

        //update

        public int updateUser(int id ,string name, string email, string pass, int age, string address, string role)
        {
            string command = $"update Users set name='{name}',email='{email}',password='{pass}',age={age},address='{address}',role='{role}' where userid={id}";
            int rowsAffected = dBContext.ExecuteNonQuery(command);
            return rowsAffected;
        }

        //delete

        public int Delete(int id)
        {
            string deleteFavCommand = $"delete from Favorites where UserId={id}";
            dBContext.ExecuteNonQuery(deleteFavCommand);
            string command = $"delete from Users where UserId={id}";
            int rowsAffected = dBContext.ExecuteNonQuery(command);
            return rowsAffected;
        }
    }
}
