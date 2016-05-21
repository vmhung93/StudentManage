namespace StudentManage.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase_2205 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Classes", "GradeId", "dbo.Grades");
            DropForeignKey("dbo.Courses", "DeanId", "dbo.Users");
            DropForeignKey("dbo.StudentInClasses", "PositionId", "dbo.PositionInClasses");
            DropIndex("dbo.Classes", new[] { "GradeId" });
            DropIndex("dbo.Courses", new[] { "DeanId" });
            DropIndex("dbo.StudentInClasses", new[] { "PositionId" });
            AlterColumn("dbo.Classes", "GradeId", c => c.Guid());
            AlterColumn("dbo.Courses", "DeanId", c => c.Guid());
            AlterColumn("dbo.StudentInClasses", "PositionId", c => c.Guid());
            CreateIndex("dbo.Classes", "GradeId");
            CreateIndex("dbo.Courses", "DeanId");
            CreateIndex("dbo.StudentInClasses", "PositionId");
            AddForeignKey("dbo.Classes", "GradeId", "dbo.Grades", "Id");
            AddForeignKey("dbo.Courses", "DeanId", "dbo.Users", "Id");
            AddForeignKey("dbo.StudentInClasses", "PositionId", "dbo.PositionInClasses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentInClasses", "PositionId", "dbo.PositionInClasses");
            DropForeignKey("dbo.Courses", "DeanId", "dbo.Users");
            DropForeignKey("dbo.Classes", "GradeId", "dbo.Grades");
            DropIndex("dbo.StudentInClasses", new[] { "PositionId" });
            DropIndex("dbo.Courses", new[] { "DeanId" });
            DropIndex("dbo.Classes", new[] { "GradeId" });
            AlterColumn("dbo.StudentInClasses", "PositionId", c => c.Guid(nullable: false));
            AlterColumn("dbo.Courses", "DeanId", c => c.Guid(nullable: false));
            AlterColumn("dbo.Classes", "GradeId", c => c.Guid(nullable: false));
            CreateIndex("dbo.StudentInClasses", "PositionId");
            CreateIndex("dbo.Courses", "DeanId");
            CreateIndex("dbo.Classes", "GradeId");
            AddForeignKey("dbo.StudentInClasses", "PositionId", "dbo.PositionInClasses", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Courses", "DeanId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Classes", "GradeId", "dbo.Grades", "Id", cascadeDelete: true);
        }
    }
}
