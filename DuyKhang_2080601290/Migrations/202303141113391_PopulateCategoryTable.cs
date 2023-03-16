namespace DuyKhang_2080601290.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES ( NAME) VALUES ( 'Development')");
            Sql("INSERT INTO CATEGORIES ( NAME) VALUES ( 'Business')");
            Sql("INSERT INTO CATEGORIES ( NAME) VALUES ( 'Marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
