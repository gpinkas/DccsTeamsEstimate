using AutoMapper;
using DccsTeamsEstimate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DccsTeamsEstimate.Mapping
{
    public static class MapperConfigurationExtensions
    {
        public static void AddEstimateMapping(this IMapperConfigurationExpression mapperConfig)
        {
            mapperConfig.CreateMap<DataAccess.DataModel.Card, CardView>();
            mapperConfig.CreateMap<DataAccess.DataModel.Estimate, EstimateView>();
        }
    }
}
