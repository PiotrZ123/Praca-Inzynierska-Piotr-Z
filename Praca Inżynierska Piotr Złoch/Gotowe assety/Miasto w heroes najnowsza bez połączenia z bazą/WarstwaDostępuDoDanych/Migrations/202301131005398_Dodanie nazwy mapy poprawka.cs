namespace WarstwaDostępuDoDanych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dodanienazwymapypoprawka : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Mapy", "Nazwa", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Mapy", "Nazwa", c => c.DateTime(nullable: false));
        }
    }
}
