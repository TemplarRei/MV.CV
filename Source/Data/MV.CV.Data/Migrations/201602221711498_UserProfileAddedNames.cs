namespace MV.CV.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class UserProfileAddedNames : DbMigration
    {
        public override void Up()
        {
            this.CreateTable(
                "dbo.Certifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Field = c.String(),
                        Skills = c.String(),
                        From = c.DateTime(nullable: false),
                        To = c.DateTime(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                        UserProfile_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserProfiles", t => t.UserProfile_Id)
                .Index(t => t.IsDeleted)
                .Index(t => t.UserProfile_Id);

            this.CreateTable(
                "dbo.Educations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SchoolName = c.String(),
                        Degree = c.String(),
                        From = c.DateTime(nullable: false),
                        To = c.DateTime(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                        UserProfile_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserProfiles", t => t.UserProfile_Id)
                .Index(t => t.IsDeleted)
                .Index(t => t.UserProfile_Id);

            this.CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Employer = c.String(),
                        Position = c.String(),
                        From = c.DateTime(nullable: false),
                        To = c.DateTime(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                        UserProfile_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserProfiles", t => t.UserProfile_Id)
                .Index(t => t.IsDeleted)
                .Index(t => t.UserProfile_Id);

            this.CreateTable(
                "dbo.Languages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                        UserProfile_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserProfiles", t => t.UserProfile_Id)
                .Index(t => t.IsDeleted)
                .Index(t => t.UserProfile_Id);

            this.CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Url = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                        UserProfile_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserProfiles", t => t.UserProfile_Id)
                .Index(t => t.IsDeleted)
                .Index(t => t.UserProfile_Id);

            this.CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        SoftSkills = c.String(),
                        SpecializedSkills = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.IsDeleted);
        }

        public override void Down()
        {
            this.DropForeignKey("dbo.UserProfiles", "UserId", "dbo.AspNetUsers");
            this.DropForeignKey("dbo.Projects", "UserProfile_Id", "dbo.UserProfiles");
            this.DropForeignKey("dbo.Languages", "UserProfile_Id", "dbo.UserProfiles");
            this.DropForeignKey("dbo.Jobs", "UserProfile_Id", "dbo.UserProfiles");
            this.DropForeignKey("dbo.Educations", "UserProfile_Id", "dbo.UserProfiles");
            this.DropForeignKey("dbo.Certifications", "UserProfile_Id", "dbo.UserProfiles");
            this.DropIndex("dbo.UserProfiles", new[] { "IsDeleted" });
            this.DropIndex("dbo.UserProfiles", new[] { "UserId" });
            this.DropIndex("dbo.Projects", new[] { "UserProfile_Id" });
            this.DropIndex("dbo.Projects", new[] { "IsDeleted" });
            this.DropIndex("dbo.Languages", new[] { "UserProfile_Id" });
            this.DropIndex("dbo.Languages", new[] { "IsDeleted" });
            this.DropIndex("dbo.Jobs", new[] { "UserProfile_Id" });
            this.DropIndex("dbo.Jobs", new[] { "IsDeleted" });
            this.DropIndex("dbo.Educations", new[] { "UserProfile_Id" });
            this.DropIndex("dbo.Educations", new[] { "IsDeleted" });
            this.DropIndex("dbo.Certifications", new[] { "UserProfile_Id" });
            this.DropIndex("dbo.Certifications", new[] { "IsDeleted" });
            this.DropTable("dbo.UserProfiles");
            this.DropTable("dbo.Projects");
            this.DropTable("dbo.Languages");
            this.DropTable("dbo.Jobs");
            this.DropTable("dbo.Educations");
            this.DropTable("dbo.Certifications");
        }
    }
}
