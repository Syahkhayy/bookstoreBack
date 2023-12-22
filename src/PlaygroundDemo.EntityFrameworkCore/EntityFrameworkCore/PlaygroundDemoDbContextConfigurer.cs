using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace PlaygroundDemo.EntityFrameworkCore
{
    public static class PlaygroundDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PlaygroundDemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PlaygroundDemoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}