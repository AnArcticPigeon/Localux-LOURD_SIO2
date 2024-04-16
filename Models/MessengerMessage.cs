using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LocaLux_GestActivite.Models
{
    [Table("messenger_messages")]
    [Index("DeliveredAt", Name = "IDX_75EA56E016BA31DB")]
    [Index("AvailableAt", Name = "IDX_75EA56E0E3BD61CE")]
    [Index("QueueName", Name = "IDX_75EA56E0FB7336F0")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class MessengerMessage
    {
        [Key]
        [Column("id", TypeName = "bigint(20)")]
        public long Id { get; set; }
        [Column("body")]
        public string Body { get; set; } = null!;
        [Column("headers")]
        public string Headers { get; set; } = null!;
        [Column("queue_name")]
        [StringLength(190)]
        public string QueueName { get; set; } = null!;
        /// <summary>
        /// (DC2Type:datetime_immutable)
        /// </summary>
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// (DC2Type:datetime_immutable)
        /// </summary>
        [Column("available_at", TypeName = "datetime")]
        public DateTime AvailableAt { get; set; }
        /// <summary>
        /// (DC2Type:datetime_immutable)
        /// </summary>
        [Column("delivered_at", TypeName = "datetime")]
        public DateTime? DeliveredAt { get; set; }
    }
}
