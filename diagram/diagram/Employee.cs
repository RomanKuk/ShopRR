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
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.EmployeeAccount = new HashSet<EmployeeAccount>();
            this.Sales = new HashSet<Sales>();
            this.Shipment = new HashSet<Shipment>();
            this.Transportation = new HashSet<Transportation>();
        }
    
        public int Employee_ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Address { get; set; }
        public string Phone { get; set; }
        public int Profession_ID { get; set; }
        public System.DateTime HiringDate { get; set; }
        public Nullable<int> Shop_ID { get; set; }
    
        public virtual Address Address1 { get; set; }
        public virtual Profession Profession { get; set; }
        public virtual Shops Shops { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeAccount> EmployeeAccount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sales> Sales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shipment> Shipment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transportation> Transportation { get; set; }
    }
}
