using ApiDapper.Data;
using ApiDapper.Models;

namespace ApiDapper.Rules
{
    public class OrderRule
    {

        public RespuestaDelete DeleteOrderById(int orderId)
        {
            try
            {
                var data = new NorthwindData();
                var cant = data.DeleteOrderById(orderId);

                return new RespuestaDelete()
                {
                    Cantidad = cant,
                    Resultado = true,
                    Mensaje = "Eliminación exitosa"
                };
            }
            catch (Exception ex)
            {
                return new RespuestaDelete()
                {
                    Cantidad = 0,
                    Resultado = false,
                    Mensaje = ex.Message
                };
            }

            
        }
    }
}
