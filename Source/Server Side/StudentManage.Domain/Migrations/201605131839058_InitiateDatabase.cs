namespace StudentManage.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitiateDatabase : DbMigration
    {
        public override void Up()
        {
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
                    CreatedBy = c.Guid(),
                    ModifiedBy = c.Guid(),
                    Status = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CreatedBy)
                .ForeignKey("dbo.Users", t => t.ModifiedBy)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.UserInfoes", t => t.UserInfoId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.UserInfoId)
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
        }

        public override void Down()
        {
            DropForeignKey("dbo.Roles", "ModifiedBy", "dbo.Users");
            DropForeignKey("dbo.Roles", "CreatedBy", "dbo.Users");
            DropForeignKey("dbo.Users", "UserInfoId", "dbo.UserInfoes");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Users", "ModifiedBy", "dbo.Users");
            DropForeignKey("dbo.Users", "CreatedBy", "dbo.Users");
            DropIndex("dbo.Users", new[] { "ModifiedBy" });
            DropIndex("dbo.Users", new[] { "CreatedBy" });
            DropIndex("dbo.Users", new[] { "UserInfoId" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Roles", new[] { "ModifiedBy" });
            DropIndex("dbo.Roles", new[] { "CreatedBy" });
            DropTable("dbo.UserInfoes");
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
        }
    }
}