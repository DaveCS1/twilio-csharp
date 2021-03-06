/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;
using Twilio.Types;

namespace Twilio.TwiML.Voice 
{

    /// <summary>
    /// Say TwiML Verb
    /// </summary>
    public class Say : TwiML 
    {
        public sealed class VoiceEnum : StringEnum 
        {
            private VoiceEnum(string value) : base(value) {}
            public VoiceEnum() {}
            public static implicit operator VoiceEnum(string value)
            {
                return new VoiceEnum(value);
            }

            public static readonly VoiceEnum Man = new VoiceEnum("man");
            public static readonly VoiceEnum Woman = new VoiceEnum("woman");
            public static readonly VoiceEnum Alice = new VoiceEnum("alice");
        }

        public sealed class LanguageEnum : StringEnum 
        {
            private LanguageEnum(string value) : base(value) {}
            public LanguageEnum() {}
            public static implicit operator LanguageEnum(string value)
            {
                return new LanguageEnum(value);
            }

            public static readonly LanguageEnum DaDk = new LanguageEnum("da-DK");
            public static readonly LanguageEnum DeDe = new LanguageEnum("de-DE");
            public static readonly LanguageEnum EnAu = new LanguageEnum("en-AU");
            public static readonly LanguageEnum EnCa = new LanguageEnum("en-CA");
            public static readonly LanguageEnum EnGb = new LanguageEnum("en-GB");
            public static readonly LanguageEnum EnIn = new LanguageEnum("en-IN");
            public static readonly LanguageEnum EnUs = new LanguageEnum("en-US");
            public static readonly LanguageEnum CaEs = new LanguageEnum("ca-ES");
            public static readonly LanguageEnum EsEs = new LanguageEnum("es-ES");
            public static readonly LanguageEnum EsMx = new LanguageEnum("es-MX");
            public static readonly LanguageEnum FiFi = new LanguageEnum("fi-FI");
            public static readonly LanguageEnum FrCa = new LanguageEnum("fr-CA");
            public static readonly LanguageEnum FrFr = new LanguageEnum("fr-FR");
            public static readonly LanguageEnum ItIt = new LanguageEnum("it-IT");
            public static readonly LanguageEnum JaJp = new LanguageEnum("ja-JP");
            public static readonly LanguageEnum KoKr = new LanguageEnum("ko-KR");
            public static readonly LanguageEnum NbNo = new LanguageEnum("nb-NO");
            public static readonly LanguageEnum NlNl = new LanguageEnum("nl-NL");
            public static readonly LanguageEnum PlPl = new LanguageEnum("pl-PL");
            public static readonly LanguageEnum PtBr = new LanguageEnum("pt-BR");
            public static readonly LanguageEnum PtPt = new LanguageEnum("pt-PT");
            public static readonly LanguageEnum RuRu = new LanguageEnum("ru-RU");
            public static readonly LanguageEnum SvSe = new LanguageEnum("sv-SE");
            public static readonly LanguageEnum ZhCn = new LanguageEnum("zh-CN");
            public static readonly LanguageEnum ZhHk = new LanguageEnum("zh-HK");
            public static readonly LanguageEnum ZhTw = new LanguageEnum("zh-TW");
        }

        /// <summary>
        /// Message to say
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Voice to use
        /// </summary>
        public Say.VoiceEnum Voice { get; set; }
        /// <summary>
        /// Times to loop message
        /// </summary>
        public int? Loop { get; set; }
        /// <summary>
        /// Message langauge
        /// </summary>
        public Say.LanguageEnum Language { get; set; }

        /// <summary>
        /// Create a new Say
        /// </summary>
        /// <param name="message"> Message to say, the body of the TwiML Element. </param>
        /// <param name="voice"> Voice to use </param>
        /// <param name="loop"> Times to loop message </param>
        /// <param name="language"> Message langauge </param>
        public Say(string message = null, 
                   Say.VoiceEnum voice = null, 
                   int? loop = null, 
                   Say.LanguageEnum language = null) : base("Say")
        {
            this.Message = message;
            this.Voice = voice;
            this.Loop = loop;
            this.Language = language;
        }

        /// <summary>
        /// Return the body of the TwiML tag
        /// </summary>
        protected override string GetElementBody()
        {
            return this.Message != null ? this.Message : string.Empty;
        }

        /// <summary>
        /// Return the attributes of the TwiML tag
        /// </summary>
        protected override List<XAttribute> GetElementAttributes()
        {
            var attributes = new List<XAttribute>();
            if (this.Voice != null)
            {
                attributes.Add(new XAttribute("voice", this.Voice.ToString()));
            }
            if (this.Loop != null)
            {
                attributes.Add(new XAttribute("loop", this.Loop.Value.ToString()));
            }
            if (this.Language != null)
            {
                attributes.Add(new XAttribute("language", this.Language.ToString()));
            }
            return attributes;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new Say Append(TwiML childElem)
        {
            return (Say) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new Say SetOption(string key, object value)
        {
            return (Say) base.SetOption(key, value);
        }
    }

}