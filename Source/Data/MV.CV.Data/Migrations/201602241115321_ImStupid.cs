namespace MV.CV.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class ImStupid : DbMigration
    {
        public override void Up()
        {
            this.DropForeignKey("dbo.Projects", "UserProfile_Id", "dbo.UserProfiles");
            this.DropIndex("dbo.Projects", new[] { "UserProfile_Id" });
            this.DropColumn("dbo.Projects", "ProfileId");
            this.RenameColumn(table: "dbo.Projects", name: "UserProfile_Id", newName: "ProfileId");
            this.AlterColumn("dbo.Projects", "ProfileId", c => c.Int(nullable: false));
            this.CreateIndex("dbo.Projects", "ProfileId");
            this.AddForeignKey("dbo.Projects", "ProfileId", "dbo.UserProfiles", "Id", cascadeDelete: true);
        }

        public override void Down()
        {
            this.DropForeignKey("dbo.Projects", "ProfileId", "dbo.UserProfiles");
            this.DropIndex("dbo.Projects", new[] { "ProfileId" });
            this.AlterColumn("dbo.Projects", "ProfileId", c => c.Int());
            this.RenameColumn(table: "dbo.Projects", name: "ProfileId", newName: "UserProfile_Id");
            this.AddColumn("dbo.Projects", "ProfileId", c => c.Int(nullable: false));
            this.CreateIndex("dbo.Projects", "UserProfile_Id");
            this.AddForeignKey("dbo.Projects", "UserProfile_Id", "dbo.UserProfiles", "Id");
        }
    }
}
