using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    public partial class IpdataDny
    {
        public int Uid { get; set; }
        public uint IpFrom { get; set; }
        public uint IpTo { get; set; }
        public string? CountryCode { get; set; }
        public string? CountryName { get; set; }
        public string? RegionName { get; set; }
        public string? CityName { get; set; }
        public string? CountryCnname { get; set; }
        public string? RegionCnname { get; set; }
        public string? CityCnname { get; set; }
    }
}
