using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockAPI.Entities
{
    [Table("stock")]
    public class StockPrice
    {
        [Key]
        [Column("Stock_Code")]
        public string StockCode { get; set; }

        [ForeignKey("Company")]
        public string CompanyCode { get; set; }

        [ForeignKey("StockExchanges")]
        public string StockExchange { get; set; }

        public float CurrentPrice { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan Time { get; set; }


        // navigation properties
        public virtual Company Company { get; set; }
        public virtual StockExchanges StockExchanges { get; set; }

    }
}
