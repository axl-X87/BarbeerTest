//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Barbeer.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Service
    {
        public Service()
        {
            this.Record = new HashSet<Record>();
        }
    
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public decimal Price { get; set; }
        public byte[] Photo { get; set; }
    
        public virtual ICollection<Record> Record { get; set; }
    }
}