//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace e2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comicses
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comicses()
        {
            this.Delevery = new HashSet<Delevery>();
        }
    
        public int ID_Comicses { get; set; }
        public string Comics_Name { get; set; }
        public string Athor { get; set; }
        public string Price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Delevery> Delevery { get; set; }
    }
}
