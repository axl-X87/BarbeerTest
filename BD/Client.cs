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
    
    public partial class Client
    {
        public Client()
        {
            this.BlackList = new HashSet<BlackList>();
            this.Record = new HashSet<Record>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<BlackList> BlackList { get; set; }
        public virtual ICollection<Record> Record { get; set; }
    }
}
