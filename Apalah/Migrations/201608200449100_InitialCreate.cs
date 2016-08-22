namespace Apalah.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jurusans",
                c => new
                    {
                        JurusanID = c.Int(nullable: false, identity: true),
                        Nama = c.String(),
                    })
                .PrimaryKey(t => t.JurusanID);
            
            CreateTable(
                "dbo.Mahasiswas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nama = c.String(),
                        Jurusan_JurusanID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Jurusans", t => t.Jurusan_JurusanID)
                .Index(t => t.Jurusan_JurusanID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mahasiswas", "Jurusan_JurusanID", "dbo.Jurusans");
            DropIndex("dbo.Mahasiswas", new[] { "Jurusan_JurusanID" });
            DropTable("dbo.Mahasiswas");
            DropTable("dbo.Jurusans");
        }
    }
}
