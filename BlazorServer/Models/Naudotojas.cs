using System.ComponentModel.DataAnnotations;
namespace BlazorServer.Models
{
    public class Naudotojas
    {
        public int id { get; set; }
        [Required]
        public string vardas { get; set; }
        [Required]
        public string pavarde { get; set; }
        [Required]
        public string elPastas { get; set; }
        public string miestas { get; set; }
        public string pastoKodas { get; set; }
        public string adresas { get; set; }
        [Required]
        public string slaptazodis { get; set; }
        public string slapyvardis { get; set; }
        public string registracijosData { get; set; }
        public string lytis { get; set; }
        public string role { get; set; }

    }

}
