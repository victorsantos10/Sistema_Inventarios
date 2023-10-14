using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventarios
{
    internal class EntradaClase
    {
        public string Proveedor {  get; set; }
        public string Producto1 { get; set; }
        public string Producto2 { get; set; }
        public string Producto3 { get; set; }
        public string Producto4 { get; set; }

        public string Unidad1 { get; set; }
        public string Unidad2 { get; set; }
        public string Unidad3 { get;set; }
        public string Unidad4 { get;set; }

        public int Cantidad1 { get; set; }  
        public int Cantidad2 { get;set; }
        public int Cantidad3 { get; set ;}
        public int Cantidad4 { get;set ;}

        public string Cliente { get; set; } 

    }
}
