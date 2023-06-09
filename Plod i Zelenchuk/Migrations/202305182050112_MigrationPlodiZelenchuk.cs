namespace Plod_i_Zelenchuk.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationPlodiZelenchuk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vegans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Opisanie = c.String(),
                        Cena = c.Int(nullable: false),
                        VeganTypeId = c.Int(nullable: false),
                        vegantypes_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.VeganTypes", t => t.vegantypes_Id)
                .Index(t => t.vegantypes_Id);
            
            CreateTable(
                "dbo.VeganTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vegans", "vegantypes_Id", "dbo.VeganTypes");
            DropIndex("dbo.Vegans", new[] { "vegantypes_Id" });
            DropTable("dbo.VeganTypes");
            DropTable("dbo.Vegans");
        }
    }
}
