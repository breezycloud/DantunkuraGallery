using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DantunkuraGallery.Shared
{
    public class Products
    {
        private const string CurrencyFormat = "NGN";

        public Guid ProductNo { get; set; }
        public Guid CategoryNo { get; set; } = Guid.NewGuid();
        [Required(ErrorMessage = "Model No field is required!")]
        public string ModelNo { get; set; } = "";
        [Required(ErrorMessage = "Product Name field is required!")]
        public string ProductCode { get; set; } = "";
        public string Description { get; set; } = "";
        [Required(ErrorMessage = "Product Cost field is required!")]
        public decimal UnitPrice { get; set; } = 0;
        public string Barcode { get; set; } = "";
        [Required(ErrorMessage = "Quanity field is required!")]
        public float? StocksOnHand { get; set; } = 0;
        public int ReOrderLevel { get; set; } = 0;

        public string FormattedPrice => $"{CurrencyFormat}{UnitPrice:N}";

        public virtual Category Category { get; set; }
        public virtual ICollection<StockIn> StockIn { get; set; }
        public virtual ICollection<TransactionDetails> TransactionDetails { get; set; }

    }
}
