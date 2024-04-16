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
        }

        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }
        [Column("employe_verif_id", TypeName = "int(11)")]
        public int EmployeVerifId { get; set; }
        [Column("aile_av_g")]
        [StringLength(255)]
        public string? AileAvG { get; set; }
        [Column("aile_ar_g")]
        [StringLength(255)]
        public string? AileArG { get; set; }
        [Column("aile_av_d")]
        [StringLength(255)]
        public string? AileAvD { get; set; }
        [Column("aile_ar_d")]
        [StringLength(255)]
        public string? AileArD { get; set; }
        [Column("calandre")]
        [StringLength(255)]
        public string? Calandre { get; set; }
        [Column("phare_av_g")]
        [StringLength(255)]
        public string? PhareAvG { get; set; }
        [Column("phare_av_d")]
        [StringLength(255)]
        public string? PhareAvD { get; set; }
        [Column("phare_ar_g")]
        [StringLength(255)]
        public string? PhareArG { get; set; }
        [Column("phare_ar_d")]
        [StringLength(255)]
        public string? PhareArD { get; set; }
        [Column("siege_cond")]
        [StringLength(255)]
        public string? SiegeCond { get; set; }
        [Column("siege_pass")]
        [StringLength(255)]
        public string? SiegePass { get; set; }
        [Column("tableau_de_bord")]
        [StringLength(255)]
        public string? TableauDeBord { get; set; }
        [Column("porte_av_g")]
        [StringLength(255)]
        public string? PorteAvG { get; set; }
        [Column("porte_av_d")]
        [StringLength(255)]
        public string? PorteAvD { get; set; }
        [Column("porte_ar_g")]
        [StringLength(255)]
        public string? PorteArG { get; set; }
        [Column("porte_ar_d")]
        [StringLength(255)]
        public string? PorteArD { get; set; }
        [Column("coffre")]
        [StringLength(255)]
        public string? Coffre { get; set; }
        [Column("cout_reparation")]
        public double CoutReparation { get; set; }
        [Column("observation")]
        [StringLength(255)]
        public string? Observation { get; set; }
        [Column("date_heure", TypeName = "datetime")]
        public DateTime DateHeure { get; set; }

        [ForeignKey("EmployeVerifId")]
        [InverseProperty("Controles")]
        public virtual Utilisateur EmployeVerif { get; set; } = null!;
        [InverseProperty("LeControle")]
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
