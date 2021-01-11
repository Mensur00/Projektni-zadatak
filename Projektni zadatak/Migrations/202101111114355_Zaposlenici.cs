namespace Projektni_zadatak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Zaposlenici : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Zaposlenici",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sifra = c.String(),
                        Prezime = c.String(),
                        Ime = c.String(),
                        Pol = c.String(),
                        Grad = c.String(),
                        Adresa = c.String(),
                        DatumDodavanja = c.DateTime(nullable: false),
                        DatumIzmjene = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Zaposlenici");
        }
    }
}
