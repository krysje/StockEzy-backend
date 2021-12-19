using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockAPI.Entities
{
    [Table("stock_exchange")]
    public class StockExchanges
    {
        [Key]
        [Column("Name")]
        public string StockExchange { get; set; }

        public string Brief { get; set; }

        public string ContactAddress { get; set; }

        public string Remarks { get; set; }


        // public virtual ICollection<Company> Companies { get; set; }


    }
}