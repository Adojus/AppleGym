namespace BlazorServer.Models
{
    public class AtaskaitaModel
    {
        public int id { get; set; }
        public string data { get; set; }
        public string pavadinimas { get; set; }
        public string aprasymas { get; set; }
        public int fk_Administratoriaiid { get; set; }
    }
}
