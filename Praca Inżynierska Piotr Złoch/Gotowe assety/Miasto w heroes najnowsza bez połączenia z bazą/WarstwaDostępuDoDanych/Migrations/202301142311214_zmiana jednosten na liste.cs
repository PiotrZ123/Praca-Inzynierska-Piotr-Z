namespace WarstwaDostępuDoDanych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zmianajednostennaliste : DbMigration
    {
        public override void Up()
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
                        BohaterModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bohaterowie", t => t.BohaterModel_Id)
                .Index(t => t.BohaterModel_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jednostki", "BohaterModel_Id", "dbo.Bohaterowie");
            DropIndex("dbo.Jednostki", new[] { "BohaterModel_Id" });
            DropTable("dbo.Jednostki");
        }
    }
}
