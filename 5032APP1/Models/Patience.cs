namespace _5032APP1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Patience")]
    public partial class Patience
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Doctor_name { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Patience_name { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Patience_age { get; set; }

        [Key]
        [Column(Order = 4)]
        public string Patiene_service { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime date { get; set; }
    }
}
