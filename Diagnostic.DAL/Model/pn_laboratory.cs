namespace Diagnostic.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pn_laboratory
    {
        [Key]
        public int laboratoryID { get; set; }

        [StringLength(200)]
        public string name { get; set; }

        
        public int cityID { get; set; }

        [StringLength(200)]
        public string address { get; set; }

        [StringLength(100)]
        public string phoneNo { get; set; }

        [StringLength(500)]
        public string labeTimins { get; set; }
    }
}
