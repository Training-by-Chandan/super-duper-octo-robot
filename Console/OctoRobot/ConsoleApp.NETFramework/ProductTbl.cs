//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp.NETFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductTbl
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public Nullable<int> CategoryId { get; set; }
    
        public virtual CategoryTbl CategoryTbl { get; set; }
    }
}
