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
    
    public partial class SeriesToDevice
    {
        public long ID { get; set; }
        public Nullable<long> DevicesId { get; set; }
        public Nullable<long> SeriesId { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual Device Device { get; set; }
        public virtual Series Series { get; set; }
    }
}
