using AutoMapper;
using WhichCloud.Web.Models;

namespace WhichCloud.Web.Bus
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<VM, VMModel>();

            CreateMap<VMType, VMTypeModel>();
        }
    }
}