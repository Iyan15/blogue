namespace Apalah.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tambahkolomlagi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mahasiswas", "Hobi", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mahasiswas", "Hobi");
        }
    }
}
