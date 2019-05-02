namespace Slash.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableStudentEntryandPaymentLinkedDroppedidea : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Payment", "StudentId", "dbo.Student_Entry");
            DropIndex("dbo.Payment", new[] { "StudentId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Payment", "StudentId");
            AddForeignKey("dbo.Payment", "StudentId", "dbo.Student_Entry", "Id", cascadeDelete: true);
        }
    }
}
