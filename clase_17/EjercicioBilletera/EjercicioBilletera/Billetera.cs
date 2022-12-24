using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBilletera
{
    public class Billetera: IBilletera
    {
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }


        public decimal Total()
        {
                var total = BilletesDe10 * 10 + 
                    BilletesDe20 * 20 + 
                    BilletesDe50 * 50 + 
                    BilletesDe100 * 100 +
                    BilletesDe200 * 200 +
                    BilletesDe500 * 500 +
                    BilletesDe1000 * 1000;

                return total;
        }

        public IBilletera Combinar(IBilletera b2)
        {
            var b3 = new Billetera();

            //Combinamos
            b3.BilletesDe10 = BilletesDe10 + b2.BilletesDe10;
            b3.BilletesDe20 = BilletesDe20 + b2.BilletesDe20;
            b3.BilletesDe50 = BilletesDe50 + b2.BilletesDe50;
            b3.BilletesDe100 = BilletesDe100 + b2.BilletesDe100;
            b3.BilletesDe200 = BilletesDe200 + b2.BilletesDe200;
            b3.BilletesDe500 = BilletesDe500 + b2.BilletesDe500;
            b3.BilletesDe1000 = BilletesDe1000 + b2.BilletesDe1000;

            //Vaciamos billetera actual
            BilletesDe10 = 0;
            BilletesDe20 = 0;
            BilletesDe50 = 0;
            BilletesDe100 = 0;
            BilletesDe200 = 0;
            BilletesDe500 = 0;
            BilletesDe1000 = 0;

            //Vaciamos b2
            b2.BilletesDe10 = 0;
            b2.BilletesDe20 = 0;
            b2.BilletesDe50 = 0;
            b2.BilletesDe100 = 0;
            b2.BilletesDe200 = 0;
            b2.BilletesDe500 = 0;
            b2.BilletesDe1000 = 0;



            return b3;
        }

    }
}
