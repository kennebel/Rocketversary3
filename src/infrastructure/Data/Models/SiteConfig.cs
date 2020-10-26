using core.Data.Interfaces;
using MongoDB.Entities;

namespace src.infrastructure.Data.Models
{
    public class SiteConfig : Entity, ISiteConfig
    {
        public string ContactDescription { get; set; }
        public string ContactEmail { get; set; }
    }
}