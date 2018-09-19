//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InsuranceManagement.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class HealthCareProvider
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HealthCareProvider()
        {
            this.Claims = new HashSet<Claim>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> IdType { get; set; }
        public string Address { get; set; }
        public string MainPhoneNumber { get; set; }
        public string OtherPhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Remarks { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim> Claims { get; set; }
        public virtual HealthCareProviderType HealthCareProviderType { get; set; }
    }
}