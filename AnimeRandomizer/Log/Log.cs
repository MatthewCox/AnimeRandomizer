using System.IO;

namespace AnimeRandomizer.Log
{
    /// <summary>
    /// A class to handle the logging of errors
    /// </summary>
    public static class Log
    {
        /// <summary>
        /// Writes a message to the specified log file
        /// </summary>
        /// <param name="p_logfileLocation">The log file to write to</param>
        /// <param name="p_errorToLog">The string to write to the log file</param>
        public static void Write(string p_logfileLocation, string p_errorToLog)
        {
            StreamWriter logfile = new StreamWriter(p_logfileLocation);

            logfile.WriteLine(p_errorToLog);

            logfile.Close();
        }
    }
}
