using System.Collections.Generic;
using System.Threading.Tasks;
using WhichCloud.Web.Models;

namespace WhichCloud.Web.Bus
{
    public interface IVMService
    {
        Task<List<VMModel>> GetAllVms();
    }
}