using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandLine
{
    /// <summary>
    /// A ordered verb list contains a sequence of parsed nested verb instances.
    /// </summary>
    /// <typeparam name="TRoot">The type of top level verb (first in command line)</typeparam>
    public class VerbPath<TRoot> : List<object> 
    {
        /// <summary>
        /// Gets the top level verb instance
        /// </summary>
        public TRoot Root
        {
            get
            {
                return (TRoot)(Count > 0 ? this[0] : null);
            }
        }

        /// <summary>
        /// Gets the last verb instance
        /// </summary>
        public object Last
        {
            get
            {
                return Count > 0 ? this[Count - 1] : null;
            }
        }
    }
}
