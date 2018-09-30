namespace Diagnostic.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pn_roles
    {
        [Key]
        public int roleId { get; set; }

        [StringLength(100)]
        public string name { get; set; }
    }
}
