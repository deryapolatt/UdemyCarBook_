using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.CarPricingDtos
{
    public class ResultCarPricingWithCarDto
    {
        public int CarPricingID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Amount { get; set; }
        public string CoverImageUrl { get; set; }
    }
}
