﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NUEVE.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        NUEVE.ServiceReference1.HelloWorldResponse HelloWorld(NUEVE.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<NUEVE.ServiceReference1.HelloWorldResponse> HelloWorldAsync(NUEVE.ServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name nombre from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Modifica", ReplyAction="*")]
        NUEVE.ServiceReference1.ModificaResponse Modifica(NUEVE.ServiceReference1.ModificaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Modifica", ReplyAction="*")]
        System.Threading.Tasks.Task<NUEVE.ServiceReference1.ModificaResponse> ModificaAsync(NUEVE.ServiceReference1.ModificaRequest request);
        
        // CODEGEN: Generating message contract since element name nombre from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Crea", ReplyAction="*")]
        NUEVE.ServiceReference1.CreaResponse Crea(NUEVE.ServiceReference1.CreaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Crea", ReplyAction="*")]
        System.Threading.Tasks.Task<NUEVE.ServiceReference1.CreaResponse> CreaAsync(NUEVE.ServiceReference1.CreaRequest request);
        
        // CODEGEN: Generating message contract since element name EliminaResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Elimina", ReplyAction="*")]
        NUEVE.ServiceReference1.EliminaResponse Elimina(NUEVE.ServiceReference1.EliminaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Elimina", ReplyAction="*")]
        System.Threading.Tasks.Task<NUEVE.ServiceReference1.EliminaResponse> EliminaAsync(NUEVE.ServiceReference1.EliminaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public NUEVE.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(NUEVE.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public NUEVE.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(NUEVE.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ModificaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Modifica", Namespace="http://tempuri.org/", Order=0)]
        public NUEVE.ServiceReference1.ModificaRequestBody Body;
        
        public ModificaRequest() {
        }
        
        public ModificaRequest(NUEVE.ServiceReference1.ModificaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ModificaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string apellido;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string telefono;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public bool tipo;
        
        public ModificaRequestBody() {
        }
        
        public ModificaRequestBody(int id, string nombre, string apellido, string telefono, bool tipo) {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.tipo = tipo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ModificaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ModificaResponse", Namespace="http://tempuri.org/", Order=0)]
        public NUEVE.ServiceReference1.ModificaResponseBody Body;
        
        public ModificaResponse() {
        }
        
        public ModificaResponse(NUEVE.ServiceReference1.ModificaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ModificaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ModificaResult;
        
        public ModificaResponseBody() {
        }
        
        public ModificaResponseBody(string ModificaResult) {
            this.ModificaResult = ModificaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Crea", Namespace="http://tempuri.org/", Order=0)]
        public NUEVE.ServiceReference1.CreaRequestBody Body;
        
        public CreaRequest() {
        }
        
        public CreaRequest(NUEVE.ServiceReference1.CreaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CreaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string apellido;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string telefono;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public bool tipo;
        
        public CreaRequestBody() {
        }
        
        public CreaRequestBody(string nombre, string apellido, string telefono, bool tipo) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.tipo = tipo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreaResponse", Namespace="http://tempuri.org/", Order=0)]
        public NUEVE.ServiceReference1.CreaResponseBody Body;
        
        public CreaResponse() {
        }
        
        public CreaResponse(NUEVE.ServiceReference1.CreaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CreaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CreaResult;
        
        public CreaResponseBody() {
        }
        
        public CreaResponseBody(string CreaResult) {
            this.CreaResult = CreaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EliminaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Elimina", Namespace="http://tempuri.org/", Order=0)]
        public NUEVE.ServiceReference1.EliminaRequestBody Body;
        
        public EliminaRequest() {
        }
        
        public EliminaRequest(NUEVE.ServiceReference1.EliminaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EliminaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public EliminaRequestBody() {
        }
        
        public EliminaRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EliminaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EliminaResponse", Namespace="http://tempuri.org/", Order=0)]
        public NUEVE.ServiceReference1.EliminaResponseBody Body;
        
        public EliminaResponse() {
        }
        
        public EliminaResponse(NUEVE.ServiceReference1.EliminaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EliminaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string EliminaResult;
        
        public EliminaResponseBody() {
        }
        
        public EliminaResponseBody(string EliminaResult) {
            this.EliminaResult = EliminaResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : NUEVE.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<NUEVE.ServiceReference1.WebService1Soap>, NUEVE.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NUEVE.ServiceReference1.HelloWorldResponse NUEVE.ServiceReference1.WebService1Soap.HelloWorld(NUEVE.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            NUEVE.ServiceReference1.HelloWorldRequest inValue = new NUEVE.ServiceReference1.HelloWorldRequest();
            inValue.Body = new NUEVE.ServiceReference1.HelloWorldRequestBody();
            NUEVE.ServiceReference1.HelloWorldResponse retVal = ((NUEVE.ServiceReference1.WebService1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NUEVE.ServiceReference1.HelloWorldResponse> NUEVE.ServiceReference1.WebService1Soap.HelloWorldAsync(NUEVE.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<NUEVE.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            NUEVE.ServiceReference1.HelloWorldRequest inValue = new NUEVE.ServiceReference1.HelloWorldRequest();
            inValue.Body = new NUEVE.ServiceReference1.HelloWorldRequestBody();
            return ((NUEVE.ServiceReference1.WebService1Soap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NUEVE.ServiceReference1.ModificaResponse NUEVE.ServiceReference1.WebService1Soap.Modifica(NUEVE.ServiceReference1.ModificaRequest request) {
            return base.Channel.Modifica(request);
        }
        
        public string Modifica(int id, string nombre, string apellido, string telefono, bool tipo) {
            NUEVE.ServiceReference1.ModificaRequest inValue = new NUEVE.ServiceReference1.ModificaRequest();
            inValue.Body = new NUEVE.ServiceReference1.ModificaRequestBody();
            inValue.Body.id = id;
            inValue.Body.nombre = nombre;
            inValue.Body.apellido = apellido;
            inValue.Body.telefono = telefono;
            inValue.Body.tipo = tipo;
            NUEVE.ServiceReference1.ModificaResponse retVal = ((NUEVE.ServiceReference1.WebService1Soap)(this)).Modifica(inValue);
            return retVal.Body.ModificaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NUEVE.ServiceReference1.ModificaResponse> NUEVE.ServiceReference1.WebService1Soap.ModificaAsync(NUEVE.ServiceReference1.ModificaRequest request) {
            return base.Channel.ModificaAsync(request);
        }
        
        public System.Threading.Tasks.Task<NUEVE.ServiceReference1.ModificaResponse> ModificaAsync(int id, string nombre, string apellido, string telefono, bool tipo) {
            NUEVE.ServiceReference1.ModificaRequest inValue = new NUEVE.ServiceReference1.ModificaRequest();
            inValue.Body = new NUEVE.ServiceReference1.ModificaRequestBody();
            inValue.Body.id = id;
            inValue.Body.nombre = nombre;
            inValue.Body.apellido = apellido;
            inValue.Body.telefono = telefono;
            inValue.Body.tipo = tipo;
            return ((NUEVE.ServiceReference1.WebService1Soap)(this)).ModificaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NUEVE.ServiceReference1.CreaResponse NUEVE.ServiceReference1.WebService1Soap.Crea(NUEVE.ServiceReference1.CreaRequest request) {
            return base.Channel.Crea(request);
        }
        
        public string Crea(string nombre, string apellido, string telefono, bool tipo) {
            NUEVE.ServiceReference1.CreaRequest inValue = new NUEVE.ServiceReference1.CreaRequest();
            inValue.Body = new NUEVE.ServiceReference1.CreaRequestBody();
            inValue.Body.nombre = nombre;
            inValue.Body.apellido = apellido;
            inValue.Body.telefono = telefono;
            inValue.Body.tipo = tipo;
            NUEVE.ServiceReference1.CreaResponse retVal = ((NUEVE.ServiceReference1.WebService1Soap)(this)).Crea(inValue);
            return retVal.Body.CreaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NUEVE.ServiceReference1.CreaResponse> NUEVE.ServiceReference1.WebService1Soap.CreaAsync(NUEVE.ServiceReference1.CreaRequest request) {
            return base.Channel.CreaAsync(request);
        }
        
        public System.Threading.Tasks.Task<NUEVE.ServiceReference1.CreaResponse> CreaAsync(string nombre, string apellido, string telefono, bool tipo) {
            NUEVE.ServiceReference1.CreaRequest inValue = new NUEVE.ServiceReference1.CreaRequest();
            inValue.Body = new NUEVE.ServiceReference1.CreaRequestBody();
            inValue.Body.nombre = nombre;
            inValue.Body.apellido = apellido;
            inValue.Body.telefono = telefono;
            inValue.Body.tipo = tipo;
            return ((NUEVE.ServiceReference1.WebService1Soap)(this)).CreaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NUEVE.ServiceReference1.EliminaResponse NUEVE.ServiceReference1.WebService1Soap.Elimina(NUEVE.ServiceReference1.EliminaRequest request) {
            return base.Channel.Elimina(request);
        }
        
        public string Elimina(int id) {
            NUEVE.ServiceReference1.EliminaRequest inValue = new NUEVE.ServiceReference1.EliminaRequest();
            inValue.Body = new NUEVE.ServiceReference1.EliminaRequestBody();
            inValue.Body.id = id;
            NUEVE.ServiceReference1.EliminaResponse retVal = ((NUEVE.ServiceReference1.WebService1Soap)(this)).Elimina(inValue);
            return retVal.Body.EliminaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NUEVE.ServiceReference1.EliminaResponse> NUEVE.ServiceReference1.WebService1Soap.EliminaAsync(NUEVE.ServiceReference1.EliminaRequest request) {
            return base.Channel.EliminaAsync(request);
        }
        
        public System.Threading.Tasks.Task<NUEVE.ServiceReference1.EliminaResponse> EliminaAsync(int id) {
            NUEVE.ServiceReference1.EliminaRequest inValue = new NUEVE.ServiceReference1.EliminaRequest();
            inValue.Body = new NUEVE.ServiceReference1.EliminaRequestBody();
            inValue.Body.id = id;
            return ((NUEVE.ServiceReference1.WebService1Soap)(this)).EliminaAsync(inValue);
        }
    }
}
