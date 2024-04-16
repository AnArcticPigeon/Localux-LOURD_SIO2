using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LocaLux_GestActivite.Models
{
    [Table("doctrine_migration_versions")]
    [MySqlCharSet("utf8mb3")]
    [MySqlCollation("utf8mb3_unicode_ci")]
    public partial class DoctrineMigrationVersion
    {
        [Key]
        [Column("version")]
        [StringLength(191)]
        public string Version { get; set; } = null!;
        [Column("executed_at", TypeName = "datetime")]
        public DateTime? ExecutedAt { get; set; }
        [Column("execution_time", TypeName = "int(11)")]
        public int? ExecutionTime { get; set; }
    }
}
