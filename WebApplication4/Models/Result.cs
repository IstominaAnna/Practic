namespace WebApplication4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Result
    {
        [Key]
        public int ResultsId { get; set; }

        public int RegistrationId { get; set; }

        public int? RaceTime { get; set; }

        [Required]
        [StringLength(50)]
        public string RaceType { get; set; }

        public virtual Registration Registration { get; set; }
    }
}
