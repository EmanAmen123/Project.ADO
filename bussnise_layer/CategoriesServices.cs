using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dataaccess_layer;

namespace bussnise_layer
{
    public class CategoriesServices
    {
        DBContext dBContext;
        public CategoriesServices()
        {
            dBContext = new DBContext();
        }
        //select 
        public DataTable GetCategories()
        {
            string command = "select * from Categories";
            //this function cant execute command by itself => data access layer
            DataTable dt = dBContext.select(command);
            return dt;
        }

        //insert
        public int AddCategory(string CategoryName)
        {
            string command = $"insert into Categories(CategoryName) values('{CategoryName}')";
            int rowsAffected = dBContext.ExecuteNonQuery(command);
            return rowsAffected;
        }

        //update

        public int updateCategory(int id, string CategoryName)
        {
            string command = $"update Categories set CategoryName='{CategoryName}'";
            int rowsAffected = dBContext.ExecuteNonQuery(command);
            return rowsAffected;
        }

        //delete

        public int Delete(int id)
        {
            string deleteProdCommand = $"delete from products where CategoryId={id}";
            dBContext.ExecuteNonQuery(deleteProdCommand);
            string command = $"delete from Categories where CategoryId={id}";
            int rowsAffected = dBContext.ExecuteNonQuery(command);
            return rowsAffected;
        }

    }
}
