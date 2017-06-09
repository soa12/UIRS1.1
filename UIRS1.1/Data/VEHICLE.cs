namespace UIRS1._1.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VEHICLE")]
    public partial class VEHICLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VEHICLE()
        {
            Obrashenies = new HashSet<Obrashenies>();
        }

        public Guid ID { get; set; }

        [Required]
        [StringLength(50)]
        public string STATE_NUMBER { get; set; }

        public short TYPE { get; set; }

        public short STATUS { get; set; }

        public Guid MODEL_ID { get; set; }

        public bool FOR_LIMITED_POSSIBILITIES { get; set; }

        public virtual MODEL MODEL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Obrashenies> Obrashenies { get; set; }
    }
}
