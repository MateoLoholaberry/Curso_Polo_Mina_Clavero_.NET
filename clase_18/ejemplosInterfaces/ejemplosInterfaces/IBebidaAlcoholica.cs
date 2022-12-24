using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplosInterfaces
{
    internal interface IBebidaAlcoholica : IBebida
    {
        public decimal Graduacion { get; set; }
    }
}
