using System.Reflection;

namespace WMLib.Utils
{
    internal static class App
    {
        /// <summary>
        /// Gets the version of the entry assembly.
        /// </summary>
        /// <returns></returns>
        internal static string GetAppVersion()
            => Assembly.GetEntryAssembly().GetName().Version.ToString();
    }
}
