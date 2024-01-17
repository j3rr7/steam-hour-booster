using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamGameBooster
{
    public static class IdleConfig
    {
        public static string GetHeaderImageUrl(int appId)
        {
            return $"https://cdn.akamai.steamstatic.com/steam/apps/{appId}/header_292x136.jpg";
        }
    }
}
