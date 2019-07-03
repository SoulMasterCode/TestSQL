namespace TestDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Steps",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Detail = c.String(),
                        Order = c.Short(nullable: false),
                        ProjectId = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.ProjectId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.ProjectId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Steps", "UserId", "dbo.Users");
            DropForeignKey("dbo.Steps", "ProjectId", "dbo.Projects");
            DropIndex("dbo.Steps", new[] { "UserId" });
            DropIndex("dbo.Steps", new[] { "ProjectId" });
            DropTable("dbo.Users");
            DropTable("dbo.Steps");
            DropTable("dbo.Projects");
        }
    }
}
