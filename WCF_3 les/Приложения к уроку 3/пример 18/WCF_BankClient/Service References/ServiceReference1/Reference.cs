﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.17929
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_BankClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IBankService")]
    public interface IBankService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankService/ToDeposit", ReplyAction="http://tempuri.org/IBankService/ToDepositResponse")]
        void ToDeposit(double sum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankService/ToDeposit", ReplyAction="http://tempuri.org/IBankService/ToDepositResponse")]
        System.Threading.Tasks.Task ToDepositAsync(double sum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankService/GetBalance", ReplyAction="http://tempuri.org/IBankService/GetBalanceResponse")]
        double GetBalance();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankService/GetBalance", ReplyAction="http://tempuri.org/IBankService/GetBalanceResponse")]
        System.Threading.Tasks.Task<double> GetBalanceAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBankServiceChannel : WCF_BankClient.ServiceReference1.IBankService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BankServiceClient : System.ServiceModel.ClientBase<WCF_BankClient.ServiceReference1.IBankService>, WCF_BankClient.ServiceReference1.IBankService {
        
        public BankServiceClient() {
        }
        
        public BankServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BankServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BankServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BankServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void ToDeposit(double sum) {
            base.Channel.ToDeposit(sum);
        }
        
        public System.Threading.Tasks.Task ToDepositAsync(double sum) {
            return base.Channel.ToDepositAsync(sum);
        }
        
        public double GetBalance() {
            return base.Channel.GetBalance();
        }
        
        public System.Threading.Tasks.Task<double> GetBalanceAsync() {
            return base.Channel.GetBalanceAsync();
        }
    }
}
