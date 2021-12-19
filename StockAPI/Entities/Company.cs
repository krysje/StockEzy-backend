using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockAPI.Entities
{
    [Table("company")]
    public class Company
    {
        [Key]
        [Column("Company_Code")]
        public string CompanyCode { get; set; }

        [Required]
        [StringLength(30)]
        public string CompanyName { get; set; }

        public float Turnover { get; set; }

        public string CEO { get; set; }

        public string BoardOfDirectors { get; set; }

        public string ListedinStockExchanges { get; set; }

        [ForeignKey("Sector")]
        public long SectorId { get; set; }

        public string Brief { get; set; }


        // navigation properties
        public virtual Sector Sector { get; set; }


        //   public virtual ICollection<StockPrice> StockIds { get; set; }
        //   public virtual IPODetails IPODetails { get; set; }
        //   public virtual StockPrice StockPrice { get; set; }

    }
}
