namespace ASPapi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DailyMenus", "DayName", c => c.String(maxLength: 10, nullable: false));
        }

        public override void Down()
        {
            AlterColumn("dbo.DailyMenus", "DayName", c => c.String());
        }
    }
}