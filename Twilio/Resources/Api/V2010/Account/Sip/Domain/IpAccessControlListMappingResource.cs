using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Creators.Api.V2010.Account.Sip.Domain;
using Twilio.Deleters.Api.V2010.Account.Sip.Domain;
using Twilio.Exceptions;
using Twilio.Fetchers.Api.V2010.Account.Sip.Domain;
using Twilio.Http;
using Twilio.Readers.Api.V2010.Account.Sip.Domain;
using Twilio.Resources;

namespace Twilio.Resources.Api.V2010.Account.Sip.Domain {

    public class IpAccessControlListMappingResource : SidResource {
        /**
         * fetch
         * 
         * @param accountSid The account_sid
         * @param domainSid The domain_sid
         * @param sid The sid
         * @return IpAccessControlListMappingFetcher capable of executing the fetch
         */
        public static IpAccessControlListMappingFetcher fetch(string accountSid, string domainSid, string sid) {
            return new IpAccessControlListMappingFetcher(accountSid, domainSid, sid);
        }
    
        /**
         * create
         * 
         * @param accountSid The account_sid
         * @param domainSid The domain_sid
         * @param ipAccessControlListSid The ip_access_control_list_sid
         * @return IpAccessControlListMappingCreator capable of executing the create
         */
        public static IpAccessControlListMappingCreator create(string accountSid, string domainSid, string ipAccessControlListSid) {
            return new IpAccessControlListMappingCreator(accountSid, domainSid, ipAccessControlListSid);
        }
    
        /**
         * read
         * 
         * @param accountSid The account_sid
         * @param domainSid The domain_sid
         * @return IpAccessControlListMappingReader capable of executing the read
         */
        public static IpAccessControlListMappingReader read(string accountSid, string domainSid) {
            return new IpAccessControlListMappingReader(accountSid, domainSid);
        }
    
        /**
         * delete
         * 
         * @param accountSid The account_sid
         * @param domainSid The domain_sid
         * @param sid The sid
         * @return IpAccessControlListMappingDeleter capable of executing the delete
         */
        public static IpAccessControlListMappingDeleter delete(string accountSid, string domainSid, string sid) {
            return new IpAccessControlListMappingDeleter(accountSid, domainSid, sid);
        }
    
        /**
         * Converts a JSON string into a IpAccessControlListMappingResource object
         * 
         * @param json Raw JSON string
         * @return IpAccessControlListMappingResource object represented by the
         *         provided JSON
         */
        public static IpAccessControlListMappingResource FromJson(string json) {
            // Convert all checked exceptions to Runtime
            try {
                return JsonConvert.DeserializeObject<IpAccessControlListMappingResource>(json);
            } catch (JsonException e) {
                throw new ApiException(e.Message, e);
            }
        }
    
        [JsonProperty("account_sid")]
        private readonly string accountSid;
        [JsonProperty("date_created")]
        private readonly DateTime dateCreated;
        [JsonProperty("date_updated")]
        private readonly DateTime dateUpdated;
        [JsonProperty("friendly_name")]
        private readonly string friendlyName;
        [JsonProperty("sid")]
        private readonly string sid;
        [JsonProperty("uri")]
        private readonly string uri;
    
        private IpAccessControlListMappingResource([JsonProperty("account_sid")]
                                                   string accountSid, 
                                                   [JsonProperty("date_created")]
                                                   string dateCreated, 
                                                   [JsonProperty("date_updated")]
                                                   string dateUpdated, 
                                                   [JsonProperty("friendly_name")]
                                                   string friendlyName, 
                                                   [JsonProperty("sid")]
                                                   string sid, 
                                                   [JsonProperty("uri")]
                                                   string uri) {
            this.accountSid = accountSid;
            this.dateCreated = MarshalConverter.DateTimeFromString(dateCreated);
            this.dateUpdated = MarshalConverter.DateTimeFromString(dateUpdated);
            this.friendlyName = friendlyName;
            this.sid = sid;
            this.uri = uri;
        }
    
        /**
         * @return The account_sid
         */
        public string GetAccountSid() {
            return this.accountSid;
        }
    
        /**
         * @return The date_created
         */
        public DateTime GetDateCreated() {
            return this.dateCreated;
        }
    
        /**
         * @return The date_updated
         */
        public DateTime GetDateUpdated() {
            return this.dateUpdated;
        }
    
        /**
         * @return The friendly_name
         */
        public string GetFriendlyName() {
            return this.friendlyName;
        }
    
        /**
         * @return The sid
         */
        public override string GetSid() {
            return this.sid;
        }
    
        /**
         * @return The uri
         */
        public string GetUri() {
            return this.uri;
        }
    }
}