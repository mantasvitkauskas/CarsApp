using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsApp.Models
{
    public class Car
    {
        public string Number { get; set; }
        public DateTime Year_Made { get; set; }
        public string Model { get; set; }
        public string CurrentSegmentName { get; set; }
        public string CurrentUserName { get; set; }
        public string StatusName { get; set; }
        public string PreviousSegmentName { get; set; }
        public string PreviousUserName { get; set; }
    }
}