//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace diagram
{
    using System;
    using System.Collections.Generic;
    
    public partial class Repair
    {
        public int Repair_ID { get; set; }
        public int ServiceTransportation_ID { get; set; }
        public string Comment { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual ServiceTransportation ServiceTransportation { get; set; }
    }
}
