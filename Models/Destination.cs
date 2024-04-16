using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LocaLux_GestActivite.Models
{
    [Table("destination")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Destination
    {
        public Destination()
        {
            ReservationDestinationArrivers = new HashSet<Reservation>();
            ReservationDestinationDeparts = new HashSet<Reservation>();
        }

        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }
        [Column("libelle")]
        [StringLength(255)]
        public string Libelle { get; set; } = null!;

        [InverseProperty("DestinationArriver")]
        public virtual ICollection<Reservation> ReservationDestinationArrivers { get; set; }
        [InverseProperty("DestinationDepart")]
        public virtual ICollection<Reservation> ReservationDestinationDeparts { get; set; }
    }
}
