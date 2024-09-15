namespace WarstwaDostępuDoDanych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zmiananazwytabeli : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.BudynekModels", newName: "Budynki");
            DropForeignKey("dbo.Bohaterowie", "Polozenie_Id", "dbo.Punkty");
            DropForeignKey("dbo.Miasta", "Polozenie_Id", "dbo.Punkty");
            DropForeignKey("dbo.Mapy", "Polozenie_Id", "dbo.Punkty");
            DropIndex("dbo.Bohaterowie", new[] { "Polozenie_Id" });
            DropIndex("dbo.Mapy", new[] { "Polozenie_Id" });
            DropIndex("dbo.Miasta", new[] { "Polozenie_Id" });
            AddColumn("dbo.Bohaterowie", "PolozenieX", c => c.Int(nullable: false));
            AddColumn("dbo.Bohaterowie", "PolozenieY", c => c.Int(nullable: false));
            AddColumn("dbo.Mapy", "PolozenieX", c => c.Int(nullable: false));
            AddColumn("dbo.Mapy", "PolozenieY", c => c.Int(nullable: false));
            AddColumn("dbo.Miasta", "PolozenieX", c => c.Int(nullable: false));
            AddColumn("dbo.Miasta", "PolozenieY", c => c.Int(nullable: false));
            DropColumn("dbo.Bohaterowie", "Polozenie_Id");
            DropColumn("dbo.Mapy", "Polozenie_Id");
            DropColumn("dbo.Miasta", "Polozenie_Id");
            DropTable("dbo.Punkty");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Punkty",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        X = c.Int(nullable: false),
                        Y = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Miasta", "Polozenie_Id", c => c.Int());
            AddColumn("dbo.Mapy", "Polozenie_Id", c => c.Int());
            AddColumn("dbo.Bohaterowie", "Polozenie_Id", c => c.Int());
            DropColumn("dbo.Miasta", "PolozenieY");
            DropColumn("dbo.Miasta", "PolozenieX");
            DropColumn("dbo.Mapy", "PolozenieY");
            DropColumn("dbo.Mapy", "PolozenieX");
            DropColumn("dbo.Bohaterowie", "PolozenieY");
            DropColumn("dbo.Bohaterowie", "PolozenieX");
            CreateIndex("dbo.Miasta", "Polozenie_Id");
            CreateIndex("dbo.Mapy", "Polozenie_Id");
            CreateIndex("dbo.Bohaterowie", "Polozenie_Id");
            AddForeignKey("dbo.Mapy", "Polozenie_Id", "dbo.Punkty", "Id");
            AddForeignKey("dbo.Miasta", "Polozenie_Id", "dbo.Punkty", "Id");
            AddForeignKey("dbo.Bohaterowie", "Polozenie_Id", "dbo.Punkty", "Id");
            RenameTable(name: "dbo.Budynki", newName: "BudynekModels");
        }
    }
}
