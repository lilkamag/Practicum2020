//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practicum2020.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_SPEC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_SPEC()
        {
            this.TB_ITEMS = new HashSet<TB_ITEMS>();
        }
    
        public int ID_SPEC { get; set; }
        public Nullable<System.DateTime> DATE { get; set; }
        public Nullable<System.TimeSpan> TIME { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ITEMS> TB_ITEMS { get; set; }
    }
}
