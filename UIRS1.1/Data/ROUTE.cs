namespace UIRS1._1.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ROUTE")]
    public partial class ROUTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ROUTE()
        {
            Obrashenies = new HashSet<Obrashenies>();
        }

        public Guid ID { get; set; }

        [Required]
        [StringLength(4)]
        public string NUMBER { get; set; }

        public short TYPE { get; set; }

        [Required]
        [StringLength(10)]
        public string SHORT_NAME { get; set; }

        public short STATUS { get; set; }

        public bool IS_PREDICTABLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Obrashenies> Obrashenies { get; set; }
    }
}
