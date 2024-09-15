namespace WarstwaDostępuDoDanych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dodanienazwyusuniecie : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Mapy", "Nazwa");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Mapy", "Nazwa", c => c.String());
        }
    }
}
