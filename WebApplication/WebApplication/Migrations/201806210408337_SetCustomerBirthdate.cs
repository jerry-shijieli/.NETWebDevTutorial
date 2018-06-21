namespace WebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetCustomerBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = Cast('1999-01-01' as DATETIME) WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
