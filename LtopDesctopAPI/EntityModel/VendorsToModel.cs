//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LtopDesctopAPI.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class VendorsToModel
    {
        public long ID { get; set; }
        public Nullable<long> VendorsId { get; set; }
        public Nullable<long> ModelsId { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual Model Model { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
