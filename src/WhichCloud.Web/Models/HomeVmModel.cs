using System.Collections.Generic;

namespace WhichCloud.Web.Models
{
    public class HomeVmModel
    {
        public List<VMModel> Vms { get; set; }
        public SourceModel Source { get; set; }
        
    }
}