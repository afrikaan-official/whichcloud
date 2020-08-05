using System.Threading.Tasks;
using WhichCloud.Web.Models;

namespace WhichCloud.Web.Bus
{
    public interface ISourceService
    {
        Task<int> InsertSource(SourceModel source);
    }
}