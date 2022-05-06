using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TravelList.Models
{
    public partial class Locations
    {
        [Key]
        [Column("LocationID")]
        public int LocationId { get; set; }
        public string Destination { get; set; }
        public string Country { get; set; }
        [StringLength(50)]
        public string Transportation { get; set; }
        [StringLength(50)]
        public string Boarding { get; set; }
    }
}
