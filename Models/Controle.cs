using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LocaLux_GestActivite.Models
{
    [Table("controle")]
    [Index("EmployeVerifId", Name = "IDX_E39396ECC0DD409")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Controle
    {
        public Controle()
        {
            Reservations = new HashSet<Reservation>();
            Verifications = new HashSet<Verification>();
        }

        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }
        [Column("employe_verif_id", TypeName = "int(11)")]
        public int EmployeVerifId { get; set; }
        [Column("cout_reparation")]
        public double CoutReparation { get; set; }
        [Column("observation")]
        [StringLength(255)]
        public string? Observation { get; set; }
        [Column("date_heure", TypeName = "datetime")]
        public DateTime DateHeure { get; set; }
        [Column("kilometrage_retour", TypeName = "int(11)")]
        public int KilometrageRetour { get; set; }
        [Column("kilometrage_effectue", TypeName = "int(11)")]
        public int KilometrageEffectue { get; set; }

        [ForeignKey("EmployeVerifId")]
        [InverseProperty("Controles")]
        public virtual Utilisateur EmployeVerif { get; set; } = null!;
        [InverseProperty("LeControle")]
        public virtual ICollection<Reservation> Reservations { get; set; }
        [InverseProperty("IdControle")]
        public virtual ICollection<Verification> Verifications { get; set; }
    }
}
