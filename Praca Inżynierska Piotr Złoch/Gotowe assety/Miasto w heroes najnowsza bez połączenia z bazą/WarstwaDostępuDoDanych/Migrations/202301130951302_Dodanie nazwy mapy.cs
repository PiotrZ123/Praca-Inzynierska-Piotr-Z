namespace WarstwaDostępuDoDanych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dodanienazwymapy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mapy", "Nazwa", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mapy", "Nazwa");
        }
    }
}
