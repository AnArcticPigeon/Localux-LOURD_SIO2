using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LocaLux_GestActivite.Models
{
    [Table("ancien_mdp")]
    [Index("UtilisateurId", Name = "IDX_F58A3CBDFB88E14F")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class AncienMdp
    {
        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }
        [Column("utilisateur_id", TypeName = "int(11)")]
        public int UtilisateurId { get; set; }
        [Column("date_modif_mdp", TypeName = "datetime")]
        public DateTime? DateModifMdp { get; set; }
        [Column("ancien_mdp")]
        [StringLength(255)]
        public string? AncienMdp1 { get; set; }

        [ForeignKey("UtilisateurId")]
        [InverseProperty("AncienMdps")]
        public virtual Utilisateur Utilisateur { get; set; } = null!;
    }
}
