namespace WarstwaDostępuDoDanych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zamianazlistnatablice : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bohaterowie", "Wlasciciel_Id", "dbo.Gracze");
            DropForeignKey("dbo.Miasta", "Wlasciciel_Id", "dbo.Gracze");
            DropIndex("dbo.Bohaterowie", new[] { "Wlasciciel_Id" });
            DropIndex("dbo.Miasta", new[] { "Wlasciciel_Id" });
            CreateTable(
                "dbo.BudynekModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PolozenieWTablicy = c.Int(nullable: false),
                        Poziom = c.Int(nullable: false),
                        Cena = c.Int(nullable: false),
                        MiastoModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Miasta", t => t.MiastoModel_Id)
                .Index(t => t.MiastoModel_Id);
            
            AddColumn("dbo.Bohaterowie", "WlascicielGuid", c => c.String());
            AddColumn("dbo.Jednostki", "PolozenieWTablicy", c => c.Int(nullable: false));
            AddColumn("dbo.Jednostki", "WlascicielGuid", c => c.String());
            AddColumn("dbo.Gracze", "Guid", c => c.String());
            AddColumn("dbo.Miasta", "WlascicielGuid", c => c.String());
            DropColumn("dbo.Bohaterowie", "Wlasciciel_Id");
            DropColumn("dbo.Miasta", "Wlasciciel_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Miasta", "Wlasciciel_Id", c => c.Int());
            AddColumn("dbo.Bohaterowie", "Wlasciciel_Id", c => c.Int());
            DropForeignKey("dbo.BudynekModels", "MiastoModel_Id", "dbo.Miasta");
            DropIndex("dbo.BudynekModels", new[] { "MiastoModel_Id" });
            DropColumn("dbo.Miasta", "WlascicielGuid");
            DropColumn("dbo.Gracze", "Guid");
            DropColumn("dbo.Jednostki", "WlascicielGuid");
            DropColumn("dbo.Jednostki", "PolozenieWTablicy");
            DropColumn("dbo.Bohaterowie", "WlascicielGuid");
            DropTable("dbo.BudynekModels");
            CreateIndex("dbo.Miasta", "Wlasciciel_Id");
            CreateIndex("dbo.Bohaterowie", "Wlasciciel_Id");
            AddForeignKey("dbo.Miasta", "Wlasciciel_Id", "dbo.Gracze", "Id");
            AddForeignKey("dbo.Bohaterowie", "Wlasciciel_Id", "dbo.Gracze", "Id");
        }
    }
}
