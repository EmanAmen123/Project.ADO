using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dataaccess_layer;

namespace bussnise_layer
{
    public class FavuratesServices
    {
        DBContext dBContext;
        public FavuratesServices()
        {
            dBContext = new DBContext();
        }
        //select 
        public DataTable GetFavurates()
        {
            string command = "select ProductId from Favorites";
            //this function cant execute command by itself => data access layer
            DataTable dt = dBContext.select(command);
            return dt;
        }

        //insert
        public int AddToFavurite(int UserId, int ProductId)
        {
            string command = $"insert into Favorites(UserId,ProductId) values({UserId},{ProductId})";
            int rowsAffected = dBContext.ExecuteNonQuery(command);
            return rowsAffected;
        }


        //delete

        public int Delete(int id)
        {
            string command = $"delete from Favorites where ProductId={id}";
            int rowsAffected = dBContext.ExecuteNonQuery(command);
            return rowsAffected;
        }
    }
}
