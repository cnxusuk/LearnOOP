﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaleProject.SaleService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/SaleClassLibrary")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CustomerNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailIdField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerID {
            get {
                return this.CustomerIDField;
            }
            set {
                if ((this.CustomerIDField.Equals(value) != true)) {
                    this.CustomerIDField = value;
                    this.RaisePropertyChanged("CustomerID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerName {
            get {
                return this.CustomerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerNameField, value) != true)) {
                    this.CustomerNameField = value;
                    this.RaisePropertyChanged("CustomerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmailId {
            get {
                return this.EmailIdField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailIdField, value) != true)) {
                    this.EmailIdField = value;
                    this.RaisePropertyChanged("EmailId");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SaleService.ISaleService")]
    public interface ISaleService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISaleService/InsertCustomer", ReplyAction="http://tempuri.org/ISaleService/InsertCustomerResponse")]
        bool InsertCustomer(SaleProject.SaleService.Customer obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISaleService/UpdateCustomer", ReplyAction="http://tempuri.org/ISaleService/UpdateCustomerResponse")]
        bool UpdateCustomer(SaleProject.SaleService.Customer obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISaleService/DeleteCustomer", ReplyAction="http://tempuri.org/ISaleService/DeleteCustomerResponse")]
        bool DeleteCustomer(int Cid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISaleService/GetAllCustomer", ReplyAction="http://tempuri.org/ISaleService/GetAllCustomerResponse")]
        SaleProject.SaleService.Customer[] GetAllCustomer();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISaleServiceChannel : SaleProject.SaleService.ISaleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SaleServiceClient : System.ServiceModel.ClientBase<SaleProject.SaleService.ISaleService>, SaleProject.SaleService.ISaleService {
        
        public SaleServiceClient() {
        }
        
        public SaleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SaleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SaleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SaleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool InsertCustomer(SaleProject.SaleService.Customer obj) {
            return base.Channel.InsertCustomer(obj);
        }
        
        public bool UpdateCustomer(SaleProject.SaleService.Customer obj) {
            return base.Channel.UpdateCustomer(obj);
        }
        
        public bool DeleteCustomer(int Cid) {
            return base.Channel.DeleteCustomer(Cid);
        }
        
        public SaleProject.SaleService.Customer[] GetAllCustomer() {
            return base.Channel.GetAllCustomer();
        }
    }
}
