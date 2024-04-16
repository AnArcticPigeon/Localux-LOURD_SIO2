using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LocaLux_GestActivite.Models
{
    [Table("voiture")]
    [Index("LeModeleId", Name = "IDX_E9E2810F750CA3FD")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Voiture
    {
        public Voiture()
        {
            Reservations = new HashSet<Reservation>();
        }

        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }
        [Column("immatriculation")]
        [StringLength(255)]
        public string? Immatriculation { get; set; }
        [Column("kilometrage", TypeName = "int(11)")]
        public int Kilometrage { get; set; }
        [Column("le_modele_id", TypeName = "int(11)")]
        public int? LeModeleId { get; set; }

        [ForeignKey("LeModeleId")]
        [InverseProperty("Voitures")]
        public virtual Modele? LeModele { get; set; }
        [InverseProperty("LaVoiture")]
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
