namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategorilers",
                c => new
                    {
                        KategoriID = c.Int(nullable: false, identity: true),
                        KategoriAD = c.String(),
                    })
                .PrimaryKey(t => t.KategoriID);
            
            CreateTable(
                "dbo.Urunlers",
                c => new
                    {
                        UrunID = c.Int(nullable: false, identity: true),
                        UrunAD = c.String(),
                        UrunMarka = c.String(),
                        UrunKategori = c.String(),
                        UrunStok = c.Int(nullable: false),
                        Aciklama = c.String(),
                        Kategori_KategoriID = c.Int(),
                    })
                .PrimaryKey(t => t.UrunID)
                .ForeignKey("dbo.Kategorilers", t => t.Kategori_KategoriID)
                .Index(t => t.Kategori_KategoriID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Urunlers", "Kategori_KategoriID", "dbo.Kategorilers");
            DropIndex("dbo.Urunlers", new[] { "Kategori_KategoriID" });
            DropTable("dbo.Urunlers");
            DropTable("dbo.Kategorilers");
        }
    }
}
