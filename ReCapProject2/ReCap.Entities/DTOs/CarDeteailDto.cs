using ReCap.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Entities.DTOs
{
    public class CarDeteailDto:IDto
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
