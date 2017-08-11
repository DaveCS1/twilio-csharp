/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
/// 
/// SimResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Wireless.V1 
{

    public class SimResource : Resource 
    {
        public sealed class StatusEnum : StringEnum 
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}

            public static readonly StatusEnum New = new StatusEnum("new");
            public static readonly StatusEnum Ready = new StatusEnum("ready");
            public static readonly StatusEnum Active = new StatusEnum("active");
            public static readonly StatusEnum Suspended = new StatusEnum("suspended");
            public static readonly StatusEnum Deactivated = new StatusEnum("deactivated");
            public static readonly StatusEnum Canceled = new StatusEnum("canceled");
            public static readonly StatusEnum Scheduled = new StatusEnum("scheduled");
            public static readonly StatusEnum Updating = new StatusEnum("updating");
        }

        private static Request BuildFetchRequest(FetchSimOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Wireless,
                "/v1/Sims/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch Sim parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sim </returns> 
        public static SimResource Fetch(FetchSimOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch Sim parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sim </returns> 
        public static async System.Threading.Tasks.Task<SimResource> FetchAsync(FetchSimOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sim </returns> 
        public static SimResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchSimOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sim </returns> 
        public static async System.Threading.Tasks.Task<SimResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchSimOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadSimOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Wireless,
                "/v1/Sims",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Sim parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sim </returns> 
        public static ResourceSet<SimResource> Read(ReadSimOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<SimResource>.FromJson("sims", response.Content);
            return new ResourceSet<SimResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Sim parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sim </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<SimResource>> ReadAsync(ReadSimOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<SimResource>.FromJson("sims", response.Content);
            return new ResourceSet<SimResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="status"> The status </param>
        /// <param name="iccid"> The iccid </param>
        /// <param name="ratePlan"> The rate_plan </param>
        /// <param name="eId"> The e_id </param>
        /// <param name="simRegistrationCode"> The sim_registration_code </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sim </returns> 
        public static ResourceSet<SimResource> Read(SimResource.StatusEnum status = null, string iccid = null, string ratePlan = null, string eId = null, string simRegistrationCode = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadSimOptions{Status = status, Iccid = iccid, RatePlan = ratePlan, EId = eId, SimRegistrationCode = simRegistrationCode, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="status"> The status </param>
        /// <param name="iccid"> The iccid </param>
        /// <param name="ratePlan"> The rate_plan </param>
        /// <param name="eId"> The e_id </param>
        /// <param name="simRegistrationCode"> The sim_registration_code </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sim </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<SimResource>> ReadAsync(SimResource.StatusEnum status = null, string iccid = null, string ratePlan = null, string eId = null, string simRegistrationCode = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadSimOptions{Status = status, Iccid = iccid, RatePlan = ratePlan, EId = eId, SimRegistrationCode = simRegistrationCode, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        ///
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<SimResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<SimResource>.FromJson("sims", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<SimResource> NextPage(Page<SimResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Wireless,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<SimResource>.FromJson("sims", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<SimResource> PreviousPage(Page<SimResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Wireless,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<SimResource>.FromJson("sims", response.Content);
        }

        private static Request BuildUpdateRequest(UpdateSimOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Wireless,
                "/v1/Sims/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update Sim parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sim </returns> 
        public static SimResource Update(UpdateSimOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update Sim parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sim </returns> 
        public static async System.Threading.Tasks.Task<SimResource> UpdateAsync(UpdateSimOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="uniqueName"> The unique_name </param>
        /// <param name="callbackMethod"> The callback_method </param>
        /// <param name="callbackUrl"> The callback_url </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="ratePlan"> The rate_plan </param>
        /// <param name="status"> The status </param>
        /// <param name="commandsCallbackMethod"> The commands_callback_method </param>
        /// <param name="commandsCallbackUrl"> The commands_callback_url </param>
        /// <param name="smsFallbackMethod"> The sms_fallback_method </param>
        /// <param name="smsFallbackUrl"> The sms_fallback_url </param>
        /// <param name="smsMethod"> The sms_method </param>
        /// <param name="smsUrl"> The sms_url </param>
        /// <param name="voiceFallbackMethod"> The voice_fallback_method </param>
        /// <param name="voiceFallbackUrl"> The voice_fallback_url </param>
        /// <param name="voiceMethod"> The voice_method </param>
        /// <param name="voiceUrl"> The voice_url </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sim </returns> 
        public static SimResource Update(string pathSid, string uniqueName = null, Twilio.Http.HttpMethod callbackMethod = null, Uri callbackUrl = null, string friendlyName = null, string ratePlan = null, SimResource.StatusEnum status = null, Twilio.Http.HttpMethod commandsCallbackMethod = null, Uri commandsCallbackUrl = null, Twilio.Http.HttpMethod smsFallbackMethod = null, Uri smsFallbackUrl = null, Twilio.Http.HttpMethod smsMethod = null, Uri smsUrl = null, Twilio.Http.HttpMethod voiceFallbackMethod = null, Uri voiceFallbackUrl = null, Twilio.Http.HttpMethod voiceMethod = null, Uri voiceUrl = null, ITwilioRestClient client = null)
        {
            var options = new UpdateSimOptions(pathSid){UniqueName = uniqueName, CallbackMethod = callbackMethod, CallbackUrl = callbackUrl, FriendlyName = friendlyName, RatePlan = ratePlan, Status = status, CommandsCallbackMethod = commandsCallbackMethod, CommandsCallbackUrl = commandsCallbackUrl, SmsFallbackMethod = smsFallbackMethod, SmsFallbackUrl = smsFallbackUrl, SmsMethod = smsMethod, SmsUrl = smsUrl, VoiceFallbackMethod = voiceFallbackMethod, VoiceFallbackUrl = voiceFallbackUrl, VoiceMethod = voiceMethod, VoiceUrl = voiceUrl};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="uniqueName"> The unique_name </param>
        /// <param name="callbackMethod"> The callback_method </param>
        /// <param name="callbackUrl"> The callback_url </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="ratePlan"> The rate_plan </param>
        /// <param name="status"> The status </param>
        /// <param name="commandsCallbackMethod"> The commands_callback_method </param>
        /// <param name="commandsCallbackUrl"> The commands_callback_url </param>
        /// <param name="smsFallbackMethod"> The sms_fallback_method </param>
        /// <param name="smsFallbackUrl"> The sms_fallback_url </param>
        /// <param name="smsMethod"> The sms_method </param>
        /// <param name="smsUrl"> The sms_url </param>
        /// <param name="voiceFallbackMethod"> The voice_fallback_method </param>
        /// <param name="voiceFallbackUrl"> The voice_fallback_url </param>
        /// <param name="voiceMethod"> The voice_method </param>
        /// <param name="voiceUrl"> The voice_url </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sim </returns> 
        public static async System.Threading.Tasks.Task<SimResource> UpdateAsync(string pathSid, string uniqueName = null, Twilio.Http.HttpMethod callbackMethod = null, Uri callbackUrl = null, string friendlyName = null, string ratePlan = null, SimResource.StatusEnum status = null, Twilio.Http.HttpMethod commandsCallbackMethod = null, Uri commandsCallbackUrl = null, Twilio.Http.HttpMethod smsFallbackMethod = null, Uri smsFallbackUrl = null, Twilio.Http.HttpMethod smsMethod = null, Uri smsUrl = null, Twilio.Http.HttpMethod voiceFallbackMethod = null, Uri voiceFallbackUrl = null, Twilio.Http.HttpMethod voiceMethod = null, Uri voiceUrl = null, ITwilioRestClient client = null)
        {
            var options = new UpdateSimOptions(pathSid){UniqueName = uniqueName, CallbackMethod = callbackMethod, CallbackUrl = callbackUrl, FriendlyName = friendlyName, RatePlan = ratePlan, Status = status, CommandsCallbackMethod = commandsCallbackMethod, CommandsCallbackUrl = commandsCallbackUrl, SmsFallbackMethod = smsFallbackMethod, SmsFallbackUrl = smsFallbackUrl, SmsMethod = smsMethod, SmsUrl = smsUrl, VoiceFallbackMethod = voiceFallbackMethod, VoiceFallbackUrl = voiceFallbackUrl, VoiceMethod = voiceMethod, VoiceUrl = voiceUrl};
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a SimResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SimResource object represented by the provided JSON </returns> 
        public static SimResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<SimResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The unique_name
        /// </summary>
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }
        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The rate_plan_sid
        /// </summary>
        [JsonProperty("rate_plan_sid")]
        public string RatePlanSid { get; private set; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The iccid
        /// </summary>
        [JsonProperty("iccid")]
        public string Iccid { get; private set; }
        /// <summary>
        /// The e_id
        /// </summary>
        [JsonProperty("e_id")]
        public string EId { get; private set; }
        /// <summary>
        /// The status
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SimResource.StatusEnum Status { get; private set; }
        /// <summary>
        /// The commands_callback_url
        /// </summary>
        [JsonProperty("commands_callback_url")]
        public Uri CommandsCallbackUrl { get; private set; }
        /// <summary>
        /// The commands_callback_method
        /// </summary>
        [JsonProperty("commands_callback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod CommandsCallbackMethod { get; private set; }
        /// <summary>
        /// The sms_fallback_method
        /// </summary>
        [JsonProperty("sms_fallback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod SmsFallbackMethod { get; private set; }
        /// <summary>
        /// The sms_fallback_url
        /// </summary>
        [JsonProperty("sms_fallback_url")]
        public Uri SmsFallbackUrl { get; private set; }
        /// <summary>
        /// The sms_method
        /// </summary>
        [JsonProperty("sms_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod SmsMethod { get; private set; }
        /// <summary>
        /// The sms_url
        /// </summary>
        [JsonProperty("sms_url")]
        public Uri SmsUrl { get; private set; }
        /// <summary>
        /// The voice_fallback_method
        /// </summary>
        [JsonProperty("voice_fallback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod VoiceFallbackMethod { get; private set; }
        /// <summary>
        /// The voice_fallback_url
        /// </summary>
        [JsonProperty("voice_fallback_url")]
        public Uri VoiceFallbackUrl { get; private set; }
        /// <summary>
        /// The voice_method
        /// </summary>
        [JsonProperty("voice_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod VoiceMethod { get; private set; }
        /// <summary>
        /// The voice_url
        /// </summary>
        [JsonProperty("voice_url")]
        public Uri VoiceUrl { get; private set; }
        /// <summary>
        /// The date_created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date_updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The links
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private SimResource()
        {

        }
    }

}