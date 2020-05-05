using System.ComponentModel.DataAnnotations.Schema;

namespace WhichCloud.Web.Models
{
    public class VM
    {
        public int Id { get; set; }
        public VMType VMType { get; set; }
        public int Memory { get; set; }
        public int CPU { get; set; }
        public int Storage { get; set; }
        public double Bandwidth { get; set; }
        public double Price { get; set; }
        public string Link { get; set; }
        public string Source { get; set; }
    }
}