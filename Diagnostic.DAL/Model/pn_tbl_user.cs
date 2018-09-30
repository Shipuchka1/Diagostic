namespace Diagnostic.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pn_tbl_user
    {
        [Key]
        public int userId { get; set; }

        [StringLength(100)]
        public string login { get; set; }

        [StringLength(100)]
        public string password { get; set; }

        [StringLength(200)]
        public string address { get; set; }

        [StringLength(200)]
        public string name { get; set; }

        [StringLength(200)]
        public string phoneNo { get; set; }

        public int? age { get; set; }

        public int? gender { get; set; }

        public int? userRoleId { get; set; }
    }
}
