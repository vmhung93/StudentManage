namespace StudentManage.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddStudentInClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentInClasses",
                c => new
                {
                    Id = c.Guid(nullable: false, identity: true),
                    StudentId = c.Guid(nullable: false),
                    OrderNumber = c.Int(nullable: false),
                    ClassId = c.Guid(nullable: false),
                    PositionId = c.Guid(nullable: false),
                    CreatedDate = c.DateTime(nullable: false),
                    ModifiedDate = c.DateTime(nullable: false),
                    CreatedBy = c.Guid(),
                    ModifiedBy = c.Guid(),
                    Status = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.ClassId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.CreatedBy)
                .ForeignKey("dbo.Users", t => t.ModifiedBy)
                .ForeignKey("dbo.PositionInClasses", t => t.PositionId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.StudentId, cascadeDelete: false)
                .Index(t => t.StudentId)
                .Index(t => t.ClassId)
                .Index(t => t.PositionId)
                .Index(t => t.CreatedBy)
                .Index(t => t.ModifiedBy);
        }

        public override void Down()
        {
            DropForeignKey("dbo.StudentInClasses", "StudentId", "dbo.Users");
            DropForeignKey("dbo.StudentInClasses", "PositionId", "dbo.PositionInClasses");
            DropForeignKey("dbo.StudentInClasses", "ModifiedBy", "dbo.Users");
            DropForeignKey("dbo.StudentInClasses", "CreatedBy", "dbo.Users");
            DropForeignKey("dbo.StudentInClasses", "ClassId", "dbo.Classes");
            DropIndex("dbo.StudentInClasses", new[] { "ModifiedBy" });
            DropIndex("dbo.StudentInClasses", new[] { "CreatedBy" });
            DropIndex("dbo.StudentInClasses", new[] { "PositionId" });
            DropIndex("dbo.StudentInClasses", new[] { "ClassId" });
            DropIndex("dbo.StudentInClasses", new[] { "StudentId" });
            DropTable("dbo.StudentInClasses");
        }
    }
}