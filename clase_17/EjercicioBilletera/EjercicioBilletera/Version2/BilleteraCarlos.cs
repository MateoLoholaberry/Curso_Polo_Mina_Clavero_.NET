using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBilletera.Version2
{
    public class BilleteraCarlos : IBilletera
    {
        private int[,] billetes = new int[7, 2];

        public BilleteraCarlos()
        {
            billetes[0, 1] = 10;
            billetes[1, 1] = 20;
            billetes[2, 1] = 50;
            billetes[3, 1] = 100;
            billetes[4, 1] = 200;
            billetes[5, 1] = 500;
            billetes[6, 1] = 1000;

        }

        public int BilletesDe10
        {
            get { return billetes[0, 0]; }
            set { billetes[0, 0] = value; }
        }
        public int BilletesDe20
        {
            get { return billetes[1, 0]; }
            set { billetes[1, 0] = value; }
        }
        public int BilletesDe50
        {
            get { return billetes[2, 0]; }
            set { billetes[2, 0] = value; }
        }
        public int BilletesDe100
        {
            get { return billetes[3, 0]; }
            set { billetes[3, 0] = value; }
        }
        public int BilletesDe200
        {
            get { return billetes[4, 0]; }
            set { billetes[4, 0] = value; }
        }
        public int BilletesDe500
        {
            get { return billetes[5, 0]; }
            set { billetes[5, 0] = value; }
        }
        public int BilletesDe1000
        {
            get { return billetes[6, 0]; }
            set { billetes[6, 0] = value; }
        }


        public decimal Total()
        {
            decimal total = 0;
            for (int i = 0; i < billetes.GetLength(0); i++)
            {
                total += billetes[i, 0] * billetes[i, 1];
            }
            return total;

        }

        public IBilletera Combinar(IBilletera b2)
        {
            var b3 = new BilleteraCarlos();

            //Combinamos
            b3.BilletesDe10 = BilletesDe10 + b2.BilletesDe10;
            b3.BilletesDe20 = BilletesDe20 + b2.BilletesDe20;
            b3.BilletesDe50 = BilletesDe50 + b2.BilletesDe50;
            b3.BilletesDe100 = BilletesDe100 + b2.BilletesDe100;
            b3.BilletesDe200 = BilletesDe200 + b2.BilletesDe200;
            b3.BilletesDe500 = BilletesDe500 + b2.BilletesDe500;
            b3.BilletesDe1000 = BilletesDe1000 + b2.BilletesDe1000;

            //Vaciamos billetera actual
            Vaciar();

            //vaciamos billetera b2
            b2.BilletesDe10 = 0;
            b2.BilletesDe20 = 0;
            b2.BilletesDe50 = 0;
            b2.BilletesDe100 = 0;
            b2.BilletesDe200 = 0;
            b2.BilletesDe500 = 0;
            b2.BilletesDe1000 = 0;

            return b3;
        }

        private void Vaciar()
        {
            for (int i = 0; i < billetes.GetLength(0); i++)
            {
                billetes[i, 0] = 0;
            }
        }

    }
}
