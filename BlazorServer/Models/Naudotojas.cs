using System.ComponentModel.DataAnnotations;
namespace BlazorServer.Models
{
    public class Naudotojas
    {
        public int id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Per ilgas vardas.")]
        public string vardas { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Per ilga pavardė.")]
        public string pavarde { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Per ilgas el. paštas.")]
        public string elPastas { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Per ilgas miestas.")]
        public string miestas { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Per ilgas pašto kodas.")]
        public string pastoKodas { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Per ilgas adresas.")]
        public string adresas { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Per ilgas slaptažodis.")]
        public string slaptazodis { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Per ilgas slapyvardis.")]
        public string slapyvardis { get; set; }
        public string registracijosData { get; set; }
        [Required]

        public string lytis { get; set; }
        public string role { get; set; }

    }

    //public class Lytys 
    //{ 
    //    public readonly string vyras = "vyras";
    //    public readonly string moteris = "moteris";
    //}

}
