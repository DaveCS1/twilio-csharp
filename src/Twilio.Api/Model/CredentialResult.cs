﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Twilio
{
    public class CredentialResult : TwilioListBase
    {
        public List<Credential> Credentials { get; set; }
    }
}
