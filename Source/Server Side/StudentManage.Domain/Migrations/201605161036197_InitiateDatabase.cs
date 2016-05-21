namespace StudentManage.Domain.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitiateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                {
                    Id = c.Guid(nullable: false, identity: true),
                    Code = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    GradeId = c.Guid(nullable: false),
                    HomeroomTeacherId = c.Guid(nullable: false),
                    CreatedDate = c.DateTime(nullable: false),
                    ModifiedDate = c.DateTime(nullable: false),
                    CreatedBy = c.Guid(),
                    ModifiedBy = c.Guid(),
                    Status = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CreatedBy)
                .ForeignKey("dbo.Grades", t => t.GradeId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.HomeroomTeacherId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.ModifiedBy)
                .Index(t => t.GradeId)
                .Index(t => t.HomeroomTeacherId)
                .Index(t => t.CreatedBy)
                .Index(t => t.ModifiedBy);

            CreateTable(
                "dbo.Users",
                c => new
                {
                    Id = c.Guid(nullable: false, identity: true),
                    UserCode = c.Int(nullable: false, identity: true),
                    UserName = c.String(),
                    Password = c.String(),
                    AccessToken = c.Guid(nullable: false),
                    RoleId = c.Guid(nullable: false),
                    UserInfoId = c.Guid(nullable: false),
                    CreatedDate = c.DateTime(nullable: false),
                    ModifiedDate = c.DateTime(nullable: false),
                    CreatedBy = c.Guid(nullable: true),
                    ModifiedBy = c.Guid(nullable: true),
                    Status = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CreatedBy)
                .ForeignKey("dbo.Users", t => t.ModifiedBy)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: false)
                .ForeignKey("dbo.UserInfoes", t => t.UserInfoId, cascadeDelete: false)
                .Index(t => t.RoleId)
                .Index(t => t.UserInfoId)
                .Index(t => t.CreatedBy)
                .Index(t => t.ModifiedBy);

            CreateTable(
                "dbo.Roles",
                c => new
                {
                    Id = c.Guid(nullable: false, identity: true),
                    Name = c.String(),
                    Level = c.Int(nullable: false),
                    CreatedDate = c.DateTime(nullable: false),
                    ModifiedDate = c.DateTime(nullable: false),
                    CreatedBy = c.Guid(),
                    ModifiedBy = c.Guid(),
                    Status = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CreatedBy)
                .ForeignKey("dbo.Users", t => t.ModifiedBy)
                .Index(t => t.CreatedBy)
                .Index(t => t.ModifiedBy);

            CreateTable(
                "dbo.UserInfoes",
                c => new
                {
                    Id = c.Guid(nullable: false, identity: true),
                    Name = c.String(),
                    DateOfBirth = c.DateTime(nullable: false),
                    Gender = c.Int(nullable: false),
                    Email = c.String(),
                    Adress = c.String(),
                    Status = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Grades",
                c => new
                {
                    Id = c.Guid(nullable: false, identity: true),
                    Code = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    CreatedDate = c.DateTime(nullable: false),
                    ModifiedDate = c.DateTime(nullable: false),
                    CreatedBy = c.Guid(),
                    ModifiedBy = c.Guid(),
                    Status = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CreatedBy)
                .ForeignKey("dbo.Users", t => t.ModifiedBy)
                .Index(t => t.CreatedBy)
                .Index(t => t.ModifiedBy);

            CreateTable(
                "dbo.Coefficients",
                c => new
                {
                    Id = c.Guid(nullable: false, identity: true),
                    Code = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    CreatedDate = c.DateTime(nullable: false),
                    ModifiedDate = c.DateTime(nullable: false),
                    CreatedBy = c.Guid(),
                    ModifiedBy = c.Guid(),
                    Status = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CreatedBy)
                .ForeignKey("dbo.Users", t => t.ModifiedBy)
                .Index(t => t.CreatedBy)
                .Index(t => t.ModifiedBy);

            CreateTable(
                "dbo.Courses",
                c => new
                {
                    Id = c.Guid(nullable: false, identity: true),
                    Code = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    DeanId = c.Guid(nullable: false),
                    SemesterId = c.Guid(nullable: false),
                    CreatedDate = c.DateTime(nullable: false),
                    ModifiedDate = c.DateTime(nullable: false),
                    CreatedBy = c.Guid(),
                    ModifiedBy = c.Guid(),
                    Status = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CreatedBy)
                .ForeignKey("dbo.Users", t => t.DeanId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.ModifiedBy)
                .ForeignKey("dbo.Semesters", t => t.SemesterId, cascadeDelete: false)
                .Index(t => t.DeanId)
                .Index(t => t.SemesterId)
                .Index(t => t.CreatedBy)
                .Index(t => t.ModifiedBy);

            CreateTable(
                "dbo.Semesters",
                c => new
                {
                    Id = c.Guid(nullable: false, identity: true),
                    Code = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    CreatedDate = c.DateTime(nullable: false),
                    ModifiedDate = c.DateTime(nullable: false),
                    CreatedBy = c.Guid(),
                    ModifiedBy = c.Guid(),
                    Status = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CreatedBy)
                .ForeignKey("dbo.Users", t => t.ModifiedBy)
                .Index(t => t.CreatedBy)
                .Index(t => t.ModifiedBy);

            CreateTable(
                "dbo.PositionInClasses",
                c => new
                {
                    Id = c.Guid(nullable: false, identity: true),
                    Name = c.String(),
                    CreatedDate = c.DateTime(nullable: false),
                    ModifiedDate = c.DateTime(nullable: false),
                    CreatedBy = c.Guid(),
                    ModifiedBy = c.Guid(),
                    Status = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CreatedBy)
                .ForeignKey("dbo.Users", t => t.ModifiedBy)
                .Index(t => t.CreatedBy)
                .Index(t => t.ModifiedBy);

            CreateTable(
                "dbo.Scores",
                c => new
                {
                    Id = c.Guid(nullable: false, identity: true),
                    StudentId = c.Guid(nullable: false),
                    CourseId = c.Guid(nullable: false),
                    ScoreTypeId = c.Guid(nullable: false),
                    Score = c.Decimal(nullable: false, precision: 18, scale: 2),
                    CreatedDate = c.DateTime(nullable: false),
                    ModifiedDate = c.DateTime(nullable: false),
                    CreatedBy = c.Guid(),
                    ModifiedBy = c.Guid(),
                    Status = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.CreatedBy)
                .ForeignKey("dbo.Users", t => t.ModifiedBy)
                .ForeignKey("dbo.ScoreTypes", t => t.ScoreTypeId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.StudentId, cascadeDelete: false)
                .Index(t => t.StudentId)
                .Index(t => t.CourseId)
                .Index(t => t.ScoreTypeId)
                .Index(t => t.CreatedBy)
                .Index(t => t.ModifiedBy);

            CreateTable(
                "dbo.ScoreTypes",
                c => new
                {
                    Id = c.Guid(nullable: false, identity: true),
                    Name = c.String(),
                    CoefficientId = c.Guid(nullable: false),
                    CreatedDate = c.DateTime(nullable: false),
                    ModifiedDate = c.DateTime(nullable: false),
                    CreatedBy = c.Guid(),
                    ModifiedBy = c.Guid(),
                    Status = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Coefficients", t => t.CoefficientId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.CreatedBy)
                .ForeignKey("dbo.Users", t => t.ModifiedBy)
                .Index(t => t.CoefficientId)
                .Index(t => t.CreatedBy)
                .Index(t => t.ModifiedBy);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Scores", "StudentId", "dbo.Users");
            DropForeignKey("dbo.Scores", "ScoreTypeId", "dbo.ScoreTypes");
            DropForeignKey("dbo.ScoreTypes", "ModifiedBy", "dbo.Users");
            DropForeignKey("dbo.ScoreTypes", "CreatedBy", "dbo.Users");
            DropForeignKey("dbo.ScoreTypes", "CoefficientId", "dbo.Coefficients");
            DropForeignKey("dbo.Scores", "ModifiedBy", "dbo.Users");
            DropForeignKey("dbo.Scores", "CreatedBy", "dbo.Users");
            DropForeignKey("dbo.Scores", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.PositionInClasses", "ModifiedBy", "dbo.Users");
            DropForeignKey("dbo.PositionInClasses", "CreatedBy", "dbo.Users");
            DropForeignKey("dbo.Courses", "SemesterId", "dbo.Semesters");
            DropForeignKey("dbo.Semesters", "ModifiedBy", "dbo.Users");
            DropForeignKey("dbo.Semesters", "CreatedBy", "dbo.Users");
            DropForeignKey("dbo.Courses", "ModifiedBy", "dbo.Users");
            DropForeignKey("dbo.Courses", "DeanId", "dbo.Users");
            DropForeignKey("dbo.Courses", "CreatedBy", "dbo.Users");
            DropForeignKey("dbo.Coefficients", "ModifiedBy", "dbo.Users");
            DropForeignKey("dbo.Coefficients", "CreatedBy", "dbo.Users");
            DropForeignKey("dbo.Classes", "ModifiedBy", "dbo.Users");
            DropForeignKey("dbo.Classes", "HomeroomTeacherId", "dbo.Users");
            DropForeignKey("dbo.Classes", "GradeId", "dbo.Grades");
            DropForeignKey("dbo.Grades", "ModifiedBy", "dbo.Users");
            DropForeignKey("dbo.Grades", "CreatedBy", "dbo.Users");
            DropForeignKey("dbo.Classes", "CreatedBy", "dbo.Users");
            DropForeignKey("dbo.Users", "UserInfoId", "dbo.UserInfoes");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Roles", "ModifiedBy", "dbo.Users");
            DropForeignKey("dbo.Roles", "CreatedBy", "dbo.Users");
            DropForeignKey("dbo.Users", "ModifiedBy", "dbo.Users");
            DropForeignKey("dbo.Users", "CreatedBy", "dbo.Users");
            DropIndex("dbo.ScoreTypes", new[] { "ModifiedBy" });
            DropIndex("dbo.ScoreTypes", new[] { "CreatedBy" });
            DropIndex("dbo.ScoreTypes", new[] { "CoefficientId" });
            DropIndex("dbo.Scores", new[] { "ModifiedBy" });
            DropIndex("dbo.Scores", new[] { "CreatedBy" });
            DropIndex("dbo.Scores", new[] { "ScoreTypeId" });
            DropIndex("dbo.Scores", new[] { "CourseId" });
            DropIndex("dbo.Scores", new[] { "StudentId" });
            DropIndex("dbo.PositionInClasses", new[] { "ModifiedBy" });
            DropIndex("dbo.PositionInClasses", new[] { "CreatedBy" });
            DropIndex("dbo.Semesters", new[] { "ModifiedBy" });
            DropIndex("dbo.Semesters", new[] { "CreatedBy" });
            DropIndex("dbo.Courses", new[] { "ModifiedBy" });
            DropIndex("dbo.Courses", new[] { "CreatedBy" });
            DropIndex("dbo.Courses", new[] { "SemesterId" });
            DropIndex("dbo.Courses", new[] { "DeanId" });
            DropIndex("dbo.Coefficients", new[] { "ModifiedBy" });
            DropIndex("dbo.Coefficients", new[] { "CreatedBy" });
            DropIndex("dbo.Grades", new[] { "ModifiedBy" });
            DropIndex("dbo.Grades", new[] { "CreatedBy" });
            DropIndex("dbo.Roles", new[] { "ModifiedBy" });
            DropIndex("dbo.Roles", new[] { "CreatedBy" });
            DropIndex("dbo.Users", new[] { "ModifiedBy" });
            DropIndex("dbo.Users", new[] { "CreatedBy" });
            DropIndex("dbo.Users", new[] { "UserInfoId" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Classes", new[] { "ModifiedBy" });
            DropIndex("dbo.Classes", new[] { "CreatedBy" });
            DropIndex("dbo.Classes", new[] { "HomeroomTeacherId" });
            DropIndex("dbo.Classes", new[] { "GradeId" });
            DropTable("dbo.ScoreTypes");
            DropTable("dbo.Scores");
            DropTable("dbo.PositionInClasses");
            DropTable("dbo.Semesters");
            DropTable("dbo.Courses");
            DropTable("dbo.Coefficients");
            DropTable("dbo.Grades");
            DropTable("dbo.UserInfoes");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Classes");
        }
    }
}