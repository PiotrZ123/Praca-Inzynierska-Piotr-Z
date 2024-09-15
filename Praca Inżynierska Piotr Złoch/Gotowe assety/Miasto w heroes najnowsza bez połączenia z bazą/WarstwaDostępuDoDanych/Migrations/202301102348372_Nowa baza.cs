namespace WarstwaDostępuDoDanych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nowabaza : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mapy",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataICzasUtorzenia = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bohaterowie",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdWlasciciel = c.Int(nullable: false),
                        Nieosobowy = c.Boolean(nullable: false),
                        Imie = c.String(),
                        Atak = c.Int(nullable: false),
                        Obrona = c.Int(nullable: false),
                        Maksymalna_ilosc_ruchu = c.Int(nullable: false),
                        Ilosc_ruchu = c.Int(nullable: false),
                        Szerokosc = c.Int(nullable: false),
                        Wysokosc = c.Int(nullable: false),
                        Polozenie_Id = c.Int(),
                        MapaModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Punkty", t => t.Polozenie_Id)
                .ForeignKey("dbo.Mapy", t => t.MapaModel_Id)
                .Index(t => t.Polozenie_Id)
                .Index(t => t.MapaModel_Id);
            
            CreateTable(
                "dbo.Punkty",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        X = c.Int(nullable: false),
                        Y = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Gracze",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Imie = c.String(),
                        Kolor = c.String(),
                        Zloto = c.Int(nullable: false),
                        MapaModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Mapy", t => t.MapaModel_Id)
                .Index(t => t.MapaModel_Id);
            
            CreateTable(
                "dbo.Miasta",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdWlasciciel = c.Int(nullable: false),
                        Bohater_w_miescie_id = c.Int(nullable: false),
                        Bohater_poza_miastem_id = c.Int(nullable: false),
                        Maksymalna_ilosc_budynkow_do_zbudowania_na_ture = c.Int(nullable: false),
                        Czy_mozna_budowac = c.Int(nullable: false),
                        Przychod = c.Int(nullable: false),
                        Szerokosc = c.Int(nullable: false),
                        Wysokosc = c.Int(nullable: false),
                        Polozenie_Id = c.Int(),
                        MapaModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Punkty", t => t.Polozenie_Id)
                .ForeignKey("dbo.Mapy", t => t.MapaModel_Id)
                .Index(t => t.Polozenie_Id)
                .Index(t => t.MapaModel_Id);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Miasta", t => t.MiastoModel_Id)
                .ForeignKey("dbo.Miasta", t => t.MiastoModel_Id1)
                .Index(t => t.MiastoModel_Id)
                .Index(t => t.MiastoModel_Id1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Miasta", "MapaModel_Id", "dbo.Mapy");
            DropForeignKey("dbo.Miasta", "Polozenie_Id", "dbo.Punkty");
            DropForeignKey("dbo.Jednostki", "MiastoModel_Id1", "dbo.Miasta");
            DropForeignKey("dbo.Jednostki", "MiastoModel_Id", "dbo.Miasta");
            DropForeignKey("dbo.Gracze", "MapaModel_Id", "dbo.Mapy");
            DropForeignKey("dbo.Bohaterowie", "MapaModel_Id", "dbo.Mapy");
            DropForeignKey("dbo.Bohaterowie", "Polozenie_Id", "dbo.Punkty");
            DropIndex("dbo.Jednostki", new[] { "MiastoModel_Id1" });
            DropIndex("dbo.Jednostki", new[] { "MiastoModel_Id" });
            DropIndex("dbo.Miasta", new[] { "MapaModel_Id" });
            DropIndex("dbo.Miasta", new[] { "Polozenie_Id" });
            DropIndex("dbo.Gracze", new[] { "MapaModel_Id" });
            DropIndex("dbo.Bohaterowie", new[] { "MapaModel_Id" });
            DropIndex("dbo.Bohaterowie", new[] { "Polozenie_Id" });
            DropTable("dbo.Jednostki");
            DropTable("dbo.Miasta");
            DropTable("dbo.Gracze");
            DropTable("dbo.Punkty");
            DropTable("dbo.Bohaterowie");
            DropTable("dbo.Mapy");
        }
    }
}
