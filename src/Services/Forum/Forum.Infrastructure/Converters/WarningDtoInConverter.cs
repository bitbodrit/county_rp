using CountyRP.Services.Forum.Infrastructure.Entities;
using CountyRP.Services.Forum.Infrastructure.Models;

namespace CountyRP.Services.Forum.Infrastructure.Converters
{
    internal static class WarningDtoInConverter
    {
        public static WarningDao ToDb(
            WarningDtoIn source
        )
        {
            return new WarningDao(
                id: 0,
                userId: source.UserId,
                adminId: source.AdminId,
                dateTime: source.DateTime,
                finishDateTime: source.FinishDateTime,
                action: source.Action,
                text: source.Text
            );
        }

        public static WarningDtoOut ToDtoOut(
            WarningDtoIn source,
            int id
        )
        {
            return new WarningDtoOut(
                id: id,
                userId: source.UserId,
                adminId: source.AdminId,
                dateTime: source.DateTime,
                finishDateTime: source.FinishDateTime,
                action: source.Action,
                text: source.Text
            );
        }
    }
}
