namespace ASPapi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CurrentMenus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Dessert = c.String(),
                        MainDish = c.String(),
                        SecondDish = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DailyMenus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DayName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WeeklyMenus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        WeekNr = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        calories = c.Decimal(nullable: false, precision: 18, scale: 2),
                        quantity = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DailyMenuCurrentMenus",
                c => new
                    {
                        DailyMenu_ID = c.Int(nullable: false),
                        CurrentMenu_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DailyMenu_ID, t.CurrentMenu_ID })
                .ForeignKey("dbo.DailyMenus", t => t.DailyMenu_ID, cascadeDelete: true)
                .ForeignKey("dbo.CurrentMenus", t => t.CurrentMenu_ID, cascadeDelete: true)
                .Index(t => t.DailyMenu_ID)
                .Index(t => t.CurrentMenu_ID);
            
            CreateTable(
                "dbo.WeeklyMenuDailyMenus",
                c => new
                    {
                        WeeklyMenu_ID = c.Int(nullable: false),
                        DailyMenu_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.WeeklyMenu_ID, t.DailyMenu_ID })
                .ForeignKey("dbo.WeeklyMenus", t => t.WeeklyMenu_ID, cascadeDelete: true)
                .ForeignKey("dbo.DailyMenus", t => t.DailyMenu_ID, cascadeDelete: true)
                .Index(t => t.WeeklyMenu_ID)
                .Index(t => t.DailyMenu_ID);
            
            CreateTable(
                "dbo.CurrentMenuFoods",
                c => new
                    {
                        CurrentMenu_ID = c.Int(nullable: false),
                        Food_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CurrentMenu_ID, t.Food_ID })
                .ForeignKey("dbo.CurrentMenus", t => t.CurrentMenu_ID, cascadeDelete: true)
                .ForeignKey("dbo.Foods", t => t.Food_ID, cascadeDelete: true)
                .Index(t => t.CurrentMenu_ID)
                .Index(t => t.Food_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CurrentMenuFoods", "Food_ID", "dbo.Foods");
            DropForeignKey("dbo.CurrentMenuFoods", "CurrentMenu_ID", "dbo.CurrentMenus");
            DropForeignKey("dbo.WeeklyMenuDailyMenus", "DailyMenu_ID", "dbo.DailyMenus");
            DropForeignKey("dbo.WeeklyMenuDailyMenus", "WeeklyMenu_ID", "dbo.WeeklyMenus");
            DropForeignKey("dbo.DailyMenuCurrentMenus", "CurrentMenu_ID", "dbo.CurrentMenus");
            DropForeignKey("dbo.DailyMenuCurrentMenus", "DailyMenu_ID", "dbo.DailyMenus");
            DropIndex("dbo.CurrentMenuFoods", new[] { "Food_ID" });
            DropIndex("dbo.CurrentMenuFoods", new[] { "CurrentMenu_ID" });
            DropIndex("dbo.WeeklyMenuDailyMenus", new[] { "DailyMenu_ID" });
            DropIndex("dbo.WeeklyMenuDailyMenus", new[] { "WeeklyMenu_ID" });
            DropIndex("dbo.DailyMenuCurrentMenus", new[] { "CurrentMenu_ID" });
            DropIndex("dbo.DailyMenuCurrentMenus", new[] { "DailyMenu_ID" });
            DropTable("dbo.CurrentMenuFoods");
            DropTable("dbo.WeeklyMenuDailyMenus");
            DropTable("dbo.DailyMenuCurrentMenus");
            DropTable("dbo.Foods");
            DropTable("dbo.WeeklyMenus");
            DropTable("dbo.DailyMenus");
            DropTable("dbo.CurrentMenus");
        }
    }
}
