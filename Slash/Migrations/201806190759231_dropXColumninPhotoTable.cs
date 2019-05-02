namespace Slash.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropXColumninPhotoTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Student_Photo", "x");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Student_Photo", "x", c => c.Int());
        }
    }
}
