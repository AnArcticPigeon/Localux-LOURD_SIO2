using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LocaLux_GestActivite.Models
{
    [Table("reservation")]
    [Index("LaVoitureId", Name = "IDX_42C849552187EC6E")]
    [Index("LeControleId", Name = "IDX_42C8495534AE5CB9")]
    [Index("DestinationArriverId", Name = "IDX_42C849557A078AD6")]
    [Index("LeChauffeurId", Name = "IDX_42C849558899931")]
    [Index("LeForfaitId", Name = "IDX_42C84955B36D2087")]
    [Index("LeClientId", Name = "IDX_42C84955C0F37DD6")]
    [Index("DestinationDepartId", Name = "IDX_42C84955FF824EB1")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Reservation
    {
        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }
        [Column("datereservation", TypeName = "datetime")]
        public DateTime Datereservation { get; set; }
        [Column("date_debut_reservation", TypeName = "datetime")]
        public DateTime DateDebutReservation { get; set; }
        [Column("type")]
        [StringLength(255)]
        public string Type { get; set; } = null!;
        [Column("la_voiture_id", TypeName = "int(11)")]
        public int LaVoitureId { get; set; }
        [Column("le_client_id", TypeName = "int(11)")]
        public int LeClientId { get; set; }
        [Column("destination_depart_id", TypeName = "int(11)")]
        public int DestinationDepartId { get; set; }
        [Column("destination_arriver_id", TypeName = "int(11)")]
        public int DestinationArriverId { get; set; }
        [Column("le_chauffeur_id", TypeName = "int(11)")]
        public int? LeChauffeurId { get; set; }
        [Column("le_forfait_id", TypeName = "int(11)")]
        public int? LeForfaitId { get; set; }
        [Column("le_controle_id", TypeName = "int(11)")]
        public int? LeControleId { get; set; }

        [ForeignKey("DestinationArriverId")]
        [InverseProperty("ReservationDestinationArrivers")]
        public virtual Destination DestinationArriver { get; set; } = null!;
        [ForeignKey("DestinationDepartId")]
        [InverseProperty("ReservationDestinationDeparts")]
        public virtual Destination DestinationDepart { get; set; } = null!;
        [ForeignKey("LaVoitureId")]
        [InverseProperty("Reservations")]
        public virtual Voiture LaVoiture { get; set; } = null!;
        [ForeignKey("LeChauffeurId")]
        [InverseProperty("Reservations")]
        public virtual Chauffeur? LeChauffeur { get; set; }
        [ForeignKey("LeClientId")]
        [InverseProperty("Reservations")]
        public virtual Utilisateur LeClient { get; set; } = null!;
        [ForeignKey("LeControleId")]
        [InverseProperty("Reservations")]
        public virtual Controle? LeControle { get; set; }
        [ForeignKey("LeForfaitId")]
        [InverseProperty("Reservations")]
        public virtual Forfait? LeForfait { get; set; }
    }
}
