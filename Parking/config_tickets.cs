//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Parking
{
    using System;
    using System.Collections.Generic;
    
    public partial class config_tickets
    {
        public int ID_ticket { get; set; }
        public Nullable<bool> Incluir_Logo { get; set; }
        public Nullable<bool> Tamaño_papel { get; set; }
        public string Estacionamiento { get; set; }
        public string Direccion { get; set; }
        public string Razon_Social { get; set; }
        public string Telefono { get; set; }
        public string RFC { get; set; }
        public string DatosEntrada { get; set; }
        public string DatosSalida { get; set; }
        public string DatosPerdido { get; set; }
        public string DatosCortesia { get; set; }
        public string DatosConvenio { get; set; }
        public string DatosCancelado { get; set; }
        public string DatosPension { get; set; }
        public byte[] Imagen { get; set; }
        public int Cantidad_Copias_Entrada { get; set; }
        public int Cantidad_Copias_Salida { get; set; }
        public string Desarrollador { get; set; }
    }
}
