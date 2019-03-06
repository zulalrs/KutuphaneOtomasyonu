namespace Kutuphane.WFA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class duzeltmeyazar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Yazarlar", "YazarAdi", c => c.String(nullable: false, maxLength: 70));
            DropColumn("dbo.Yazarlar", "Ad");
            DropColumn("dbo.Yazarlar", "Soyad");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Yazarlar", "Soyad", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.Yazarlar", "Ad", c => c.String(nullable: false, maxLength: 20));
            DropColumn("dbo.Yazarlar", "YazarAdi");
        }
    }
}
