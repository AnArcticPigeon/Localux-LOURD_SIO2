using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LocaLux_GestActivite.Models
{
    [Table("utilisateur")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Utilisateur
    {
        public Utilisateur()
        {
            AncienMdps = new HashSet<AncienMdp>();
            Controles = new HashSet<Controle>();
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
        [Column("email")]
        [StringLength(255)]
        public string? Email { get; set; }
        [Column("login")]
        [StringLength(255)]
        public string? Login { get; set; }
        [Column("mdp")]
        [StringLength(255)]
        public string? Mdp { get; set; }
        [Column("sel")]
        [StringLength(255)]
        public string? Sel { get; set; }
        [Column("code_otp")]
        [StringLength(32)]
        public string? CodeOtp { get; set; }

        [InverseProperty("Utilisateur")]
        public virtual ICollection<AncienMdp> AncienMdps { get; set; }
        [InverseProperty("EmployeVerif")]
        public virtual ICollection<Controle> Controles { get; set; }
        [InverseProperty("LeClient")]
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
