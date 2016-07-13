using Microsoft.AspNet.Identity.EntityFramework;

namespace Domain.Entities.Core
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

    }
    //public class EntitiesContext : DbContext {

    //    public EntitiesContext() : base("PingYourPackage") { }

    //    public IDbSet<ShipmentType> ShipmentTypes { get; set; }
    //    public IDbSet<Affiliate> Affiliates { get; set; }
    //    public IDbSet<Shipment> Shipments { get; set; }
    //    public IDbSet<ShipmentState> ShipmentStates { get; set; }

    //    public IDbSet<User> Users { get; set; }
    //    public IDbSet<Role> Roles { get; set; }
    //    public IDbSet<UserInRole> UserInRoles { get; set; }
    //}
}