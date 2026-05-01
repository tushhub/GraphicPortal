using System;
using System.Collections.Generic;

namespace PortfolioApp.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Problem { get; set; } = string.Empty;
        public string Approach { get; set; } = string.Empty;
        public string Solution { get; set; } = string.Empty;
        public string CoverImageUrl { get; set; } = string.Empty;
        public List<string> Images { get; set; } = new();
        public DateTime CreatedDate { get; set; }
        public bool IsFeatured { get; set; }
        public List<string> Tags { get; set; } = new();
        public string ClientName { get; set; } = string.Empty;
        public string ProjectYear { get; set; } = string.Empty;
    }
}
