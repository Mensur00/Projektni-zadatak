namespace Projektni_zadatak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PromjenaVarijabli : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Zaposlenici", "Sifra", c => c.String(maxLength: 10));
            AlterColumn("dbo.Zaposlenici", "Prezime", c => c.String(maxLength: 25));
            AlterColumn("dbo.Zaposlenici", "Ime", c => c.String(maxLength: 25));
            AlterColumn("dbo.Zaposlenici", "Pol", c => c.String(maxLength: 25));
            AlterColumn("dbo.Zaposlenici", "Grad", c => c.String(maxLength: 50));
            AlterColumn("dbo.Zaposlenici", "Adresa", c => c.String(maxLength: 70));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Zaposlenici", "Adresa", c => c.String());
            AlterColumn("dbo.Zaposlenici", "Grad", c => c.String());
            AlterColumn("dbo.Zaposlenici", "Pol", c => c.String());
            AlterColumn("dbo.Zaposlenici", "Ime", c => c.String());
            AlterColumn("dbo.Zaposlenici", "Prezime", c => c.String());
            AlterColumn("dbo.Zaposlenici", "Sifra", c => c.String());
        }
    }
}
