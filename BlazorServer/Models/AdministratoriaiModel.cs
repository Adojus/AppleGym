namespace BlazorServer.Models
{
    public class AdministratoriaiModel
    {
        public int Id { get; set; }
        public int naujienuSk { get; set; }
        public int ataskaituSk { get; set; }
        public string lygis { get; set; }
        public int fk_naudotojaiid { get; set; }
    }
}
