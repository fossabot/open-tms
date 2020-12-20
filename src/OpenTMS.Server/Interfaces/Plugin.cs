using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenTMS.Server.Interfaces
{
    public abstract class Plugin
    {
        /// <summary>
        /// This property represents the name of the plugin
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// This property represents the author of the plugin
        /// </summary>
        public abstract string Author { get; }

        /// <summary>
        /// The website a user can visit for more information about the plugin.
        /// </summary>
        public abstract string Website { get; }

        /// <summary>
        /// A link to the repository for this plugin.
        /// </summary>
        public abstract string Repository { get; }

        /// <summary>
        /// The version of the plugin. This will be used during update checks
        /// </summary>
        public abstract string Version { get; }
    }
}
