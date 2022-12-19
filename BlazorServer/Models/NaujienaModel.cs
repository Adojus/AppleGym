namespace BlazorServer.Models
{
    public class NaujienaModel
    {
        public int id { get; set; }
        public string data { get; set; }
        public string tekstas { get; set; }
        public string antraste { get; set; }
        public int fk_Administratoriaiid { get; set; }
    }
}
