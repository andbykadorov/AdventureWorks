﻿using System;
using System.Collections.Generic;

namespace WebApp.Models.AdventureWorks
{
    public partial class SpecialOfferOndisk
    {
        public SpecialOfferOndisk()
        {
            SpecialOfferProductOndisk = new HashSet<SpecialOfferProductOndisk>();
        }

        public int SpecialOfferId { get; set; }
        public string Description { get; set; }
        public decimal DiscountPct { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MinQty { get; set; }
        public int? MaxQty { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<SpecialOfferProductOndisk> SpecialOfferProductOndisk { get; set; }
    }
}
