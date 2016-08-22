namespace Apalah.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tambahkolom : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mahasiswas", "Alamat", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mahasiswas", "Alamat");
        }
    }
}
