namespace WarstwaDostępuDoDanych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zmiananazwyguida : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Gracze", "NumerGuid", c => c.String());
            DropColumn("dbo.Gracze", "Guid");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Gracze", "Guid", c => c.String());
            DropColumn("dbo.Gracze", "NumerGuid");
        }
    }
}
