using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockAPI.Entities
{
    [Table("sector")]
    public class Sector
    {
        [Key]
        [Column("Id")]
        public long SectorId { get; set; }

        [StringLength(30)]
        [Column("Name")]
        public string SectorName { get; set; }
        public string Brief { get; set; }

        //public ICollection<Company> Companies { get; set; }

    }
}