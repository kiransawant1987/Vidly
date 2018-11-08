namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'890fd4f5-7ebc-47df-a600-c1ecc9859d19', N'guest@vidly.com', 0, N'AGmfBwwUg83q5h8sflcEm9XKIWaWBhz9V0pVaV6rWjWmtibPAFkl/m25eqT8ENvGzA==', N'24db0ade-d36b-4c21-8a84-7df6074f2a97', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9e1d232f-196d-4a08-9a1e-42f540bc86ad', N'admin@vidly.com', 0, N'AKZWYpAt5M5vDX+4NTAmKFvJnrkyRAGFcKucd3BjI3YnVbsaW0ai9H1TNTHF1TuXJw==', N'b2b652ba-6ca6-4a6e-b8d2-68761e7bfae0', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6a30e9a8-6065-4248-8b2f-e0e439147d6b', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9e1d232f-196d-4a08-9a1e-42f540bc86ad', N'6a30e9a8-6065-4248-8b2f-e0e439147d6b')

");
        }

        public override void Down()
        {
        }
    }
}
