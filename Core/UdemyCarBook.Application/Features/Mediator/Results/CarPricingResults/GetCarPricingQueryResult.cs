﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.Mediator.Results.CarPricingResults
{
    public class GetCarPricingQueryResult
    {
        public int CarPricingID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Amount { get; set; }
        public string CoverImageUrl { get; set; }
    }
}
