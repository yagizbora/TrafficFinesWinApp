﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficFines.Models
{
    class CarModels
    {
        public int? Carid { get; set; }
        public string? Model { get; set; }
        public int? YearOfRelease { get; set; }
        public string? LicensePlate { get; set; }
        public decimal? InsurableValue { get; set; }
        public string? OwnerFullName { get; set; }
        public string? OwnerPassportData { get; set; }
    }
    class AddCarModels {
        public string? Model { get; set; }
        public int? YearOfRelease { get; set; }
        public string? LicensePlate { get; set; }
        public decimal? InsurableValue { get; set; }
        public string? OwnerFullName { get; set; }
        public string? OwnerPassportData { get; set; }
    }
}
