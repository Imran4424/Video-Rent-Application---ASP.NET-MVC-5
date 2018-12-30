namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0523ac03-a5a1-4cff-a9f6-d8aaaddceca9', N'guest@vidly.com', 0, N'AMIM3kkffuTIMWFWJ6d0Hh83WY3+axOj3uNl4l2HaEizyBDvMl4sLYNyG8iK65Kr/A==', N'198b7a7a-87ed-4d91-9379-a58139b496c9', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6629e918-c16d-4496-bc00-7ac075044ada', N'admin@vidly.com', 0, N'ADZObTey41Dn4UyYAq6F6N44nDs+AEAkGKzLu+FhBP5478zcoy0IQNpL5BFHN9Z+Dg==', N'6ae6174a-bdd0-4be8-a635-1dbc2333359d', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'54a1f9bf-39ad-4f12-aa81-0b3935ebbad7', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6629e918-c16d-4496-bc00-7ac075044ada', N'54a1f9bf-39ad-4f12-aa81-0b3935ebbad7')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
