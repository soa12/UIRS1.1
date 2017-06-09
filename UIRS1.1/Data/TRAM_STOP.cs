namespace UIRS1._1.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRAM_STOP
    {
        public Guid ID { get; set; }

        public Guid STREET_ID { get; set; }

        public bool STREET_SIDE { get; set; }

        public virtual POINT POINT { get; set; }

        public virtual STREET STREET { get; set; }
    }
}
