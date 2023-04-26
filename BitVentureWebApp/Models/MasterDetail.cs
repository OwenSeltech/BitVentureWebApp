namespace BitVentureWebApp.Models
{
    public class MasterDetail
    {
        public IEnumerable<Master> Masters { get; set; }
        public IEnumerable<Detail> Details { get; set; }
    }
}
