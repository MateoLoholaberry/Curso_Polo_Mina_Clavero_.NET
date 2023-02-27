using ApiDapper.Models;
using ApiDapper.Rules;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiDapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public List<Product> GetAllProducts()
        {
            var rule = new ProductRule();

            return rule.GetAllProducts();
        }


        [HttpGet("/api/test/{id}")]
        public Product GetProduct(int id)
        {
            var rule = new ProductRule();

            return rule.GetProductById(id);
        }


        [HttpDelete("/api/orders/")]
        public RespuestaDelete DeleteOrderById(int orderId)
        {
            var rule = new OrderRule();
            return rule.DeleteOrderById(orderId);

            
        }
    }
}
