using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplosInterfaces
{
    internal class Gaseosa : IBebida
    {
        public decimal Volumen 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException();
        }
        public bool Gasificada
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public string Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Calorias { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Alcoholica { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
