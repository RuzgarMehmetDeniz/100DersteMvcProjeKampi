namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migwritertitle_add : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "Writertitle", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "Writertitle");
        }
    }
}
