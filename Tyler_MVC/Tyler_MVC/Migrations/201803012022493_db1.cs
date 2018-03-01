namespace Tyler_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Netflixes", "Genre", c => c.String());
            AddColumn("dbo.Netflixes", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Netflixes", "Description");
            DropColumn("dbo.Netflixes", "Genre");
        }
    }
}
