namespace Assingment_3_B.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inisial_15766 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Candidates", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Candidates", "Email", c => c.String());
        }
    }
}
