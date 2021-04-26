namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataType : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Student", "Secret");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Student", "Secret", c => c.String());
        }
    }
}
