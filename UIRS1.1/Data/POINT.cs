namespace UIRS1._1.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("POINT")]
    public partial class POINT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public POINT()
        {
            Obrashenies = new HashSet<Obrashenies>();
        }

        public Guid ID { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string SHORT_NAME { get; set; }

        public float LATITUDE { get; set; }

        public float LONGITUDE { get; set; }

        public float? RADIUS { get; set; }

        [StringLength(300)]
        public string WKT_DESCRIPTION { get; set; }

        public float? ANGLE { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRIPTION { get; set; }

        public short STATUS { get; set; }

        public virtual AUTO_STOP AUTO_STOP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Obrashenies> Obrashenies { get; set; }

        public virtual TRAM_STOP TRAM_STOP { get; set; }
    }
}
