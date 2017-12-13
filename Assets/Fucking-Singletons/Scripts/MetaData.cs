using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuckingSingletons
{
    /// <summary>
    /// Global metadata for the FS implementation
    /// </summary>
    public static class Metadata
    {
        public static class AssetMenuOrdering
        {
            public const int Primitives = 1;
            public const int Sets = 10;
        }

        public static readonly Version Version = new Version(0, 1, 0, 0);

        public const string AssetMenuName = "FS/";
    }
}
