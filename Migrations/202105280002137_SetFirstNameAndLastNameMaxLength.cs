namespace StaffWpf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetFirstNameAndLastNameMaxLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "FirstName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Employees", "LastName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "LastName", c => c.String());
            AlterColumn("dbo.Employees", "FirstName", c => c.String());
        }
    }
}
