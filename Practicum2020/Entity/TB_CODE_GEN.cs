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
    
    public partial class TB_CODE_GEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_CODE_GEN()
        {
            this.TB_ITEM_DESK = new HashSet<TB_ITEM_DESK>();
        }
    
        public int ID_GEN { get; set; }
        public string NAME_GEN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ITEM_DESK> TB_ITEM_DESK { get; set; }
    }
}