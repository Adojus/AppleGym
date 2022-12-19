namespace BlazorServer.Models
{
    public class TrenerisModel
    {
        public int id { get; set; }
        public int tabelioNr { get; set; }
        public string issilavinimas { get; set; }
        public string specializacija { get; set; }
        public int fk_Naudotojaiid { get; set; }
    }
}
