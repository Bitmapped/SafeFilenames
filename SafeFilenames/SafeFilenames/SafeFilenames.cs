using System.IO;

namespace SafeFilenames
{
    static public class SafeFilenames
    {
        /// <summary>
        /// Gets a safe version of the string for use in a filename.
        /// </summary>
        /// <param name="filename">Filename to sanitize.</param>
        /// <param name="replacement">String to use to replace invalid characters.</param>
        /// <returns>Safe filename.</returns>
        static public string GetSafeFilename(string filename, string replacement = "_")
        {
            // Solution from http://stackoverflow.com/questions/2230826/remove-invalid-disallowed-bad-characters-from-filename-or-directory-folder
            // CC-BY-SA 3.0 license
            return string.Join("_", filename.Split(Path.GetInvalidFileNameChars()));
        }
    }
}