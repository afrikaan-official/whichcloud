namespace WhichCloud.Web.Models
{
    public class VMModel
    {
        public int Id { get; set; }
        public VMTypeModel Type { get; set; }
        public int Memory { get; set; }
        public int CPU { get; set; }
        public int Storage { get; set; }
        public double Bandwidth { get; set; }
        public double Price { get; set; }
        public string Link { get; set; }
        public string Source { get; set; }
    }
}