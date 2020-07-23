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
    
    public partial class banco_pension
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public banco_pension()
        {
            this.bitacora_pensiones = new HashSet<bitacora_pensiones>();
        }
    
        public int ID { get; set; }
        public string Folio { get; set; }
        public Nullable<System.DateTime> FechaInscripcion { get; set; }
        public Nullable<System.DateTime> FechaUltimoPago { get; set; }
        public string CobradoPor { get; set; }
        public Nullable<System.DateTime> Inicio_Pension { get; set; }
        public Nullable<System.DateTime> Fin_Pension { get; set; }
        public int ID_Tipo_Pension { get; set; }
        public Nullable<bool> StatusPago { get; set; }
        public Nullable<int> No_PagosAnticipados { get; set; }
        public Nullable<decimal> Costo { get; set; }
        public Nullable<decimal> Pagos { get; set; }
        public Nullable<int> Id_cliente { get; set; }
        public Nullable<bool> Pension_Corte { get; set; }
        public Nullable<bool> Pension_Activa { get; set; }
        public Nullable<int> Id_corte { get; set; }
    
        public virtual pensiones pensiones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bitacora_pensiones> bitacora_pensiones { get; set; }
    }
}
