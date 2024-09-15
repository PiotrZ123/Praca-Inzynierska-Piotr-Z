namespace WarstwaDostępuDoDanych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Poprawki : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Jednostki", "MiastoModel_Id", "dbo.Miasta");
            DropForeignKey("dbo.Jednostki", "MiastoModel_Id1", "dbo.Miasta");
            DropIndex("dbo.Jednostki", new[] { "MiastoModel_Id" });
            DropIndex("dbo.Jednostki", new[] { "MiastoModel_Id1" });
            AddColumn("dbo.Mapy", "IndexNowegoBohatera", c => c.Int(nullable: false));
            AddColumn("dbo.Mapy", "Dzien", c => c.Int(nullable: false));
            AddColumn("dbo.Bohaterowie", "Wlasciciel_Id", c => c.Int());
            AddColumn("dbo.Miasta", "BohaterWMiescie_Id", c => c.Int());
            AddColumn("dbo.Miasta", "Wlasciciel_Id", c => c.Int());
            CreateIndex("dbo.Bohaterowie", "Wlasciciel_Id");
            CreateIndex("dbo.Miasta", "BohaterWMiescie_Id");
            CreateIndex("dbo.Miasta", "Wlasciciel_Id");
            AddForeignKey("dbo.Bohaterowie", "Wlasciciel_Id", "dbo.Gracze", "Id");
            AddForeignKey("dbo.Miasta", "BohaterWMiescie_Id", "dbo.Bohaterowie", "Id");
            AddForeignKey("dbo.Miasta", "Wlasciciel_Id", "dbo.Gracze", "Id");
            DropColumn("dbo.Bohaterowie", "IdWlasciciel");
            DropColumn("dbo.Miasta", "IdWlasciciel");
            DropColumn("dbo.Miasta", "Bohater_w_miescie_id");
            DropColumn("dbo.Miasta", "Bohater_poza_miastem_id");
            DropTable("dbo.Jednostki");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Jednostki",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdWlasciciel = c.Int(nullable: false),
                        Przyrost = c.Int(nullable: false),
                        Numer = c.Int(nullable: false),
                        Ilosc = c.Int(nullable: false),
                        Koszt = c.Int(nullable: false),
                        ZycieAktualne = c.Int(nullable: false),
                        Zycie_max = c.Int(nullable: false),
                        Atak = c.Int(nullable: false),
                        Obrona = c.Int(nullable: false),
                        Obrazenia_min = c.Int(nullable: false),
                        Obrazenia_max = c.Int(nullable: false),
                        Kontratak = c.Int(nullable: false),
                        Ilosc_strzal = c.Int(nullable: false),
                        Szybkosc = c.Int(nullable: false),
                        Strzela = c.Boolean(nullable: false),
                        MiastoModel_Id = c.Int(),
                        MiastoModel_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Miasta", "Bohater_poza_miastem_id", c => c.Int(nullable: false));
            AddColumn("dbo.Miasta", "Bohater_w_miescie_id", c => c.Int(nullable: false));
            AddColumn("dbo.Miasta", "IdWlasciciel", c => c.Int(nullable: false));
            AddColumn("dbo.Bohaterowie", "IdWlasciciel", c => c.Int(nullable: false));
            DropForeignKey("dbo.Miasta", "Wlasciciel_Id", "dbo.Gracze");
            DropForeignKey("dbo.Miasta", "BohaterWMiescie_Id", "dbo.Bohaterowie");
            DropForeignKey("dbo.Bohaterowie", "Wlasciciel_Id", "dbo.Gracze");
            DropIndex("dbo.Miasta", new[] { "Wlasciciel_Id" });
            DropIndex("dbo.Miasta", new[] { "BohaterWMiescie_Id" });
            DropIndex("dbo.Bohaterowie", new[] { "Wlasciciel_Id" });
            DropColumn("dbo.Miasta", "Wlasciciel_Id");
            DropColumn("dbo.Miasta", "BohaterWMiescie_Id");
            DropColumn("dbo.Bohaterowie", "Wlasciciel_Id");
            DropColumn("dbo.Mapy", "Dzien");
            DropColumn("dbo.Mapy", "IndexNowegoBohatera");
            CreateIndex("dbo.Jednostki", "MiastoModel_Id1");
            CreateIndex("dbo.Jednostki", "MiastoModel_Id");
            AddForeignKey("dbo.Jednostki", "MiastoModel_Id1", "dbo.Miasta", "Id");
            AddForeignKey("dbo.Jednostki", "MiastoModel_Id", "dbo.Miasta", "Id");
        }
    }
}
