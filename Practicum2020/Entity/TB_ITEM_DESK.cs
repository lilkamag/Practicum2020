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
    
    public partial class TB_ITEM_DESK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_ITEM_DESK()
        {
            this.TB_ITEMS = new HashSet<TB_ITEMS>();
        }
    
        public int ID_ITEMS { get; set; }
        public string NAME_ITEM { get; set; }
        public Nullable<int> ID_GEN { get; set; }
    
        public virtual TB_CODE_GEN TB_CODE_GEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ITEMS> TB_ITEMS { get; set; }
    }
}
