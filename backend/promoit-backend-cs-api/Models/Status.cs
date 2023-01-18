﻿
namespace promoit_backend_cs_api.Models
{
    public partial class Status
    {
        public Status()
        {
            Bcrs = new HashSet<Bcr>();
            Campaigns = new HashSet<Campaign>();
            NonProfitRepresentatives = new HashSet<NonProfitRepresentative>();
            Products = new HashSet<Product>();
            Roles = new HashSet<Role>();
            Sas = new HashSet<Sa>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public int Status1 { get; set; }

        public virtual ICollection<Bcr> Bcrs { get; set; }
        public virtual ICollection<Campaign> Campaigns { get; set; }
        public virtual ICollection<NonProfitRepresentative> NonProfitRepresentatives { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<Sa> Sas { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
