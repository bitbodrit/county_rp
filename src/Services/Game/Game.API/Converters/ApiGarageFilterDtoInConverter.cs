using CountyRP.Services.Game.API.Models.Api;
using CountyRP.Services.Game.Infrastructure.Models;

namespace CountyRP.Services.Game.API.Converters
{
    public static class ApiGarageFilterDtoInConverter
    {
        public static GarageFilterDtoIn ToRepository(
            ApiGarageFilterDtoIn source
        )
        {
            return new GarageFilterDtoIn(
                count: source.Count,
                page: source.Page,
                ids: source.Ids
            );
        }
    }
}
