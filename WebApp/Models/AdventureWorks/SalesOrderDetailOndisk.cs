﻿using System;

namespace WebApp.Models.AdventureWorks
{
    public partial class SalesOrderDetailOndisk
    {
        public int SalesOrderId { get; set; }
        public long SalesOrderDetailId { get; set; }
        public string CarrierTrackingNumber { get; set; }
        public short OrderQty { get; set; }
        public int ProductId { get; set; }
        public int SpecialOfferId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitPriceDiscount { get; set; }
        public DateTime ModifiedDate { get; set; }

        public SalesOrderHeaderOndisk SalesOrder { get; set; }
        public SpecialOfferProductOndisk SpecialOfferProductOndisk { get; set; }
    }
}
