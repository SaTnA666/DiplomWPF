//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiplomWSR.MVVM.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Statistics
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> LoginTime { get; set; }
        public Nullable<System.DateTime> ReleaseTime { get; set; }
        public Nullable<int> CalculationsCarried { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> Efficiency { get; set; }
    
        public virtual User User { get; set; }
    }
}
