namespace BlazorServer.Models
{
    public class TreniruoteModel
    {
        public int id { get; set; }
        public string data { get; set; }
        public int prisiregistravusiuSk { get; set; }
        public int fk_SportoKlubaiid { get; set; }
        public int fk_Treneriaiid { get; set; }
    }
}
