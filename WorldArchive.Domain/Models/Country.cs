﻿using WorldArchive.Domain.Models.Base;

namespace WorldArchive.Domain.Models
{
    public class Country : EntityBase
    {
        public string Name { get; set; }
        public string CallingCode { get; set; }
        public string capital { get; set; }
        public string? GoogleMap { get; set; }
        public string? OpenStreetMap { get; set; }

        public int RegionId { get; set; }
        public Region Region { get; set; }
        public int Area { get; set; }
        public string Flag { get; set; }
        public string CoatOfArms { get; set; }
        public int Population { get; set; }
        public string StartOfWeek { get; set; }
        public List<string> TimeZones { get; set; }


        public List<CountryLanguage> Languages { get; set; }
        public List<City> Cities { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
