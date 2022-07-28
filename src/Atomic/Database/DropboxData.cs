using Atomic.Constants;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Atomic.Database
{
    public class DropboxData
    {
        /// <summary>
        /// Stores the gsc files data for Multiplayer (PS3); File Path, Pointer, Buffer & Size
        /// </summary>
        public GscData GscMultiplayerPS3 { get; private set; }

        /// <summary>
        /// Stores the gsc files data for Zombies (PS3); File Path, Pointer, Buffer & Size
        /// </summary>
        public GscData GscZombiesPS3 { get; private set; }

        /// <summary>
        /// Stores the gsc files data for Multiplayer (XBOX); File Path, Pointer, Buffer & Size
        /// </summary>
        public GscData GscMultiplayerXBOX { get; private set; }

        /// <summary>
        /// Stores the gsc files data for Zombies (XBOX); File Path, Pointer, Buffer & Size
        /// </summary>
        public GscData GscZombiesXBOX { get; private set; }

        /// <summary>
        /// Contains all the mods
        /// </summary>
        public ModsData Mods { get; private set; }

        public static async Task<DropboxData> InitializeAsync()
        {
            DropboxData data = new()
            {
                GscMultiplayerPS3 = await GetGscMultiplayerDataPS3(),
                GscZombiesPS3 = await GetGscZombiesDataPS3(),

                GscMultiplayerXBOX = await GetGscMultiplayerDataXBOX(),
                GscZombiesXBOX = await GetGscZombiesDataXBOX(),

                Mods = await GetModsData()
            };

            return data;
        }

        /// <summary>
        ///     Download and return the GSC multiplayer dump data.
        /// </summary>
        /// <returns></returns>
        internal static async Task<GscData> GetGscMultiplayerDataPS3()
        {
            using HttpClient client = new();
            using HttpResponseMessage response = client.GetAsync(Urls.PS3_GSC_MP).Result;

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception($"Bad response {response.StatusCode}");
            }

            string responseData = await response.Content.ReadAsStringAsync();

            if (!IsValidJson(responseData))
                throw new JsonException("Failed to process the data for the Multiplayer GSC PS3.");

            return JsonConvert.DeserializeObject<GscData>(responseData);
        }

        /// <summary>
        ///     Download and return the GSC zombies dump data.
        /// </summary>
        /// <returns></returns>
        internal static async Task<GscData> GetGscZombiesDataPS3()
        {
            using HttpClient client = new();
            using HttpResponseMessage response = client.GetAsync(Urls.PS3_GSC_ZM).Result;

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception($"Bad response {response.StatusCode}");
            }

            string responseData = await response.Content.ReadAsStringAsync();

            if (!IsValidJson(responseData))
                throw new JsonException("Failed to process the data for the Zombies GSC PS3.");

            return JsonConvert.DeserializeObject<GscData>(responseData);
        }

        /// <summary>
        ///     Download and return the GSC multiplayer dump data.
        /// </summary>
        /// <returns></returns>
        internal static async Task<GscData> GetGscMultiplayerDataXBOX()
        {
            using HttpClient client = new();
            using HttpResponseMessage response = client.GetAsync(Urls.XBOX_GSC_MP).Result;

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception($"Bad response {response.StatusCode}");
            }

            string responseData = await response.Content.ReadAsStringAsync();

            if (!IsValidJson(responseData))
                throw new JsonException("Failed to process the data for the Multiplayer GSC XBOX.");

            return JsonConvert.DeserializeObject<GscData>(responseData);
        }

        /// <summary>
        ///     Download and return the GSC zombies dump data.
        /// </summary>
        /// <returns></returns>
        internal static async Task<GscData> GetGscZombiesDataXBOX()
        {
            using HttpClient client = new();
            using HttpResponseMessage response = client.GetAsync(Urls.XBOX_GSC_ZM).Result;

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception($"Bad response {response.StatusCode}");
            }

            string responseData = await response.Content.ReadAsStringAsync();

            if (!IsValidJson(responseData))
                throw new JsonException("Failed to process the data for the Zombies GSC XBOX.");

            return JsonConvert.DeserializeObject<GscData>(responseData);
        }

        /// <summary>
        ///     Download and return the GSC mods data.
        /// </summary>
        /// <returns></returns>
        internal static async Task<ModsData> GetModsData()
        {
            using HttpClient client = new();
            using HttpResponseMessage response = client.GetAsync(Urls.GSC_MODS).Result;

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception($"Bad response {response.StatusCode}");
            }

            string responseData = await response.Content.ReadAsStringAsync();

            if (!IsValidJson(responseData))
                throw new JsonException("Failed to process the data for the Multiplayer GSC XBOX.");

            return JsonConvert.DeserializeObject<ModsData>(responseData);
        }

        /// <summary>
        ///     Determines a valid json response.
        /// </summary>
        /// <param name="data">Json data to validate</param>
        /// <returns>Whether text is valid json format</returns>
        private static bool IsValidJson(string data)
        {
            try
            {
                JToken unused = JToken.Parse(data);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}