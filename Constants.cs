using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stremio_greek_tv
{
    class Constants
    {
        public const string TVChannelsFileUrl = "https://raw.githubusercontent.com/mik25/stremio-greek-tv/master/stremio-greek-tv/Resources/Playlists/GRTV.m3u";
        public const string TVChannelsFilePath = @"Resources\Playlists\GRTV.m3u";
    }

    class CacheConstants
    {       
        public const string CatalogCacheKey = "catalogs_tv";
    }
}
