﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YandexSpeller
{


    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://speller.yandex.net/services/spellservice", ConfigurationName = "YandexSpeller.SpellServiceSoap")]
    public interface SpellServiceSoap
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://speller.yandex.net/services/spellservice/checkText", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<YandexSpeller.checkTextResponse1> checkTextAsync(YandexSpeller.checkTextRequest1 request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://speller.yandex.net/services/spellservice/checkTexts", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<YandexSpeller.checkTextsResponse1> checkTextsAsync(YandexSpeller.checkTextsRequest1 request);
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://speller.yandex.net/services/spellservice")]
    public partial class CheckTextRequest
    {

        private string textField;

        private string langField;

        private int optionsField;

        private string formatField;

        public CheckTextRequest()
        {
            this.optionsField = 0;
            this.formatField = "";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int options
        {
            get
            {
                return this.optionsField;
            }
            set
            {
                this.optionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://speller.yandex.net/services/spellservice")]
    public partial class SpellError
    {

        private string wordField;

        private string[] sField;

        private int codeField;

        private int posField;

        private int rowField;

        private int colField;

        private int lenField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string word
        {
            get
            {
                return this.wordField;
            }
            set
            {
                this.wordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("s", Order = 1)]
        public string[] s
        {
            get
            {
                return this.sField;
            }
            set
            {
                this.sField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pos
        {
            get
            {
                return this.posField;
            }
            set
            {
                this.posField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int row
        {
            get
            {
                return this.rowField;
            }
            set
            {
                this.rowField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int col
        {
            get
            {
                return this.colField;
            }
            set
            {
                this.colField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int len
        {
            get
            {
                return this.lenField;
            }
            set
            {
                this.lenField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://speller.yandex.net/services/spellservice")]
    public partial class CheckTextResponse
    {

        private SpellError[] spellResultField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("error", IsNullable = false)]
        public SpellError[] SpellResult
        {
            get
            {
                return this.spellResultField;
            }
            set
            {
                this.spellResultField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class checkTextRequest1
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://speller.yandex.net/services/spellservice", Order = 0)]
        public YandexSpeller.CheckTextRequest CheckTextRequest;

        public checkTextRequest1()
        {
        }

        public checkTextRequest1(YandexSpeller.CheckTextRequest CheckTextRequest)
        {
            this.CheckTextRequest = CheckTextRequest;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class checkTextResponse1
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://speller.yandex.net/services/spellservice", Order = 0)]
        public YandexSpeller.CheckTextResponse CheckTextResponse;

        public checkTextResponse1()
        {
        }

        public checkTextResponse1(YandexSpeller.CheckTextResponse CheckTextResponse)
        {
            this.CheckTextResponse = CheckTextResponse;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://speller.yandex.net/services/spellservice")]
    public partial class CheckTextsRequest
    {

        private string[] textField;

        private string langField;

        private int optionsField;

        private string formatField;

        public CheckTextsRequest()
        {
            this.optionsField = 0;
            this.formatField = "";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("text", Order = 0)]
        public string[] text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int options
        {
            get
            {
                return this.optionsField;
            }
            set
            {
                this.optionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://speller.yandex.net/services/spellservice")]
    public partial class CheckTextsResponse
    {

        private SpellError[][] arrayOfSpellResultField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("SpellResult", IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("error", IsNullable = false, NestingLevel = 1)]
        public SpellError[][] ArrayOfSpellResult
        {
            get
            {
                return this.arrayOfSpellResultField;
            }
            set
            {
                this.arrayOfSpellResultField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class checkTextsRequest1
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://speller.yandex.net/services/spellservice", Order = 0)]
        public YandexSpeller.CheckTextsRequest CheckTextsRequest;

        public checkTextsRequest1()
        {
        }

        public checkTextsRequest1(YandexSpeller.CheckTextsRequest CheckTextsRequest)
        {
            this.CheckTextsRequest = CheckTextsRequest;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class checkTextsResponse1
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://speller.yandex.net/services/spellservice", Order = 0)]
        public YandexSpeller.CheckTextsResponse CheckTextsResponse;

        public checkTextsResponse1()
        {
        }

        public checkTextsResponse1(YandexSpeller.CheckTextsResponse CheckTextsResponse)
        {
            this.CheckTextsResponse = CheckTextsResponse;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    public interface SpellServiceSoapChannel : YandexSpeller.SpellServiceSoap, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    public partial class SpellServiceSoapClient : System.ServiceModel.ClientBase<YandexSpeller.SpellServiceSoap>, YandexSpeller.SpellServiceSoap
    {

        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);

        public SpellServiceSoapClient(EndpointConfiguration endpointConfiguration) :
                base(SpellServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), SpellServiceSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public SpellServiceSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) :
                base(SpellServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public SpellServiceSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) :
                base(SpellServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public SpellServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<YandexSpeller.checkTextResponse1> YandexSpeller.SpellServiceSoap.checkTextAsync(YandexSpeller.checkTextRequest1 request)
        {
            return base.Channel.checkTextAsync(request);
        }

        public System.Threading.Tasks.Task<YandexSpeller.checkTextResponse1> checkTextAsync(YandexSpeller.CheckTextRequest CheckTextRequest)
        {
            YandexSpeller.checkTextRequest1 inValue = new YandexSpeller.checkTextRequest1();
            inValue.CheckTextRequest = CheckTextRequest;
            return ((YandexSpeller.SpellServiceSoap)(this)).checkTextAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<YandexSpeller.checkTextsResponse1> YandexSpeller.SpellServiceSoap.checkTextsAsync(YandexSpeller.checkTextsRequest1 request)
        {
            return base.Channel.checkTextsAsync(request);
        }

        public System.Threading.Tasks.Task<YandexSpeller.checkTextsResponse1> checkTextsAsync(YandexSpeller.CheckTextsRequest CheckTextsRequest)
        {
            YandexSpeller.checkTextsRequest1 inValue = new YandexSpeller.checkTextsRequest1();
            inValue.CheckTextsRequest = CheckTextsRequest;
            return ((YandexSpeller.SpellServiceSoap)(this)).checkTextsAsync(inValue);
        }

        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }

        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }

        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.SpellServiceSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.SpellServiceSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }

        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.SpellServiceSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://speller.yandex.net/services/spellservice");
            }
            if ((endpointConfiguration == EndpointConfiguration.SpellServiceSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://speller.yandex.net/services/spellservice");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }

        public enum EndpointConfiguration
        {

            SpellServiceSoap,

            SpellServiceSoap12,
        }
    }
}
