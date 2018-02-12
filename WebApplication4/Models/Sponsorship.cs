namespace WebApplication4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sponsorship")]
    public partial class Sponsorship
    {
        public int SponsorshipId { get; set; }

        [Required]
        [StringLength(150)]
        public string SponsorshipName { get; set; }

        public decimal Amount { get; set; }

        public int RegistrationId { get; set; }

        public virtual Registration Registration { get; set; }
    }
}
