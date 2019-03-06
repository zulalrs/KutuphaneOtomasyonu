namespace Kutuphane.WFA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kitaplar",
                c => new
                    {
                        KitapId = c.Int(nullable: false, identity: true),
                        Barkod = c.String(nullable: false, maxLength: 5),
                        KitapAdi = c.String(nullable: false, maxLength: 50),
                        Adet = c.Int(nullable: false),
                        YazarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KitapId)
                .ForeignKey("dbo.Yazarlar", t => t.YazarId, cascadeDelete: true)
                .Index(t => t.Barkod, unique: true)
                .Index(t => t.YazarId);
            
            CreateTable(
                "dbo.KitapUyeler",
                c => new
                    {
                        KitapId = c.Int(nullable: false),
                        UyeId = c.Int(nullable: false),
                        KiraTarihi = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        TeslimTarihi = c.DateTime(nullable: false, storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => new { t.KitapId, t.UyeId })
                .ForeignKey("dbo.Kitaplar", t => t.KitapId, cascadeDelete: true)
                .ForeignKey("dbo.Uyeler", t => t.UyeId, cascadeDelete: true)
                .Index(t => t.KitapId)
                .Index(t => t.UyeId);
            
            CreateTable(
                "dbo.Uyeler",
                c => new
                    {
                        UyeId = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 20),
                        Soyad = c.String(nullable: false, maxLength: 20),
                        TCKN = c.String(nullable: false, maxLength: 11),
                        Telefon = c.String(nullable: false, maxLength: 10),
                        Mail = c.String(),
                        DogumTarihi = c.DateTime(nullable: false, storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => t.UyeId)
                .Index(t => t.TCKN, unique: true);
            
            CreateTable(
                "dbo.Yazarlar",
                c => new
                    {
                        YazarId = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 20),
                        Soyad = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.YazarId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kitaplar", "YazarId", "dbo.Yazarlar");
            DropForeignKey("dbo.KitapUyeler", "UyeId", "dbo.Uyeler");
            DropForeignKey("dbo.KitapUyeler", "KitapId", "dbo.Kitaplar");
            DropIndex("dbo.Uyeler", new[] { "TCKN" });
            DropIndex("dbo.KitapUyeler", new[] { "UyeId" });
            DropIndex("dbo.KitapUyeler", new[] { "KitapId" });
            DropIndex("dbo.Kitaplar", new[] { "YazarId" });
            DropIndex("dbo.Kitaplar", new[] { "Barkod" });
            DropTable("dbo.Yazarlar");
            DropTable("dbo.Uyeler");
            DropTable("dbo.KitapUyeler");
            DropTable("dbo.Kitaplar");
        }
    }
}
