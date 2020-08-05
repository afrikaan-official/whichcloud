using System;

namespace WhichCloud.Web.Models
{
    public class SourceModel
    {
        public string Url { get; set; }
        public DateTime CreateDate { get; set; }

        public SourceModel()
        {
            CreateDate=DateTime.Now;
        }
    }
}