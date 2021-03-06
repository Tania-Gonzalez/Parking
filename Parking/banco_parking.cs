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
    
    public partial class banco_parking
    {
        public int ID { get; set; }
        public string Folio { get; set; }
        public Nullable<System.DateTime> FechaEntrada { get; set; }
        public Nullable<System.TimeSpan> HoraEntrada { get; set; }
        public string ExpedidoPor { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public int ID_PensionU { get; set; }
        public int ID_Cobro { get; set; }
        public int ID_ServicioAd { get; set; }
        public int ID_Penalizacion { get; set; }
        public Nullable<System.DateTime> FechaSalida { get; set; }
        public Nullable<System.TimeSpan> HoraSalida { get; set; }
        public string CobradoPor { get; set; }
        public Nullable<System.TimeSpan> T_Parqueo { get; set; }
        public string Estancia { get; set; }
        public Nullable<decimal> Importe { get; set; }
        public Nullable<decimal> Pago { get; set; }
        public string ModoCobro { get; set; }
        public string ModoTicket { get; set; }
        public string Justificacion { get; set; }
        public Nullable<int> Corte { get; set; }
        public Nullable<int> Semana { get; set; }
        public Nullable<int> Mes { get; set; }
        public Nullable<int> Id_corte { get; set; }
    
        public virtual pensiones_unicas pensiones_unicas { get; set; }
        public virtual cobro cobro { get; set; }
        public virtual serviciosadicionales serviciosadicionales { get; set; }
        public virtual penalizaciones penalizaciones { get; set; }
        public virtual cortes cortes { get; set; }
    }
}
