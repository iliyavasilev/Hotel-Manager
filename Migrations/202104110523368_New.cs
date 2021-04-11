namespace Hotel_Reservation_Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Reservations", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "Date", c => c.DateTime(nullable: false));
        }
    }
}
