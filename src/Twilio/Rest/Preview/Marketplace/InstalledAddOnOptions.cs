using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Preview.Marketplace 
{

    public class CreateInstalledAddOnOptions : IOptions<InstalledAddOnResource> 
    {
        /// <summary>
        /// A string that uniquely identifies the Add-on to install
        /// </summary>
        public string AvailableAddOnSid { get; }
        /// <summary>
        /// The JSON object representing the configuration
        /// </summary>
        public object Configuration { get; set; }
        /// <summary>
        /// The string that uniquely identifies this Add-on installation
        /// </summary>
        public string UniqueName { get; set; }
    
        /// <summary>
        /// Construct a new CreateInstalledAddOnOptions
        /// </summary>
        ///
        /// <param name="availableAddOnSid"> A string that uniquely identifies the Add-on to install </param>
        public CreateInstalledAddOnOptions(string availableAddOnSid)
        {
            AvailableAddOnSid = availableAddOnSid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (AvailableAddOnSid != null)
            {
                p.Add(new KeyValuePair<string, string>("AvailableAddOnSid", AvailableAddOnSid.ToString()));
            }
            
            if (Configuration != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration", Configuration.ToString()));
            }
            
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            
            return p;
        }
    }

    public class DeleteInstalledAddOnOptions : IOptions<InstalledAddOnResource> 
    {
        /// <summary>
        /// The Installed Add-on Sid to delete
        /// </summary>
        public string Sid { get; }
    
        /// <summary>
        /// Construct a new DeleteInstalledAddOnOptions
        /// </summary>
        ///
        /// <param name="sid"> The Installed Add-on Sid to delete </param>
        public DeleteInstalledAddOnOptions(string sid)
        {
            Sid = sid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    public class FetchInstalledAddOnOptions : IOptions<InstalledAddOnResource> 
    {
        /// <summary>
        /// The unique Installed Add-on Sid
        /// </summary>
        public string Sid { get; }
    
        /// <summary>
        /// Construct a new FetchInstalledAddOnOptions
        /// </summary>
        ///
        /// <param name="sid"> The unique Installed Add-on Sid </param>
        public FetchInstalledAddOnOptions(string sid)
        {
            Sid = sid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    public class UpdateInstalledAddOnOptions : IOptions<InstalledAddOnResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string Sid { get; }
        /// <summary>
        /// The JSON object representing the configuration
        /// </summary>
        public object Configuration { get; set; }
        /// <summary>
        /// The string that uniquely identifies this Add-on installation
        /// </summary>
        public string UniqueName { get; set; }
    
        /// <summary>
        /// Construct a new UpdateInstalledAddOnOptions
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        public UpdateInstalledAddOnOptions(string sid)
        {
            Sid = sid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Configuration != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration", Configuration.ToString()));
            }
            
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            
            return p;
        }
    }

    public class ReadInstalledAddOnOptions : ReadOptions<InstalledAddOnResource> 
    {
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            
            return p;
        }
    }

}