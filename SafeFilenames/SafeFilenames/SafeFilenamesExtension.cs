using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SafeFilenames
{
    static public class SafeFilenamesExtension
    {
        /// <summary>
        /// Gets a safe version of the string for use in a filename.
        /// </summary>
        /// <param name="filename">Filename to sanitize.</param>
        /// <param name="replacement">String to use to replace invalid characters.</param>
        /// <returns>Safe filename.</returns>
        static public string GetSafeFilename(this string filename, string replacement = "_")
        {
            return SafeFilenames.GetSafeFilename(filename, replacement);
        }

    }
}
