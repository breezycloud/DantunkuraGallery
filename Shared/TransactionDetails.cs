using System;
using System.Collections.Generic;
using System.Text;

namespace DantunkuraGallery.Shared
{
    public class TransactionDetails
    {
        public int TDetailsNo { get; set; }
        public string InvoiceNo { get; set; }
        public Guid ProductNo { get; set; }
        public decimal ItemPrice { get; set; }
        public float Quantity { get; set; }
    }
}
