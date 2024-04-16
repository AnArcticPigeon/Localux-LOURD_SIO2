using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LocaLux_GestActivite.Models
{
    [Table("forfait")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Forfait
    {
        public Forfait()
        {
            Reservations = new HashSet<Reservation>();
        }

        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }
        [Column("nb_heure")]
        public double NbHeure { get; set; }
        [Column("nb_kilometre", TypeName = "int(11)")]
        public int NbKilometre { get; set; }

        [InverseProperty("LeForfait")]
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
