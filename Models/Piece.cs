using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LocaLux_GestActivite.Models
{
    [Table("piece")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Piece
    {
        public Piece()
        {
            Verifications = new HashSet<Verification>();
            Modeles = new HashSet<Modele>();
        }

        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }
        [Column("libelle")]
        [StringLength(255)]
        public string Libelle { get; set; } = null!;

        [InverseProperty("IdPiece")]
        public virtual ICollection<Verification> Verifications { get; set; }

        [ForeignKey("PieceId")]
        [InverseProperty("Pieces")]
        public virtual ICollection<Modele> Modeles { get; set; }
    }
}
