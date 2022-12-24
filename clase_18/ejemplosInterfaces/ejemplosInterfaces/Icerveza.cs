using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplosInterfaces
{
    internal interface Icerveza : IBebidaAlcoholica
    {
        int IBU { get; set; }
    }
}
