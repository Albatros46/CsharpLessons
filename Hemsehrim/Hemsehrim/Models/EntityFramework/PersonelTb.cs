//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hemsehrim.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonelTb
    {
        public int Id { get; set; }
        public Nullable<int> DepartmanId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        public Nullable<bool> Cinsiyet { get; set; }
        public Nullable<bool> MedeniHali { get; set; }
    
        public virtual DepartmanTb DepartmanTb { get; set; }
    }
}
