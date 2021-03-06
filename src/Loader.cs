﻿namespace PluginsLoader
{
    /// <summary>
    /// Provider of plugins loaders.
    /// </summary>
    public static class Loader
    {
        private static IPluginsLoader _defaultLoader;

        private static object _locker = new object();

        /// <summary>
        /// Default and recommended implementation of pugins loader.
        /// </summary>
        public static IPluginsLoader Default
        {
            get
            {
                if (_defaultLoader != null)
                    return _defaultLoader;

                lock (_locker)
                {
                    return _defaultLoader ?? (_defaultLoader = new DefaultPluginsLoader());
                }
            }
        }
    }
}
