namespace GuestAndReservations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFKAndReservationNavigationIntoGuest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Guests", "ReservationId", c => c.Int(nullable: false));
            CreateIndex("dbo.Guests", "ReservationId");
            AddForeignKey("dbo.Guests", "ReservationId", "dbo.Reservations", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Guests", "ReservationId", "dbo.Reservations");
            DropIndex("dbo.Guests", new[] { "ReservationId" });
            DropColumn("dbo.Guests", "ReservationId");
        }
    }
}
