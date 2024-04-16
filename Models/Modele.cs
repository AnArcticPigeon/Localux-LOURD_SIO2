using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LocaLux_GestActivite.Models
{
    [Table("modele")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Modele
    {
        public Modele()
        {
            Voitures = new HashSet<Voiture>();
        }

        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }
        [Column("libelle")]
        [StringLength(255)]
        public string Libelle { get; set; } = null!;
        [Column("prix_kilo_sup")]
        public double PrixKiloSup { get; set; }
        [Column("prix_heure")]
        public double PrixHeure { get; set; }

        [InverseProperty("LeModele")]
        public virtual ICollection<Voiture> Voitures { get; set; }
    }
}
