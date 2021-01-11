using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektni_zadatak
{
    public class Zaposlenici
    {
        [Key]
        public int Id { get; set; }

        [StringLength(10)]
        public string Sifra { get; set; }

        [StringLength(25)]
        public string Prezime { get; set; }

        [StringLength(25)]
        public string Ime { get; set; }

        [StringLength(25)]
        public string Pol { get; set; }

        [StringLength(50)]
        public string Grad { get; set; }

        [StringLength(70)]
        public string Adresa { get; set; }

        public DateTime DatumDodavanja { get; set; }
        public DateTime DatumIzmjene { get; set; }

    }
}
