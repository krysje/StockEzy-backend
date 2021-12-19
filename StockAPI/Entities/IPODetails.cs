using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockAPI.Entities
{
    [Table("ipo_details")]
    public class IPODetails
    {
        [Key]
        [Column("Id")]
        public long IPODetailsId { get; set; }

        [ForeignKey("Company")]
        public string CompanyCode { get; set; }

        [ForeignKey("StockExchanges")]
        public string StockExchange { get; set; }

        public float PricePerShare { get; set; }

        public long TotalShares { get; set; }

        [DataType(DataType.DateTime)]
        public DataType OpenDateTime { get; set; }

        public string Remarks { get; set; }


        //navigation properties
        public virtual Company Company { get; set; }
        public virtual StockExchanges StockExchanges { get; set; }

    }
}