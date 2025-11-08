namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_addimage_file : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ImageFiles",
                c => new
                    {
                        ImageID = c.Int(nullable: false, identity: true),
                        Imagename = c.String(maxLength: 100),
                        ImagePath = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ImageID);
            
            DropTable("dbo.Messages");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessageID = c.Int(nullable: false, identity: true),
                        SenderMail = c.String(maxLength: 50),
                        ReceiverMail = c.String(maxLength: 50),
                        Subject = c.String(maxLength: 100),
                        MessageContent = c.String(),
                        MessageDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MessageID);
            
            DropTable("dbo.ImageFiles");
        }
    }
}
