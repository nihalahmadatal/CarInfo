using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInfo.Models.Validation_Classes
{
	public class CarModel
	{
        public int Car_Id { get; set; }
        public string Car_Name { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Price { get; set; }
        public Nullable<System.DateTime> Year { get; set; }
        public string Transmission { get; set; }
        public string Fuel_Type { get; set; }
        public string Features { get; set; }
        public List<string> Features_List { get; set; }
    }
}