//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Дисциплина
    {
        public int id_дисциплины { get; set; }
        public string Название { get; set; }
    
        public virtual Дисциплина_Раздел Дисциплина_Раздел { get; set; }
    }
}
