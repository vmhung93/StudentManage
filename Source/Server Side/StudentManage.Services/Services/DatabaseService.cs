﻿using StudentManage.Domain.DbContext;
using System.Data.Entity;
using System.Linq;

namespace StudentManage.Services.Services
{
    public static class DatabaseService
    {
        public static void InitDatabase()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentManageDbContext, Domain.Migrations.Configuration>());

            var configuration = new Domain.Migrations.Configuration();
            var migration = new System.Data.Entity.Migrations.DbMigrator(configuration);
            if (migration.GetPendingMigrations().Any())
            {
                migration.Update();
            }
        }
    }
}