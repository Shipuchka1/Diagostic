﻿namespace Diagnostic.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pn_city
    {
        [Key]
        public int CityId { get; set; }

        [StringLength(200)]
        public string name { get; set; }
    }
}
