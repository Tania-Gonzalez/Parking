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
    
    public partial class pensiones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pensiones()
        {
            this.banco_pension = new HashSet<banco_pension>();
        }
    
        public int ID_Tipo_Pension { get; set; }
        public string Pensn_Tipo { get; set; }
        public Nullable<decimal> Pens_Bonificacion { get; set; }
        public Nullable<decimal> Pens_Costo_Regular { get; set; }
        public Nullable<int> Pens_Tolerancia_dias { get; set; }
        public Nullable<decimal> Pens_Recargos { get; set; }
        public Nullable<int> Pens_Cobro_1 { get; set; }
        public Nullable<int> Pens_Cobro_2 { get; set; }
        public Nullable<int> Pens_DiasInactivo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<banco_pension> banco_pension { get; set; }
    }
}
