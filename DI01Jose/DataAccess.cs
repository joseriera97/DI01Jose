using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI01Jose
{
    public class DataAccess
    {
        //Obtener todos los productos de una categoria especifica.
        public List<Product> GetProducts(string category)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWork")))
                {
                    //var output = connection.Query<Product>($"select * from Production.Product").ToList();
                    var output = connection.Query<Product>("Products_GetByCategory @Category", new { Category = category }).ToList();
                    //Al estar en using se cierra la llamada a la BBDD al finalizar.
                    return output;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas con la Obtención de Productos");
                throw;
            }

        }
        public List<Product> GetProductForName(string nombre)
        {
            nombre = "%"+nombre+"%";

            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWork")))
                {
                    var output = connection.Query<Product>("dbo.Products_GetByName @Nombre", new { Nombre = nombre }).ToList();

                    return output;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas con la Obtención de Producto por Nombre de Producto");

                throw;
            }

        }
        //Obtener la información de un Producto en especifico por 
        //ProductID
        public Product GetProductForProductID(int producto)
        {

            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWork")))
                {                                                                                              //De esta forma obtenemos el primer valor
                    Product output = connection.Query<Product>("dbo.Products_GetByIdProduct @Producto", new { Producto = producto }).FirstOrDefault();

                    return output;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No se ha podido obtener los datos del Producto por ProductID");

                throw;
            }

        }
        //Intento de Actualizar la información de un Producto con el 
        //ProductID
        public void UpdateProductForProductID(int productoID, string Description, decimal ListPrice)
        {

            try
            {
                string commandText = "UPDATE Production.Product" +
                                        "SET Production.Product.ProductLine = @Precio"+
                                        "WHERE Production.Product.ProductID = @ProductoID;";
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWork")))
                {
                    //Product output = connection.Query<Product>("dbo.Products_UpdateProductByID @ProductoID", new { ProductoID = productoID }).FirstOrDefault();

                    SqlCommand command = new SqlCommand(commandText, (SqlConnection)connection);
                    command.Parameters.Add("@Precio", SqlDbType.Decimal);
                    command.Parameters["@Precio"].Value = ListPrice;

                    command.Parameters.Add("@ProductoID", SqlDbType.Int);
                    command.Parameters["@ProductoID"].Value = productoID;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    //connection.Parameters.Add("@ProductoID", ProductoID);
                    //connection.Query<Product>("dbo.Products_UpdateProductByID @ProductoID", new { ProductoID = productoID , })
                    // connection.Execute("dbo.Products_UpdateProductByID , @Description, @ListPrice");
                    // connection.Execute("dbo.Products_UpdateProductByID @ProductoID, @Description, @ListPrice");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No se ha podido actualizar la informacion del Producto.");

                throw;
            }

        }


    }
}
