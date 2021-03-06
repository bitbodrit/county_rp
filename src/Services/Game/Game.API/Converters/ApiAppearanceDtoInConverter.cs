using CountyRP.Services.Game.API.Models.Api;
using CountyRP.Services.Game.Infrastructure.Models;

namespace CountyRP.Services.Game.API.Converters
{
    public static class ApiAppearanceDtoInConverter
    {
        public static AppearanceDtoIn ToRepository(
            ApiAppearanceDtoIn source
        )
        {
            return new AppearanceDtoIn(
                gender: source.Gender,
                motherBlend: source.MotherBlend,
                fatherBlend: source.FatherBlend,
                blendShape: source.BlendShape,
                blendSkin: source.BlendSkin,
                eyeColor: source.EyeColor,
                hairColor: source.HairColor,
                hairHighlight: source.HairHighlight,
                noseWidth: source.NoseWidth,
                noseHeight: source.NoseHeight,
                noseBridge: source.NoseBridge,
                noseTip: source.NoseTip,
                noseBridgeShift: source.NoseBridgeShift,
                browHeight: source.BrowHeight,
                browWidth: source.BrowWidth,
                cBoneHeight: source.CBoneHeight,
                cBoneWidth: source.CBoneWidth,
                cheekWidth: source.CheekWidth,
                eyes: source.Eyes,
                lips: source.Lips,
                jawWidth: source.JawWidth,
                jawHeight: source.JawHeight,
                chinLength: source.ChinLength,
                chinPos: source.ChinPos,
                chinWidth: source.ChinWidth,
                chinShape: source.ChinShape,
                neckWidth: source.NeckWidth
            );
        }

        public static AppearanceDtoOut ToDtoOutRepository(
            ApiAppearanceDtoIn source,
            int id
        )
        {
            return new AppearanceDtoOut(
                id: id,
                gender: source.Gender,
                motherBlend: source.MotherBlend,
                fatherBlend: source.FatherBlend,
                blendShape: source.BlendShape,
                blendSkin: source.BlendSkin,
                eyeColor: source.EyeColor,
                hairColor: source.HairColor,
                hairHighlight: source.HairHighlight,
                noseWidth: source.NoseWidth,
                noseHeight: source.NoseHeight,
                noseBridge: source.NoseBridge,
                noseTip: source.NoseTip,
                noseBridgeShift: source.NoseBridgeShift,
                browHeight: source.BrowHeight,
                browWidth: source.BrowWidth,
                cBoneHeight: source.CBoneHeight,
                cBoneWidth: source.CBoneWidth,
                cheekWidth: source.CheekWidth,
                eyes: source.Eyes,
                lips: source.Lips,
                jawWidth: source.JawWidth,
                jawHeight: source.JawHeight,
                chinLength: source.ChinLength,
                chinPos: source.ChinPos,
                chinWidth: source.ChinWidth,
                chinShape: source.ChinShape,
                neckWidth: source.NeckWidth
            );
        }
    }
}
