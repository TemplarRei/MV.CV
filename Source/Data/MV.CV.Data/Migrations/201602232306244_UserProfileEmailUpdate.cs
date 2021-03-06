﻿namespace MV.CV.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class UserProfileEmailUpdate : DbMigration
    {
        public override void Up()
        {
            this.AddColumn("dbo.UserProfiles", "Email", c => c.String());
        }

        public override void Down()
        {
            this.DropColumn("dbo.UserProfiles", "Email");
        }
    }
}
