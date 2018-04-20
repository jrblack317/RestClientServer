using System;

namespace SeverApplication.Models
{
    public class SearchResult
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public decimal Margin { get; set; }

        public DateTime ActiveDate { get; set; }

        public bool IsActive { get; set; }

        public int? YearsActive { get; set; }

        public bool? Export { get; set; }

        public ProductType ProductType { get; set; }

        public ExportType? ExportType { get; set; }
    }

    public enum ProductType
    {
        Conventional = 1,
        FHA = 2,
        USDA = 3
    }

    public enum ExportType
    {
        Fannie = 1,
        Freddie = 2
    }
}