namespace Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "studentAddress", c => c.String(nullable: false));
            DropColumn("dbo.Students", "studentAdress");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "studentAdress", c => c.String(nullable: false));
            DropColumn("dbo.Students", "studentAddress");
        }
    }
}
