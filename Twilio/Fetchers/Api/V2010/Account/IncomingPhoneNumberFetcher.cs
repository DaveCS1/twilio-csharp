using System.Threading.Tasks;
using Twilio.Clients;
using Twilio.Exceptions;
using Twilio.Fetchers;
using Twilio.Http;
using Twilio.Resources.Api.V2010.Account;

namespace Twilio.Fetchers.Api.V2010.Account {

    public class IncomingPhoneNumberFetcher : Fetcher<IncomingPhoneNumberResource> {
        private string ownerAccountSid;
        private string sid;
    
        /**
         * Construct a new IncomingPhoneNumberFetcher
         * 
         * @param ownerAccountSid The owner_account_sid
         * @param sid Fetch by unique incoming-phone-number Sid
         */
        public IncomingPhoneNumberFetcher(string ownerAccountSid, string sid) {
            this.ownerAccountSid = ownerAccountSid;
            this.sid = sid;
        }
    
        /**
         * Make the request to the Twilio API to perform the fetch
         * 
         * @param client TwilioRestClient with which to make the request
         * @return Fetched IncomingPhoneNumberResource
         */
        public override async Task<IncomingPhoneNumberResource> execute(TwilioRestClient client) {
            Request request = new Request(
                System.Net.Http.HttpMethod.Get,
                TwilioRestClient.Domains.API,
                "/2010-04-01/Accounts/" + this.ownerAccountSid + "/IncomingPhoneNumbers/" + this.sid + ".json"
            );
            
            Response response = await client.request(request);
            
            if (response == null) {
                throw new ApiConnectionException("IncomingPhoneNumberResource fetch failed: Unable to connect to server");
            } else if (response.GetStatusCode() != TwilioRestClient.HTTP_STATUS_CODE_OK) {
                RestException restException = RestException.FromJson(response.GetContent());
                if (restException == null)
                    throw new ApiException("Server Error, no content");
                throw new ApiException(
                    restException.GetMessage(),
                    restException.GetCode(),
                    restException.GetMoreInfo(),
                    restException.GetStatus(),
                    null
                );
            }
            
            return IncomingPhoneNumberResource.FromJson(response.GetContent());
        }
    }
}