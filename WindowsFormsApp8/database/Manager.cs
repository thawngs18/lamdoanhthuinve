//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp8.database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Manager
    {
        public int ManagerId { get; set; }
        public string Password { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string id { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
    }
}
