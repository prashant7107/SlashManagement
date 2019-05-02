namespace Slash.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableStudentEntryandPaymentLinked : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Payment", "StudentId");
            AddForeignKey("dbo.Payment", "StudentId", "dbo.Student_Entry", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payment", "StudentId", "dbo.Student_Entry");
            DropIndex("dbo.Payment", new[] { "StudentId" });
        }
    }
}
