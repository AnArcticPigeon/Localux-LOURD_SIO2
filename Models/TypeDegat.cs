using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LocaLux_GestActivite.Models
{
    [Table("type_degat")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class TypeDegat
    {
        public TypeDegat()
        {
            Verifications = new HashSet<Verification>();
        }

        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }
        [Column("libelle")]
        [StringLength(255)]
        public string Libelle { get; set; } = null!;

        [InverseProperty("IdDegat")]
        public virtual ICollection<Verification> Verifications { get; set; }
    }
}
