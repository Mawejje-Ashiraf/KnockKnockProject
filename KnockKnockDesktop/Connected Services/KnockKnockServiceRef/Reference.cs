﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KnockKnockDesktop.KnockKnockServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="KnockResponse", Namespace="http://schemas.datacontract.org/2004/07/KnockKnockService.Models")]
    [System.SerializableAttribute()]
    public partial class KnockResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreatedAtField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RequestIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private KnockKnockDesktop.KnockKnockServiceRef.RequestModel[] RequestsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private KnockKnockDesktop.KnockKnockServiceRef.HelperClassResponseCode ResponseStatusCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime UpdatedAtField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreatedAt {
            get {
                return this.CreatedAtField;
            }
            set {
                if ((this.CreatedAtField.Equals(value) != true)) {
                    this.CreatedAtField = value;
                    this.RaisePropertyChanged("CreatedAt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RequestID {
            get {
                return this.RequestIDField;
            }
            set {
                if ((this.RequestIDField.Equals(value) != true)) {
                    this.RequestIDField = value;
                    this.RaisePropertyChanged("RequestID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public KnockKnockDesktop.KnockKnockServiceRef.RequestModel[] Requests {
            get {
                return this.RequestsField;
            }
            set {
                if ((object.ReferenceEquals(this.RequestsField, value) != true)) {
                    this.RequestsField = value;
                    this.RaisePropertyChanged("Requests");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public KnockKnockDesktop.KnockKnockServiceRef.HelperClassResponseCode ResponseStatusCode {
            get {
                return this.ResponseStatusCodeField;
            }
            set {
                if ((this.ResponseStatusCodeField.Equals(value) != true)) {
                    this.ResponseStatusCodeField = value;
                    this.RaisePropertyChanged("ResponseStatusCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime UpdatedAt {
            get {
                return this.UpdatedAtField;
            }
            set {
                if ((this.UpdatedAtField.Equals(value) != true)) {
                    this.UpdatedAtField = value;
                    this.RaisePropertyChanged("UpdatedAt");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RequestModel", Namespace="http://schemas.datacontract.org/2004/07/KnockKnockService.Models")]
    [System.SerializableAttribute()]
    public partial class RequestModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreatedAtField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RequestIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime UpdatedAtField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreatedAt {
            get {
                return this.CreatedAtField;
            }
            set {
                if ((this.CreatedAtField.Equals(value) != true)) {
                    this.CreatedAtField = value;
                    this.RaisePropertyChanged("CreatedAt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RequestID {
            get {
                return this.RequestIDField;
            }
            set {
                if ((this.RequestIDField.Equals(value) != true)) {
                    this.RequestIDField = value;
                    this.RaisePropertyChanged("RequestID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime UpdatedAt {
            get {
                return this.UpdatedAtField;
            }
            set {
                if ((this.UpdatedAtField.Equals(value) != true)) {
                    this.UpdatedAtField = value;
                    this.RaisePropertyChanged("UpdatedAt");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HelperClass.ResponseCode", Namespace="http://schemas.datacontract.org/2004/07/KnockKnockService.Common")]
    public enum HelperClassResponseCode : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Failed = 101,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Success = 100,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="KnockKnockServiceRef.IKnockService")]
    public interface IKnockService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKnockService/CheckForRequests", ReplyAction="http://tempuri.org/IKnockService/CheckForRequestsResponse")]
        KnockKnockDesktop.KnockKnockServiceRef.KnockResponse CheckForRequests();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKnockService/CheckForRequests", ReplyAction="http://tempuri.org/IKnockService/CheckForRequestsResponse")]
        System.Threading.Tasks.Task<KnockKnockDesktop.KnockKnockServiceRef.KnockResponse> CheckForRequestsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKnockService/UpdateRequest", ReplyAction="http://tempuri.org/IKnockService/UpdateRequestResponse")]
        KnockKnockDesktop.KnockKnockServiceRef.KnockResponse UpdateRequest(int requestID, bool approve, string SecToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKnockService/UpdateRequest", ReplyAction="http://tempuri.org/IKnockService/UpdateRequestResponse")]
        System.Threading.Tasks.Task<KnockKnockDesktop.KnockKnockServiceRef.KnockResponse> UpdateRequestAsync(int requestID, bool approve, string SecToken);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IKnockServiceChannel : KnockKnockDesktop.KnockKnockServiceRef.IKnockService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class KnockServiceClient : System.ServiceModel.ClientBase<KnockKnockDesktop.KnockKnockServiceRef.IKnockService>, KnockKnockDesktop.KnockKnockServiceRef.IKnockService {
        
        public KnockServiceClient() {
        }
        
        public KnockServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public KnockServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KnockServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KnockServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public KnockKnockDesktop.KnockKnockServiceRef.KnockResponse CheckForRequests() {
            return base.Channel.CheckForRequests();
        }
        
        public System.Threading.Tasks.Task<KnockKnockDesktop.KnockKnockServiceRef.KnockResponse> CheckForRequestsAsync() {
            return base.Channel.CheckForRequestsAsync();
        }
        
        public KnockKnockDesktop.KnockKnockServiceRef.KnockResponse UpdateRequest(int requestID, bool approve, string SecToken) {
            return base.Channel.UpdateRequest(requestID, approve, SecToken);
        }
        
        public System.Threading.Tasks.Task<KnockKnockDesktop.KnockKnockServiceRef.KnockResponse> UpdateRequestAsync(int requestID, bool approve, string SecToken) {
            return base.Channel.UpdateRequestAsync(requestID, approve, SecToken);
        }
    }
}
