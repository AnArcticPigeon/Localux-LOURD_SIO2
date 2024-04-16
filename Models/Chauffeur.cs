using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LocaLux_GestActivite.Models
{
    [Table("chauffeur")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Chauffeur
    {
        public Chauffeur()
        {
            Reservations = new HashSet<Reservation>();
        }

        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }
        [Column("nom")]
        [StringLength(255)]
        public string Nom { get; set; } = null!;
        [Column("prenom")]
        [StringLength(255)]
        public string Prenom { get; set; } = null!;

        [InverseProperty("LeChauffeur")]
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
