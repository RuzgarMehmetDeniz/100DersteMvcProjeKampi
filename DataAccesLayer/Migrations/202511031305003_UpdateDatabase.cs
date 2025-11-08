namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterName", c => c.String(maxLength: 50));
            DropColumn("dbo.Writers", "WriteName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Writers", "WriteName", c => c.String(maxLength: 50));
            DropColumn("dbo.Writers", "WriterName");
        }
    }
}
