using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LocaLux_GestActivite.Models
{
    [Table("verification")]
    [Index("IdControleId", Name = "IDX_5AF1C50B6D9BEB51")]
    [Index("IdDegatId", Name = "IDX_5AF1C50B7428B409")]
    [Index("IdPieceId", Name = "IDX_5AF1C50B94D4233D")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Verification
    {
        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }
        [Column("id_piece_id", TypeName = "int(11)")]
        public int IdPieceId { get; set; }
        [Column("id_degat_id", TypeName = "int(11)")]
        public int IdDegatId { get; set; }
        [Column("id_controle_id", TypeName = "int(11)")]
        public int IdControleId { get; set; }

        [ForeignKey("IdControleId")]
        [InverseProperty("Verifications")]
        public virtual Controle IdControle { get; set; } = null!;
        [ForeignKey("IdDegatId")]
        [InverseProperty("Verifications")]
        public virtual TypeDegat IdDegat { get; set; } = null!;
        [ForeignKey("IdPieceId")]
        [InverseProperty("Verifications")]
        public virtual Piece IdPiece { get; set; } = null!;
    }
}
