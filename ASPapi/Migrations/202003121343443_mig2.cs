namespace ASPapi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DailyMenus", "DayName", c => c.String(nullable: false));
        }

        public override void Down()
        {
        }
    }
}