using System.Data.Entity;
using Interface;
using PhoneDictionary;

namespace DbLib
{
    public class PhoneContext : DbContext
    {
        public PhoneContext() : base(
            "Data Source=DESKTOP-6BQAJ6M,33678;Initial Catalog=Phones;User=lera;Password=Vv1542139;TrustServerCertificate=True;Integrated Security=False;")
        {
            Database.CreateIfNotExists();
        }

        public DbSet<Phone> Phones { get; set; }
    }
}
