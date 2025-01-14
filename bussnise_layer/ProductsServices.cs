using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dataaccess_layer;

namespace bussnise_layer
{
    public class ProductsServices
    {
        DBContext dBContext;
        public ProductsServices()
        {
            dBContext = new DBContext();
        }
        //select 
        public DataTable GetProducts()
        {
            string command = "select productid,ProductName,price,CategoryId from products";
            //this function cant execute command by itself => data access layer
            DataTable dt = dBContext.select(command);
            return dt;
        }

        //insert
        public int AddProduct(string ProductName,int price,int CategoryId)
        {
            string command = $"insert into products(ProductName,price,CategoryId) values('{ProductName}',{price},{CategoryId})";
            int rowsAffected = dBContext.ExecuteNonQuery(command);
            return rowsAffected;
        }

        //update

        public int updateProducts(int id, string ProductName, int price, int CategoryId)
        {
            string command = $"update products set ProductName='{ProductName}',price={price},CategoryId={CategoryId} where productid={id}";
            int rowsAffected = dBContext.ExecuteNonQuery(command);
            return rowsAffected;
        }

        //delete

        public int Delete(int id)
        {
            string deleteFav = $"delete from Favorites where ProductId={id}";
            dBContext.ExecuteNonQuery(deleteFav);
            string command = $"delete from products where ProductId={id}";
            int rowsAffected = dBContext.ExecuteNonQuery(command);
            return rowsAffected;
        }
    }
}
