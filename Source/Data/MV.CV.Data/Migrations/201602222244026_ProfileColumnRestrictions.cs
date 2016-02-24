namespace MV.CV.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class ProfileColumnRestrictions : DbMigration
    {
        public override void Up()
        {
            this.AddColumn("dbo.UserProfiles", "IsActive", c => c.Boolean(nullable: false));
            this.AlterColumn("dbo.UserProfiles", "FirstName", c => c.String(nullable: false, maxLength: 100));
            this.AlterColumn("dbo.UserProfiles", "LastName", c => c.String(nullable: false, maxLength: 100));
        }

        public override void Down()
        {
            this.AlterColumn("dbo.UserProfiles", "LastName", c => c.String());
            this.AlterColumn("dbo.UserProfiles", "FirstName", c => c.String());
            this.DropColumn("dbo.UserProfiles", "IsActive");
        }
    }
}
