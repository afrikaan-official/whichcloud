using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WhichCloud.Web.Models
{
    public class Source
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Url { get; set; }
        public DateTime CreateDate { get; set; }
    }
    
    
}