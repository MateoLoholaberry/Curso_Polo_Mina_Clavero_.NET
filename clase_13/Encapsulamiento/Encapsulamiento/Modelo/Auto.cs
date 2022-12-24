using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento.Modelo
{
    internal class Auto
    {
        //Campos - Son como variables que guarda la clase pero por lo general son privados
        //Los nombres de las variables del tipo privado por convención comienzan con minúscula
        
        //El guión bajo se usa para identificar que es un campo y diferenciarlo de las propiedades privadas
        //También el guion bajo es una convencion para acordarnos que es una variable privada
        //y solo se puede acceder desde dentro de la clase
        private string _tipoDeMotor;
        private string _anioDeFabricacion;
        private bool _bujiasOkey;


        public string TipoDeMotor
        {
            get { return _tipoDeMotor; } 
            set 
            {
                if (value == null || value == "")
                {
                    _tipoDeMotor = "Nafta";
                }
                else
                {
                    _tipoDeMotor = value;
                }
            }
        }


        //Propiedades auto implementadas
        //Todas las propiedades por debajo siempre tienen campos,
        //en estos casos los crea automaticamente
        //y ahi guarda lo que nosotros seteamos o luego obtenemos.
        //Y en el caso anterior de tipo de motor lo volvimos explícito
        public bool EstaEncendido { get; set; }
        public int AnioDeFabricacion { get; set; }
        public string Marca { get; set; }


    }
}
