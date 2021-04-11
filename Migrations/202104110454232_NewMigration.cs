namespace Hotel_Reservation_Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMigration : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Reservations");
            AddColumn("dbo.Reservations", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Reservations", "GuestId", c => c.Int(nullable: false));
            AddColumn("dbo.Reservations", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Reservations", "RoomId", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Reservations", "IsActive");
            DropColumn("dbo.Reservations", "RoomNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "RoomNumber", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.Reservations");
            DropColumn("dbo.Reservations", "RoomId");
            DropColumn("dbo.Reservations", "Date");
            DropColumn("dbo.Reservations", "GuestId");
            DropColumn("dbo.Reservations", "IsActive");
            AddPrimaryKey("dbo.Reservations", "RoomNumber");
        }
    }
}
