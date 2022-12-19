namespace BlazorServer.Models
{
    public class Klientas
    {
        public int id { get; set; }
        public int narioStatusas { get; set; }
        public string pazangosLygis { get; set; }
        public int fk_Naudotojaiid { get; set; }
    }
}
