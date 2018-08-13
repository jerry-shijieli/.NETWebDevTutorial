namespace WebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'47b391f8-faec-401f-bc63-e5ac1f048768', N'guest@gmail.com', 0, N'AOcZd3DWFbwYSlI2A8QRiXRJkmv4g+QdjwyINBXfPtL1cwq2GHl1nH2R2crAkiNWBg==', N'754c963d-eb94-49ca-869b-7cc94fb903d7', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'53434a69-ea70-4756-8c29-ab2199817352', N'admin@gmail.com', 0, N'ADDVWTcGs1FWBbKMe1ZJB3wlxYWbQWGJj1JXT16rws5BdqkFlr6Fo+lTn1CbZv5ybg==', N'3081fad6-a1f0-4cfb-9d57-0e2107c31841', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4ff2421b-2b82-4d3a-9c39-09084f5c2fd9', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'53434a69-ea70-4756-8c29-ab2199817352', N'4ff2421b-2b82-4d3a-9c39-09084f5c2fd9')
");
        }
        
        public override void Down()
        {
        }
    }
}
