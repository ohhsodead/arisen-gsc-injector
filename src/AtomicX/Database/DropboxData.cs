using AtomicX.Constants;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AtomicX.Database
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

        public DropboxData()
        {
            GscMultiplayerPS3 = GetGscMultiplayerDataPS3();
            GscZombiesPS3 = GetGscZombiesDataPS3();

            GscMultiplayerXBOX = GetGscMultiplayerDataXBOX();
            GscZombiesXBOX = GetGscZombiesDataXBOX();

            Mods = GetModsData();
        }

        /// <summary>
        ///     Download and return the GSC multiplayer dump data.
        /// </summary>
        /// <returns></returns>
        internal static GscData GetGscMultiplayerDataPS3()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync(Urls.PS3_GSC_MP).Result)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new Exception($"Bad response {response.StatusCode}");
                    }

                    string responseData = response.Content.ReadAsStringAsync().Result;

                    if (IsValidJson(responseData))
                    {
                        return JsonConvert.DeserializeObject<GscData>(responseData);
                    }

                    dynamic data = JsonConvert.DeserializeObject(responseData);

                    throw new Exception(data.data.Message.ToString());
                }
            }
        }

        /// <summary>
        ///     Download and return the GSC zombies dump data.
        /// </summary>
        /// <returns></returns>
        internal static GscData GetGscZombiesDataPS3()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync(Urls.PS3_GSC_ZM).Result)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new Exception($"Bad response {response.StatusCode}");
                    }

                    string responseData = response.Content.ReadAsStringAsync().Result;

                    if (IsValidJson(responseData))
                    {
                        return JsonConvert.DeserializeObject<GscData>(responseData);
                    }

                    dynamic data = JsonConvert.DeserializeObject(responseData);

                    throw new Exception(data.data.Message.ToString());
                }
            }
        }

        /// <summary>
        ///     Download and return the GSC multiplayer dump data.
        /// </summary>
        /// <returns></returns>
        internal static GscData GetGscMultiplayerDataXBOX()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync(Urls.XBOX_GSC_MP).Result)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new Exception($"Bad response {response.StatusCode}");
                    }

                    string responseData = response.Content.ReadAsStringAsync().Result;

                    if (IsValidJson(responseData))
                    {
                        return JsonConvert.DeserializeObject<GscData>(responseData);
                    }

                    dynamic data = JsonConvert.DeserializeObject(responseData);

                    throw new Exception(data.data.Message.ToString());
                }
            }
        }

        /// <summary>
        ///     Download and return the GSC zombies dump data.
        /// </summary>
        /// <returns></returns>
        internal static GscData GetGscZombiesDataXBOX()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync(Urls.XBOX_GSC_ZM).Result)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new Exception($"Bad response {response.StatusCode}");
                    }

                    string responseData = response.Content.ReadAsStringAsync().Result;

                    if (IsValidJson(responseData))
                    {
                        return JsonConvert.DeserializeObject<GscData>(responseData);
                    }

                    dynamic data = JsonConvert.DeserializeObject(responseData);

                    throw new Exception(data.data.Message.ToString());
                }
            }
        }

        /// <summary>
        ///     Download and return the GSC mods data.
        /// </summary>
        /// <returns></returns>
        internal static ModsData GetModsData()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync(Urls.GSC_MODS).Result)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new Exception($"Bad response {response.StatusCode}");
                    }

                    string responseData = response.Content.ReadAsStringAsync().Result;

                    if (IsValidJson(responseData))
                    {
                        return JsonConvert.DeserializeObject<ModsData>(responseData);
                    }

                    dynamic data = JsonConvert.DeserializeObject(responseData);

                    throw new Exception(data.data.Message.ToString());
                }
            }
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
                var unused = JToken.Parse(data);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}