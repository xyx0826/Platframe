using Newtonsoft.Json.Linq;
using System;

namespace WMLib.Utils
{
    /// <summary>
    /// Utilities for working with warframe.market JSON responses.
    /// </summary>
    internal static class Json
    {
        /// <summary>
        /// Strips the payload out of a warframe.market JSON response.
        /// <para/>
        /// The payload should not contain an error.
        /// </summary>
        /// <param name="response">A warframe.market JSON response.</param>
        /// <returns>The inner payload of the supplied response.</returns>
        internal static JToken StripPayload(JObject response)
        {
            if (!response.ContainsKey("payload"))
            {
                throw new ArgumentException("The supplied response does not have a payload.");
            }

            return response["payload"];
        }

        /// <summary>
        /// Checks a warframe.market JSON response for any errors.
        /// </summary>
        /// <param name="response">A warframe.market JSON response.</param>
        /// <param name="error">The error contained in the response, or <see cref="String.Empty"/> if none.</param>
        /// <returns>Whether the supplied response contains an error.</returns>
        internal static bool TryGetError(JObject response, out string error)
        {
            if (response.TryGetValue("error", out var errorToken))
            {
                // Has error
                error = errorToken.ToString();
                return true;
            }
            else
            {
                error = String.Empty;
                return false;
            }
        }
    }
}
