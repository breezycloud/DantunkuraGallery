using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DantunkuraGallery.Shared
{
    public  class Transactions
    {
        private const string CurrencyFormat = "NGN";

        public int Id { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? Tdate { get; set; }        
        public decimal? TotalAmount { get; set; }
        public int? StaffId { get; set; }
        public decimal? Discount { get; set; }
        public decimal? SubTotal { get; set; }

        public string FormattedTotalAmount => $"{CurrencyFormat}{TotalAmount:N}";
        public string FormattedDiscount => $"{CurrencyFormat}{Discount:N}";
        public string FormattedSubTotal => $"{CurrencyFormat}{SubTotal:N}";
    }
}
