namespace Kutuphane.WFA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class duzeltme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KitapUyeler", "KiralamaTarihi", c => c.DateTime(nullable: false, storeType: "smalldatetime"));
            AlterColumn("dbo.KitapUyeler", "TeslimTarihi", c => c.DateTime(storeType: "smalldatetime"));
            AlterColumn("dbo.KitapUyeler", "Ceza", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Uyeler", "Mail", c => c.String(maxLength: 50));
            DropColumn("dbo.KitapUyeler", "KiraTarihi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.KitapUyeler", "KiraTarihi", c => c.DateTime(nullable: false, storeType: "smalldatetime"));
            AlterColumn("dbo.Uyeler", "Mail", c => c.String());
            AlterColumn("dbo.KitapUyeler", "Ceza", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.KitapUyeler", "TeslimTarihi", c => c.DateTime(nullable: false, storeType: "smalldatetime"));
            DropColumn("dbo.KitapUyeler", "KiralamaTarihi");
        }
    }
}
