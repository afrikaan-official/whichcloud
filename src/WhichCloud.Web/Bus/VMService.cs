using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WhichCloud.Web.data;
using WhichCloud.Web.Models;

namespace WhichCloud.Web.Bus
{
    public class VMService : IVMService
    { 
        private readonly ResourceContext _context;
        private readonly IMapper _mapper;
        
        
        public VMService(ResourceContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<List<VMModel>> GetAllVms()
        {
            var vms = await _context.VMs.OrderBy(x=>x.Price)
                .ToListAsync();

            return _mapper.Map<List<VMModel>>(vms);
        }
    }
}