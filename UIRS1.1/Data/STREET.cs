namespace UIRS1._1.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STREET")]
    public partial class STREET
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STREET()
        {
            AUTO_STOP = new HashSet<AUTO_STOP>();
            TRAM_STOP = new HashSet<TRAM_STOP>();
        }

        public Guid ID { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }

        public short STATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AUTO_STOP> AUTO_STOP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRAM_STOP> TRAM_STOP { get; set; }
    }
}
