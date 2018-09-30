namespace Diagnostic.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pn_tests
    {
        [Key]
        public int testId { get; set; }

        [StringLength(300)]
        public string name { get; set; }

        
        public int price{ get; set; }

        public int laboratoryId { get; set; }
    }
}
