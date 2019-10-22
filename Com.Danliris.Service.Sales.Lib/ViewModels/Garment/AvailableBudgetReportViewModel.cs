﻿using System;

namespace Com.Danliris.Service.Sales.Lib.ViewModels.Garment
{
    public class AvailableBudgetReportViewModel
    {
        public DateTime CostCalculationDate { get; set; }
        public DateTime ApprovedPPICDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string RONo { get; set; }
        public string Article { get; set; }
        public int DateDiff { get; set; }
        public string Buyer { get; set; }
        public double Quantity { get; set; }
        public string Uom { get; set; }
    }
}
