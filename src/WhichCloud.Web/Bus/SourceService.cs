using System.Threading.Tasks;
using AutoMapper;
using WhichCloud.Web.data;
using WhichCloud.Web.Models;

namespace WhichCloud.Web.Bus
{
    public class SourceService : ISourceService
    {
        private readonly ResourceContext _context;
        private readonly IMapper _mapper;

        public SourceService(ResourceContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        
        public async Task<int> InsertSource(SourceModel source)
        {
            var entity = _mapper.Map<Source>(source);

            await _context.Sources.AddAsync(entity);

            return await _context.SaveChangesAsync();
        }
    }
}