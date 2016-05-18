using StudentManage.Domain.DbContext;
using System.Data.Entity;

namespace StudentManage.Services.Services
{
    public static class DatabaseService
    {
        public static void InitDatabase()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentManageDbContext, Domain.Migrations.Configuration>());
        }
    }
}