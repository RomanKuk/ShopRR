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
    
    public partial class Delivery
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Delivery()
        {
            this.Shipment = new HashSet<Shipment>();
        }
    
        public int Deliver_ID { get; set; }
        public string Code { get; set; }
        public int Good_ID { get; set; }
        public int ProvideOrder_ID { get; set; }
        public System.DateTime Date { get; set; }
        public int Count { get; set; }
    
        public virtual Goods Goods { get; set; }
        public virtual ProvideOrder ProvideOrder { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shipment> Shipment { get; set; }
    }
}
