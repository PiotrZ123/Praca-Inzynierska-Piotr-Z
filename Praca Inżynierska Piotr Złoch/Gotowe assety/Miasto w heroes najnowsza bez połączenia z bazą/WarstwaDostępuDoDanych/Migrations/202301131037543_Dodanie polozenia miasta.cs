namespace WarstwaDostępuDoDanych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dodaniepolozeniamiasta : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mapy", "Polozenie_Id", c => c.Int());
            CreateIndex("dbo.Mapy", "Polozenie_Id");
            AddForeignKey("dbo.Mapy", "Polozenie_Id", "dbo.Punkty", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mapy", "Polozenie_Id", "dbo.Punkty");
            DropIndex("dbo.Mapy", new[] { "Polozenie_Id" });
            DropColumn("dbo.Mapy", "Polozenie_Id");
        }
    }
}
