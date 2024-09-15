using ModelDanych;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;

namespace WarstwaDostępuDoDanych
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("Heroes")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<MiastoModel>().HasRequired(m => m.Polozenie).WithRequiredDependent(m => m).WillCascadeOnDelete(true); //Line1

           // modelBuilder.Entity<childtable>().HasRequired(m => m.ParentTable).WithMany(m => m.ChildTable).HasForeignKey(m => m.EmailCampaignId).WillCascadeOnDelete(true);//Line2

            //modelBuilder.Entity<BohaterModel>().HasMany(x => x).WithRequired(x => x.).WillCascadeOnDelete();
                


            //base.OnModelCreating(modelBuilder);
        }

       
        public DbSet<MapaModel> Mapy { get; set; }

        public DbSet<BohaterModel> Bohaterowie { get; set; }

        public DbSet<JednostkaModel> Jednostki { get; set; }
        public DbSet<BudynekModel> Budynki { get; set; }
        

        public DbSet<MiastoModel> Miasta { get; set; }

        public DbSet<GraczModel> Gracze { get; set; }

    }
}

