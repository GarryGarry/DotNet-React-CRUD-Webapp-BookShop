﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mars_Crud1.Fax {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.AcrossCommunications.com/", ConfigurationName="Fax.FaxSoap")]
    public interface FaxSoap {
        
        // CODEGEN: Generating message contract since element name strGuidNotification from namespace http://ws.AcrossCommunications.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.AcrossCommunications.com/EnqueueTextDocument", ReplyAction="*")]
        Mars_Crud1.Fax.EnqueueTextDocumentResponse EnqueueTextDocument(Mars_Crud1.Fax.EnqueueTextDocumentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.AcrossCommunications.com/EnqueueTextDocument", ReplyAction="*")]
        System.Threading.Tasks.Task<Mars_Crud1.Fax.EnqueueTextDocumentResponse> EnqueueTextDocumentAsync(Mars_Crud1.Fax.EnqueueTextDocumentRequest request);
        
        // CODEGEN: Generating message contract since element name strGuidNotification from namespace http://ws.AcrossCommunications.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.AcrossCommunications.com/GetLastMethodDuration", ReplyAction="*")]
        Mars_Crud1.Fax.GetLastMethodDurationResponse GetLastMethodDuration(Mars_Crud1.Fax.GetLastMethodDurationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.AcrossCommunications.com/GetLastMethodDuration", ReplyAction="*")]
        System.Threading.Tasks.Task<Mars_Crud1.Fax.GetLastMethodDurationResponse> GetLastMethodDurationAsync(Mars_Crud1.Fax.GetLastMethodDurationRequest request);
        
        // CODEGEN: Generating message contract since element name strGuidNotification from namespace http://ws.AcrossCommunications.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.AcrossCommunications.com/SetSearchString", ReplyAction="*")]
        Mars_Crud1.Fax.SetSearchStringResponse SetSearchString(Mars_Crud1.Fax.SetSearchStringRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.AcrossCommunications.com/SetSearchString", ReplyAction="*")]
        System.Threading.Tasks.Task<Mars_Crud1.Fax.SetSearchStringResponse> SetSearchStringAsync(Mars_Crud1.Fax.SetSearchStringRequest request);
        
        // CODEGEN: Generating message contract since element name strGuidNotification from namespace http://ws.AcrossCommunications.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.AcrossCommunications.com/GetSearchString", ReplyAction="*")]
        Mars_Crud1.Fax.GetSearchStringResponse GetSearchString(Mars_Crud1.Fax.GetSearchStringRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.AcrossCommunications.com/GetSearchString", ReplyAction="*")]
        System.Threading.Tasks.Task<Mars_Crud1.Fax.GetSearchStringResponse> GetSearchStringAsync(Mars_Crud1.Fax.GetSearchStringRequest request);
        
        // CODEGEN: Generating message contract since element name strGuidNotification from namespace http://ws.AcrossCommunications.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.AcrossCommunications.com/Release", ReplyAction="*")]
        Mars_Crud1.Fax.ReleaseResponse Release(Mars_Crud1.Fax.ReleaseRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.AcrossCommunications.com/Release", ReplyAction="*")]
        System.Threading.Tasks.Task<Mars_Crud1.Fax.ReleaseResponse> ReleaseAsync(Mars_Crud1.Fax.ReleaseRequest request);
        
        // CODEGEN: Generating message contract since element name strGuidNotification from namespace http://ws.AcrossCommunications.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.AcrossCommunications.com/SendTextDocument", ReplyAction="*")]
        Mars_Crud1.Fax.SendTextDocumentResponse SendTextDocument(Mars_Crud1.Fax.SendTextDocumentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.AcrossCommunications.com/SendTextDocument", ReplyAction="*")]
        System.Threading.Tasks.Task<Mars_Crud1.Fax.SendTextDocumentResponse> SendTextDocumentAsync(Mars_Crud1.Fax.SendTextDocumentRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EnqueueTextDocumentRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EnqueueTextDocument", Namespace="http://ws.AcrossCommunications.com/", Order=0)]
        public Mars_Crud1.Fax.EnqueueTextDocumentRequestBody Body;
        
        public EnqueueTextDocumentRequest() {
        }
        
        public EnqueueTextDocumentRequest(Mars_Crud1.Fax.EnqueueTextDocumentRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.AcrossCommunications.com/")]
    public partial class EnqueueTextDocumentRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string strGuidNotification;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string strPhoneNumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string strText;
        
        public EnqueueTextDocumentRequestBody() {
        }
        
        public EnqueueTextDocumentRequestBody(string strGuidNotification, string strPhoneNumber, string strText) {
            this.strGuidNotification = strGuidNotification;
            this.strPhoneNumber = strPhoneNumber;
            this.strText = strText;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EnqueueTextDocumentResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EnqueueTextDocumentResponse", Namespace="http://ws.AcrossCommunications.com/", Order=0)]
        public Mars_Crud1.Fax.EnqueueTextDocumentResponseBody Body;
        
        public EnqueueTextDocumentResponse() {
        }
        
        public EnqueueTextDocumentResponse(Mars_Crud1.Fax.EnqueueTextDocumentResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.AcrossCommunications.com/")]
    public partial class EnqueueTextDocumentResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string EnqueueTextDocumentResult;
        
        public EnqueueTextDocumentResponseBody() {
        }
        
        public EnqueueTextDocumentResponseBody(string EnqueueTextDocumentResult) {
            this.EnqueueTextDocumentResult = EnqueueTextDocumentResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetLastMethodDurationRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetLastMethodDuration", Namespace="http://ws.AcrossCommunications.com/", Order=0)]
        public Mars_Crud1.Fax.GetLastMethodDurationRequestBody Body;
        
        public GetLastMethodDurationRequest() {
        }
        
        public GetLastMethodDurationRequest(Mars_Crud1.Fax.GetLastMethodDurationRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.AcrossCommunications.com/")]
    public partial class GetLastMethodDurationRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string strGuidNotification;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string MethodName;
        
        public GetLastMethodDurationRequestBody() {
        }
        
        public GetLastMethodDurationRequestBody(string strGuidNotification, string MethodName) {
            this.strGuidNotification = strGuidNotification;
            this.MethodName = MethodName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetLastMethodDurationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetLastMethodDurationResponse", Namespace="http://ws.AcrossCommunications.com/", Order=0)]
        public Mars_Crud1.Fax.GetLastMethodDurationResponseBody Body;
        
        public GetLastMethodDurationResponse() {
        }
        
        public GetLastMethodDurationResponse(Mars_Crud1.Fax.GetLastMethodDurationResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.AcrossCommunications.com/")]
    public partial class GetLastMethodDurationResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int GetLastMethodDurationResult;
        
        public GetLastMethodDurationResponseBody() {
        }
        
        public GetLastMethodDurationResponseBody(int GetLastMethodDurationResult) {
            this.GetLastMethodDurationResult = GetLastMethodDurationResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetSearchStringRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetSearchString", Namespace="http://ws.AcrossCommunications.com/", Order=0)]
        public Mars_Crud1.Fax.SetSearchStringRequestBody Body;
        
        public SetSearchStringRequest() {
        }
        
        public SetSearchStringRequest(Mars_Crud1.Fax.SetSearchStringRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.AcrossCommunications.com/")]
    public partial class SetSearchStringRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string strGuidNotification;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string strValue;
        
        public SetSearchStringRequestBody() {
        }
        
        public SetSearchStringRequestBody(string strGuidNotification, string strValue) {
            this.strGuidNotification = strGuidNotification;
            this.strValue = strValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetSearchStringResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetSearchStringResponse", Namespace="http://ws.AcrossCommunications.com/", Order=0)]
        public Mars_Crud1.Fax.SetSearchStringResponseBody Body;
        
        public SetSearchStringResponse() {
        }
        
        public SetSearchStringResponse(Mars_Crud1.Fax.SetSearchStringResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class SetSearchStringResponseBody {
        
        public SetSearchStringResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSearchStringRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSearchString", Namespace="http://ws.AcrossCommunications.com/", Order=0)]
        public Mars_Crud1.Fax.GetSearchStringRequestBody Body;
        
        public GetSearchStringRequest() {
        }
        
        public GetSearchStringRequest(Mars_Crud1.Fax.GetSearchStringRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.AcrossCommunications.com/")]
    public partial class GetSearchStringRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string strGuidNotification;
        
        public GetSearchStringRequestBody() {
        }
        
        public GetSearchStringRequestBody(string strGuidNotification) {
            this.strGuidNotification = strGuidNotification;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSearchStringResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSearchStringResponse", Namespace="http://ws.AcrossCommunications.com/", Order=0)]
        public Mars_Crud1.Fax.GetSearchStringResponseBody Body;
        
        public GetSearchStringResponse() {
        }
        
        public GetSearchStringResponse(Mars_Crud1.Fax.GetSearchStringResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.AcrossCommunications.com/")]
    public partial class GetSearchStringResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetSearchStringResult;
        
        public GetSearchStringResponseBody() {
        }
        
        public GetSearchStringResponseBody(string GetSearchStringResult) {
            this.GetSearchStringResult = GetSearchStringResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReleaseRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Release", Namespace="http://ws.AcrossCommunications.com/", Order=0)]
        public Mars_Crud1.Fax.ReleaseRequestBody Body;
        
        public ReleaseRequest() {
        }
        
        public ReleaseRequest(Mars_Crud1.Fax.ReleaseRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.AcrossCommunications.com/")]
    public partial class ReleaseRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string strGuidNotification;
        
        public ReleaseRequestBody() {
        }
        
        public ReleaseRequestBody(string strGuidNotification) {
            this.strGuidNotification = strGuidNotification;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReleaseResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReleaseResponse", Namespace="http://ws.AcrossCommunications.com/", Order=0)]
        public Mars_Crud1.Fax.ReleaseResponseBody Body;
        
        public ReleaseResponse() {
        }
        
        public ReleaseResponse(Mars_Crud1.Fax.ReleaseResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ReleaseResponseBody {
        
        public ReleaseResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendTextDocumentRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendTextDocument", Namespace="http://ws.AcrossCommunications.com/", Order=0)]
        public Mars_Crud1.Fax.SendTextDocumentRequestBody Body;
        
        public SendTextDocumentRequest() {
        }
        
        public SendTextDocumentRequest(Mars_Crud1.Fax.SendTextDocumentRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.AcrossCommunications.com/")]
    public partial class SendTextDocumentRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string strGuidNotification;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string strPhoneNumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string strText;
        
        public SendTextDocumentRequestBody() {
        }
        
        public SendTextDocumentRequestBody(string strGuidNotification, string strPhoneNumber, string strText) {
            this.strGuidNotification = strGuidNotification;
            this.strPhoneNumber = strPhoneNumber;
            this.strText = strText;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendTextDocumentResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendTextDocumentResponse", Namespace="http://ws.AcrossCommunications.com/", Order=0)]
        public Mars_Crud1.Fax.SendTextDocumentResponseBody Body;
        
        public SendTextDocumentResponse() {
        }
        
        public SendTextDocumentResponse(Mars_Crud1.Fax.SendTextDocumentResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class SendTextDocumentResponseBody {
        
        public SendTextDocumentResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FaxSoapChannel : Mars_Crud1.Fax.FaxSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FaxSoapClient : System.ServiceModel.ClientBase<Mars_Crud1.Fax.FaxSoap>, Mars_Crud1.Fax.FaxSoap {
        
        public FaxSoapClient() {
        }
        
        public FaxSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FaxSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FaxSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FaxSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mars_Crud1.Fax.EnqueueTextDocumentResponse Mars_Crud1.Fax.FaxSoap.EnqueueTextDocument(Mars_Crud1.Fax.EnqueueTextDocumentRequest request) {
            return base.Channel.EnqueueTextDocument(request);
        }
        
        public string EnqueueTextDocument(string strGuidNotification, string strPhoneNumber, string strText) {
            Mars_Crud1.Fax.EnqueueTextDocumentRequest inValue = new Mars_Crud1.Fax.EnqueueTextDocumentRequest();
            inValue.Body = new Mars_Crud1.Fax.EnqueueTextDocumentRequestBody();
            inValue.Body.strGuidNotification = strGuidNotification;
            inValue.Body.strPhoneNumber = strPhoneNumber;
            inValue.Body.strText = strText;
            Mars_Crud1.Fax.EnqueueTextDocumentResponse retVal = ((Mars_Crud1.Fax.FaxSoap)(this)).EnqueueTextDocument(inValue);
            return retVal.Body.EnqueueTextDocumentResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mars_Crud1.Fax.EnqueueTextDocumentResponse> Mars_Crud1.Fax.FaxSoap.EnqueueTextDocumentAsync(Mars_Crud1.Fax.EnqueueTextDocumentRequest request) {
            return base.Channel.EnqueueTextDocumentAsync(request);
        }
        
        public System.Threading.Tasks.Task<Mars_Crud1.Fax.EnqueueTextDocumentResponse> EnqueueTextDocumentAsync(string strGuidNotification, string strPhoneNumber, string strText) {
            Mars_Crud1.Fax.EnqueueTextDocumentRequest inValue = new Mars_Crud1.Fax.EnqueueTextDocumentRequest();
            inValue.Body = new Mars_Crud1.Fax.EnqueueTextDocumentRequestBody();
            inValue.Body.strGuidNotification = strGuidNotification;
            inValue.Body.strPhoneNumber = strPhoneNumber;
            inValue.Body.strText = strText;
            return ((Mars_Crud1.Fax.FaxSoap)(this)).EnqueueTextDocumentAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mars_Crud1.Fax.GetLastMethodDurationResponse Mars_Crud1.Fax.FaxSoap.GetLastMethodDuration(Mars_Crud1.Fax.GetLastMethodDurationRequest request) {
            return base.Channel.GetLastMethodDuration(request);
        }
        
        public int GetLastMethodDuration(string strGuidNotification, string MethodName) {
            Mars_Crud1.Fax.GetLastMethodDurationRequest inValue = new Mars_Crud1.Fax.GetLastMethodDurationRequest();
            inValue.Body = new Mars_Crud1.Fax.GetLastMethodDurationRequestBody();
            inValue.Body.strGuidNotification = strGuidNotification;
            inValue.Body.MethodName = MethodName;
            Mars_Crud1.Fax.GetLastMethodDurationResponse retVal = ((Mars_Crud1.Fax.FaxSoap)(this)).GetLastMethodDuration(inValue);
            return retVal.Body.GetLastMethodDurationResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mars_Crud1.Fax.GetLastMethodDurationResponse> Mars_Crud1.Fax.FaxSoap.GetLastMethodDurationAsync(Mars_Crud1.Fax.GetLastMethodDurationRequest request) {
            return base.Channel.GetLastMethodDurationAsync(request);
        }
        
        public System.Threading.Tasks.Task<Mars_Crud1.Fax.GetLastMethodDurationResponse> GetLastMethodDurationAsync(string strGuidNotification, string MethodName) {
            Mars_Crud1.Fax.GetLastMethodDurationRequest inValue = new Mars_Crud1.Fax.GetLastMethodDurationRequest();
            inValue.Body = new Mars_Crud1.Fax.GetLastMethodDurationRequestBody();
            inValue.Body.strGuidNotification = strGuidNotification;
            inValue.Body.MethodName = MethodName;
            return ((Mars_Crud1.Fax.FaxSoap)(this)).GetLastMethodDurationAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mars_Crud1.Fax.SetSearchStringResponse Mars_Crud1.Fax.FaxSoap.SetSearchString(Mars_Crud1.Fax.SetSearchStringRequest request) {
            return base.Channel.SetSearchString(request);
        }
        
        public void SetSearchString(string strGuidNotification, string strValue) {
            Mars_Crud1.Fax.SetSearchStringRequest inValue = new Mars_Crud1.Fax.SetSearchStringRequest();
            inValue.Body = new Mars_Crud1.Fax.SetSearchStringRequestBody();
            inValue.Body.strGuidNotification = strGuidNotification;
            inValue.Body.strValue = strValue;
            Mars_Crud1.Fax.SetSearchStringResponse retVal = ((Mars_Crud1.Fax.FaxSoap)(this)).SetSearchString(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mars_Crud1.Fax.SetSearchStringResponse> Mars_Crud1.Fax.FaxSoap.SetSearchStringAsync(Mars_Crud1.Fax.SetSearchStringRequest request) {
            return base.Channel.SetSearchStringAsync(request);
        }
        
        public System.Threading.Tasks.Task<Mars_Crud1.Fax.SetSearchStringResponse> SetSearchStringAsync(string strGuidNotification, string strValue) {
            Mars_Crud1.Fax.SetSearchStringRequest inValue = new Mars_Crud1.Fax.SetSearchStringRequest();
            inValue.Body = new Mars_Crud1.Fax.SetSearchStringRequestBody();
            inValue.Body.strGuidNotification = strGuidNotification;
            inValue.Body.strValue = strValue;
            return ((Mars_Crud1.Fax.FaxSoap)(this)).SetSearchStringAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mars_Crud1.Fax.GetSearchStringResponse Mars_Crud1.Fax.FaxSoap.GetSearchString(Mars_Crud1.Fax.GetSearchStringRequest request) {
            return base.Channel.GetSearchString(request);
        }
        
        public string GetSearchString(string strGuidNotification) {
            Mars_Crud1.Fax.GetSearchStringRequest inValue = new Mars_Crud1.Fax.GetSearchStringRequest();
            inValue.Body = new Mars_Crud1.Fax.GetSearchStringRequestBody();
            inValue.Body.strGuidNotification = strGuidNotification;
            Mars_Crud1.Fax.GetSearchStringResponse retVal = ((Mars_Crud1.Fax.FaxSoap)(this)).GetSearchString(inValue);
            return retVal.Body.GetSearchStringResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mars_Crud1.Fax.GetSearchStringResponse> Mars_Crud1.Fax.FaxSoap.GetSearchStringAsync(Mars_Crud1.Fax.GetSearchStringRequest request) {
            return base.Channel.GetSearchStringAsync(request);
        }
        
        public System.Threading.Tasks.Task<Mars_Crud1.Fax.GetSearchStringResponse> GetSearchStringAsync(string strGuidNotification) {
            Mars_Crud1.Fax.GetSearchStringRequest inValue = new Mars_Crud1.Fax.GetSearchStringRequest();
            inValue.Body = new Mars_Crud1.Fax.GetSearchStringRequestBody();
            inValue.Body.strGuidNotification = strGuidNotification;
            return ((Mars_Crud1.Fax.FaxSoap)(this)).GetSearchStringAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mars_Crud1.Fax.ReleaseResponse Mars_Crud1.Fax.FaxSoap.Release(Mars_Crud1.Fax.ReleaseRequest request) {
            return base.Channel.Release(request);
        }
        
        public void Release(string strGuidNotification) {
            Mars_Crud1.Fax.ReleaseRequest inValue = new Mars_Crud1.Fax.ReleaseRequest();
            inValue.Body = new Mars_Crud1.Fax.ReleaseRequestBody();
            inValue.Body.strGuidNotification = strGuidNotification;
            Mars_Crud1.Fax.ReleaseResponse retVal = ((Mars_Crud1.Fax.FaxSoap)(this)).Release(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mars_Crud1.Fax.ReleaseResponse> Mars_Crud1.Fax.FaxSoap.ReleaseAsync(Mars_Crud1.Fax.ReleaseRequest request) {
            return base.Channel.ReleaseAsync(request);
        }
        
        public System.Threading.Tasks.Task<Mars_Crud1.Fax.ReleaseResponse> ReleaseAsync(string strGuidNotification) {
            Mars_Crud1.Fax.ReleaseRequest inValue = new Mars_Crud1.Fax.ReleaseRequest();
            inValue.Body = new Mars_Crud1.Fax.ReleaseRequestBody();
            inValue.Body.strGuidNotification = strGuidNotification;
            return ((Mars_Crud1.Fax.FaxSoap)(this)).ReleaseAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mars_Crud1.Fax.SendTextDocumentResponse Mars_Crud1.Fax.FaxSoap.SendTextDocument(Mars_Crud1.Fax.SendTextDocumentRequest request) {
            return base.Channel.SendTextDocument(request);
        }
        
        public void SendTextDocument(string strGuidNotification, string strPhoneNumber, string strText) {
            Mars_Crud1.Fax.SendTextDocumentRequest inValue = new Mars_Crud1.Fax.SendTextDocumentRequest();
            inValue.Body = new Mars_Crud1.Fax.SendTextDocumentRequestBody();
            inValue.Body.strGuidNotification = strGuidNotification;
            inValue.Body.strPhoneNumber = strPhoneNumber;
            inValue.Body.strText = strText;
            Mars_Crud1.Fax.SendTextDocumentResponse retVal = ((Mars_Crud1.Fax.FaxSoap)(this)).SendTextDocument(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mars_Crud1.Fax.SendTextDocumentResponse> Mars_Crud1.Fax.FaxSoap.SendTextDocumentAsync(Mars_Crud1.Fax.SendTextDocumentRequest request) {
            return base.Channel.SendTextDocumentAsync(request);
        }
        
        public System.Threading.Tasks.Task<Mars_Crud1.Fax.SendTextDocumentResponse> SendTextDocumentAsync(string strGuidNotification, string strPhoneNumber, string strText) {
            Mars_Crud1.Fax.SendTextDocumentRequest inValue = new Mars_Crud1.Fax.SendTextDocumentRequest();
            inValue.Body = new Mars_Crud1.Fax.SendTextDocumentRequestBody();
            inValue.Body.strGuidNotification = strGuidNotification;
            inValue.Body.strPhoneNumber = strPhoneNumber;
            inValue.Body.strText = strText;
            return ((Mars_Crud1.Fax.FaxSoap)(this)).SendTextDocumentAsync(inValue);
        }
    }
}
