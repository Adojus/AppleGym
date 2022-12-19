namespace BlazorServer.Models
{
    public class Narystes
    {
        public int id { get; set; }
        public DateTime galiojaNuo { get; set; }
        public DateTime galiojaIki { get; set; }
        public int fk_Klientaiid { get; set; }
    }
}
