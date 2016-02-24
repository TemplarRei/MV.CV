namespace MV.CV.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImStupid : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Projects", "UserProfile_Id", "dbo.UserProfiles");
            DropIndex("dbo.Projects", new[] { "UserProfile_Id" });
            DropColumn("dbo.Projects", "ProfileId");
            RenameColumn(table: "dbo.Projects", name: "UserProfile_Id", newName: "ProfileId");
            AlterColumn("dbo.Projects", "ProfileId", c => c.Int(nullable: false));
            CreateIndex("dbo.Projects", "ProfileId");
            AddForeignKey("dbo.Projects", "ProfileId", "dbo.UserProfiles", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "ProfileId", "dbo.UserProfiles");
            DropIndex("dbo.Projects", new[] { "ProfileId" });
            AlterColumn("dbo.Projects", "ProfileId", c => c.Int());
            RenameColumn(table: "dbo.Projects", name: "ProfileId", newName: "UserProfile_Id");
            AddColumn("dbo.Projects", "ProfileId", c => c.Int(nullable: false));
            CreateIndex("dbo.Projects", "UserProfile_Id");
            AddForeignKey("dbo.Projects", "UserProfile_Id", "dbo.UserProfiles", "Id");
        }
    }
}
