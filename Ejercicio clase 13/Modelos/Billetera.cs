namespace Ejercicio_clase_13.Modelos
{
    public class Billetera
    {
        public int BilletesDe10 {get;set;}
        public int BilletesDe20 {get;set;}
        public int BilletesDe50 {get;set;}
        public int BilletesDe100 {get;set;}
        public int BilletesDe200 {get;set;}
        public int BilletesDe500 {get;set;}
        public int BilletesDe1000 {get;set;}



        public decimal total()
        {
            decimal importeTotal = BilletesDe10 * 10 + BilletesDe20 * 20 + BilletesDe50 * 50 + BilletesDe100 * 100 + BilletesDe200 * 200 + BilletesDe500 * 500 + BilletesDe1000 * 1000;

            return importeTotal;
        }


        public Billetera combinar(Billetera billetera)
        {

            int B10 = BilletesDe10 + billetera.BilletesDe10;
            BilletesDe10 = 0;
            billetera.BilletesDe10 = 0;


            int B20 = BilletesDe20 + billetera.BilletesDe20;
            BilletesDe20 = 0;
            billetera.BilletesDe20 = 0;

            int B50 = BilletesDe50 + billetera.BilletesDe50;
            BilletesDe50 = 0;
            billetera.BilletesDe50 = 0;

            int B100 = BilletesDe100 + billetera.BilletesDe100;
            BilletesDe100 = 0;
            billetera.BilletesDe100 = 0;

            int B200 = BilletesDe200 + billetera.BilletesDe200;
            BilletesDe200 = 0;
            billetera.BilletesDe200 = 0;

            int B500 = BilletesDe500 + billetera.BilletesDe500;
            BilletesDe500 = 0;
            billetera.BilletesDe500 = 0;

            int B1000 = BilletesDe1000 + billetera.BilletesDe1000;
            BilletesDe1000 = 0;
            billetera.BilletesDe1000 = 0;


            return new Billetera
            {
                BilletesDe10 = B10,
                BilletesDe20 = B20,
                BilletesDe50 = B50,
                BilletesDe100 = B100,
                BilletesDe200 = B200,
                BilletesDe500 = B500,
                BilletesDe1000 = B1000
            };
        }
    }
}