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
    
    public partial class BlackList
    {
        public int Id { get; set; }
        public Nullable<int> ClientId { get; set; }
        public Nullable<System.DateTime> DateOfBan { get; set; }
        public Nullable<int> BarberId { get; set; }
    
        public virtual Barber Barber { get; set; }
        public virtual Client Client { get; set; }
    }
}