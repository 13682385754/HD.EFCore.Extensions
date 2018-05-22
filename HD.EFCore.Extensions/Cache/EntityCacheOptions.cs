﻿using System;
using System.Collections.Generic;

namespace HD.EFCore.Extensions.Cache
{
    public class EntityCacheOptions
    {
        public Func<string, object> Get;

        public Func<IEnumerable<string>, IEnumerable<object>> Gets;

        public Func<string, object, bool> Set;

        public Func<IEnumerable<string>, IEnumerable<object>, bool> Sets;

        public Func<string, bool> Del;

        /// <summary>
        /// item1: entity type
        /// item2: entity value
        /// item3: CacheItem value
        /// </summary>
        public Func<Type, object, object> Map;
    }
}
