using MDR.Domain.Model;
using MDR.Web.UI.Models;

namespace MDR.Web.UI.App_Start
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            AutoMapper.Mapper.CreateMap<DamageReport, CreateDamageReportViewModel>()
                .ForMember(dest => dest.CompanyName, opts => opts.MapFrom(src => src.ReportingCompany));
        }
    }
}
