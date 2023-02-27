using ApiDapper.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace ApiDapper.Data
{
    public class NorthwindData
    {

        public int DeleteOrderById(int orderId)
        {
            using var cnn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;Encrypt=False");

            cnn.Open();
            var tran = cnn.BeginTransaction();
            try
            {

                var sql = "DELETE FROM [Order Details] WHERE OrderID = @orderId";
                var cant = cnn.Execute(sql, new { orderId }, tran);

                sql = "DELETE FROM Orders WHERE OrderId = @orderId";
                cant += cnn.Execute(sql, new { orderId }, tran);

                tran.Commit();
                return cant;
            }
            catch
            {
                tran.Rollback();
                throw;
            }
            finally
            {
                cnn.Close();
            }
            
        }


        public List<Product> GetAllProduct()
        {
            using (var cnn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;Encrypt=False"))
            {
                cnn.Open();
                var query = "SELECT * FROM Products";
                var listProduct = cnn.Query<Product>(query).ToList();
                return listProduct;
            }
            
        }

        public Product GetProductById(int id)
        {
            using (var cnn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;Encrypt=False"))
            {
                cnn.Open();
                var query = "SELECT * FROM Products WHERE ProductId = @NuestroId";
                var product = cnn.QueryFirstOrDefault<Product>(query, new { NuestroId=id });
                return product;   
            }
        }


        public Product GetProductById(Product p)
        {
            using (var cnn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;Encrypt=False"))
            {
                cnn.Open();
                var query = "SELECT * FROM Products WHERE ProductId = @ProductId";
                var product = cnn.QueryFirstOrDefault<Product>(query, p);
                return product;

            }
        }

        // Funciona, pero es malo porque si tenemos muchos datos, realiza muchas consultas a la base de datos
        public List<Order> GetAllOrders2()
        {
            using (var cnn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;Encrypt=False"))
            {
                cnn.Open();
                var query = "SELECT OrderId, CustomerID FROM Orders";
                var orders = cnn.Query<Order>(query).ToList();

                if (orders != null)
                {
                    foreach (var o in orders)
                    {
                        var q = "SELECT * FROM [Order Details] WHERE OrderId = @OrderId";
                        o.Details = new List<OrderDetail>();
                        o.Details.AddRange(cnn.Query<OrderDetail>(query, o).ToList());
                    }
                }

                return orders;

            }
        }


        // De esta forma solo realizamos una consulta
        public List<Order> GetAllOrders()
        {
            using var cnn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;Encrypt=False");
            
            cnn.Open();
            var query = "SELECT o.OrderId, o.CustomerID, od.* FROM Orders o" + 
                "INNER JOIN [Order Details] od ON o.OrderID = od.OrderID";

            var dicc = new Dictionary<int, Order>();

            cnn.Query<Order, OrderDetail, Order>(query,
                (o, d) =>
                {
                    if (!dicc.TryGetValue(o.OrderID, out Order order))
                        dicc.Add(o.OrderID, order = o);

                    if (order.Details == null)
                        order.Details = new List<OrderDetail>();

                    order.Details.Add(d);
                    return order;
                },
                splitOn: "OrderId").AsQueryable();

            var orders = dicc.Values.ToList();

            return orders;
        }

    }
}
