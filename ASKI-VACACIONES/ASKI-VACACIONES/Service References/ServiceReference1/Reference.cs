﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASKI_VACACIONES.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/Service_Asky")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Permisos", Namespace="http://schemas.datacontract.org/2004/07/Service_Asky.Tables")]
    [System.SerializableAttribute()]
    public partial class Permisos : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool activoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int permisosidField;
        
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
        public bool activo {
            get {
                return this.activoField;
            }
            set {
                if ((this.activoField.Equals(value) != true)) {
                    this.activoField = value;
                    this.RaisePropertyChanged("activo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.descripcionField, value) != true)) {
                    this.descripcionField = value;
                    this.RaisePropertyChanged("descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int permisosid {
            get {
                return this.permisosidField;
            }
            set {
                if ((this.permisosidField.Equals(value) != true)) {
                    this.permisosidField = value;
                    this.RaisePropertyChanged("permisosid");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Roles", Namespace="http://schemas.datacontract.org/2004/07/Service_Asky.Tables")]
    [System.SerializableAttribute()]
    public partial class Roles : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool activoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int rolesidField;
        
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
        public bool activo {
            get {
                return this.activoField;
            }
            set {
                if ((this.activoField.Equals(value) != true)) {
                    this.activoField = value;
                    this.RaisePropertyChanged("activo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.descripcionField, value) != true)) {
                    this.descripcionField = value;
                    this.RaisePropertyChanged("descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int rolesid {
            get {
                return this.rolesidField;
            }
            set {
                if ((this.rolesidField.Equals(value) != true)) {
                    this.rolesidField = value;
                    this.RaisePropertyChanged("rolesid");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Departamento", Namespace="http://schemas.datacontract.org/2004/07/Service_Asky.Tables")]
    [System.SerializableAttribute()]
    public partial class Departamento : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool activoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int departamentoidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descripcionField;
        
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
        public bool activo {
            get {
                return this.activoField;
            }
            set {
                if ((this.activoField.Equals(value) != true)) {
                    this.activoField = value;
                    this.RaisePropertyChanged("activo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int departamentoid {
            get {
                return this.departamentoidField;
            }
            set {
                if ((this.departamentoidField.Equals(value) != true)) {
                    this.departamentoidField = value;
                    this.RaisePropertyChanged("departamentoid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.descripcionField, value) != true)) {
                    this.descripcionField = value;
                    this.RaisePropertyChanged("descripcion");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Usuario", Namespace="http://schemas.datacontract.org/2004/07/Service_Asky.Tables")]
    [System.SerializableAttribute()]
    public partial class Usuario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool activoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime fecha_creacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime fecha_ingresoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string primer_apellidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string primer_nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string segundo_apellidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string segundo_nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int talento_humanoField;
        
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
        public bool activo {
            get {
                return this.activoField;
            }
            set {
                if ((this.activoField.Equals(value) != true)) {
                    this.activoField = value;
                    this.RaisePropertyChanged("activo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime fecha_creacion {
            get {
                return this.fecha_creacionField;
            }
            set {
                if ((this.fecha_creacionField.Equals(value) != true)) {
                    this.fecha_creacionField = value;
                    this.RaisePropertyChanged("fecha_creacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime fecha_ingreso {
            get {
                return this.fecha_ingresoField;
            }
            set {
                if ((this.fecha_ingresoField.Equals(value) != true)) {
                    this.fecha_ingresoField = value;
                    this.RaisePropertyChanged("fecha_ingreso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string primer_apellido {
            get {
                return this.primer_apellidoField;
            }
            set {
                if ((object.ReferenceEquals(this.primer_apellidoField, value) != true)) {
                    this.primer_apellidoField = value;
                    this.RaisePropertyChanged("primer_apellido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string primer_nombre {
            get {
                return this.primer_nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.primer_nombreField, value) != true)) {
                    this.primer_nombreField = value;
                    this.RaisePropertyChanged("primer_nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string segundo_apellido {
            get {
                return this.segundo_apellidoField;
            }
            set {
                if ((object.ReferenceEquals(this.segundo_apellidoField, value) != true)) {
                    this.segundo_apellidoField = value;
                    this.RaisePropertyChanged("segundo_apellido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string segundo_nombre {
            get {
                return this.segundo_nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.segundo_nombreField, value) != true)) {
                    this.segundo_nombreField = value;
                    this.RaisePropertyChanged("segundo_nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int talento_humano {
            get {
                return this.talento_humanoField;
            }
            set {
                if ((this.talento_humanoField.Equals(value) != true)) {
                    this.talento_humanoField = value;
                    this.RaisePropertyChanged("talento_humano");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        ASKI_VACACIONES.ServiceReference1.CompositeType GetDataUsingDataContract(ASKI_VACACIONES.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<ASKI_VACACIONES.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(ASKI_VACACIONES.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addDepartamento", ReplyAction="http://tempuri.org/IService1/addDepartamentoResponse")]
        void addDepartamento(string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addDepartamento", ReplyAction="http://tempuri.org/IService1/addDepartamentoResponse")]
        System.Threading.Tasks.Task addDepartamentoAsync(string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addRole", ReplyAction="http://tempuri.org/IService1/addRoleResponse")]
        void addRole(string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addRole", ReplyAction="http://tempuri.org/IService1/addRoleResponse")]
        System.Threading.Tasks.Task addRoleAsync(string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addUsuario", ReplyAction="http://tempuri.org/IService1/addUsuarioResponse")]
        void addUsuario(int talento_humano, string email, string primer_nombre, string segundo_nombre, string primer_apellido, string segundo_apellido, System.DateTime fecha_ingreso, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addUsuario", ReplyAction="http://tempuri.org/IService1/addUsuarioResponse")]
        System.Threading.Tasks.Task addUsuarioAsync(int talento_humano, string email, string primer_nombre, string segundo_nombre, string primer_apellido, string segundo_apellido, System.DateTime fecha_ingreso, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addPermiso", ReplyAction="http://tempuri.org/IService1/addPermisoResponse")]
        void addPermiso(string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addPermiso", ReplyAction="http://tempuri.org/IService1/addPermisoResponse")]
        System.Threading.Tasks.Task addPermisoAsync(string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editPermiso", ReplyAction="http://tempuri.org/IService1/editPermisoResponse")]
        void editPermiso(int id, string descripcion, bool activo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editPermiso", ReplyAction="http://tempuri.org/IService1/editPermisoResponse")]
        System.Threading.Tasks.Task editPermisoAsync(int id, string descripcion, bool activo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editRol", ReplyAction="http://tempuri.org/IService1/editRolResponse")]
        void editRol(int id, string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editRol", ReplyAction="http://tempuri.org/IService1/editRolResponse")]
        System.Threading.Tasks.Task editRolAsync(int id, string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editDepartamento", ReplyAction="http://tempuri.org/IService1/editDepartamentoResponse")]
        void editDepartamento(int id, string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editDepartamento", ReplyAction="http://tempuri.org/IService1/editDepartamentoResponse")]
        System.Threading.Tasks.Task editDepartamentoAsync(int id, string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editUsuario", ReplyAction="http://tempuri.org/IService1/editUsuarioResponse")]
        void editUsuario(int talentoHumano, string email, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, System.DateTime fechaIngreso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editUsuario", ReplyAction="http://tempuri.org/IService1/editUsuarioResponse")]
        System.Threading.Tasks.Task editUsuarioAsync(int talentoHumano, string email, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, System.DateTime fechaIngreso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletePermiso", ReplyAction="http://tempuri.org/IService1/deletePermisoResponse")]
        void deletePermiso(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletePermiso", ReplyAction="http://tempuri.org/IService1/deletePermisoResponse")]
        System.Threading.Tasks.Task deletePermisoAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/confirmarLogin", ReplyAction="http://tempuri.org/IService1/confirmarLoginResponse")]
        bool confirmarLogin(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/confirmarLogin", ReplyAction="http://tempuri.org/IService1/confirmarLoginResponse")]
        System.Threading.Tasks.Task<bool> confirmarLoginAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getPermiso", ReplyAction="http://tempuri.org/IService1/getPermisoResponse")]
        ASKI_VACACIONES.ServiceReference1.Permisos getPermiso(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getPermiso", ReplyAction="http://tempuri.org/IService1/getPermisoResponse")]
        System.Threading.Tasks.Task<ASKI_VACACIONES.ServiceReference1.Permisos> getPermisoAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getRol", ReplyAction="http://tempuri.org/IService1/getRolResponse")]
        ASKI_VACACIONES.ServiceReference1.Roles getRol(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getRol", ReplyAction="http://tempuri.org/IService1/getRolResponse")]
        System.Threading.Tasks.Task<ASKI_VACACIONES.ServiceReference1.Roles> getRolAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getDepartamento", ReplyAction="http://tempuri.org/IService1/getDepartamentoResponse")]
        ASKI_VACACIONES.ServiceReference1.Departamento getDepartamento(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getDepartamento", ReplyAction="http://tempuri.org/IService1/getDepartamentoResponse")]
        System.Threading.Tasks.Task<ASKI_VACACIONES.ServiceReference1.Departamento> getDepartamentoAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getUsuario", ReplyAction="http://tempuri.org/IService1/getUsuarioResponse")]
        ASKI_VACACIONES.ServiceReference1.Usuario getUsuario(int talento_humano);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getUsuario", ReplyAction="http://tempuri.org/IService1/getUsuarioResponse")]
        System.Threading.Tasks.Task<ASKI_VACACIONES.ServiceReference1.Usuario> getUsuarioAsync(int talento_humano);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ASKI_VACACIONES.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ASKI_VACACIONES.ServiceReference1.IService1>, ASKI_VACACIONES.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public ASKI_VACACIONES.ServiceReference1.CompositeType GetDataUsingDataContract(ASKI_VACACIONES.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<ASKI_VACACIONES.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(ASKI_VACACIONES.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public void addDepartamento(string descripcion) {
            base.Channel.addDepartamento(descripcion);
        }
        
        public System.Threading.Tasks.Task addDepartamentoAsync(string descripcion) {
            return base.Channel.addDepartamentoAsync(descripcion);
        }
        
        public void addRole(string descripcion) {
            base.Channel.addRole(descripcion);
        }
        
        public System.Threading.Tasks.Task addRoleAsync(string descripcion) {
            return base.Channel.addRoleAsync(descripcion);
        }
        
        public void addUsuario(int talento_humano, string email, string primer_nombre, string segundo_nombre, string primer_apellido, string segundo_apellido, System.DateTime fecha_ingreso, string password) {
            base.Channel.addUsuario(talento_humano, email, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, fecha_ingreso, password);
        }
        
        public System.Threading.Tasks.Task addUsuarioAsync(int talento_humano, string email, string primer_nombre, string segundo_nombre, string primer_apellido, string segundo_apellido, System.DateTime fecha_ingreso, string password) {
            return base.Channel.addUsuarioAsync(talento_humano, email, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, fecha_ingreso, password);
        }
        
        public void addPermiso(string descripcion) {
            base.Channel.addPermiso(descripcion);
        }
        
        public System.Threading.Tasks.Task addPermisoAsync(string descripcion) {
            return base.Channel.addPermisoAsync(descripcion);
        }
        
        public void editPermiso(int id, string descripcion, bool activo) {
            base.Channel.editPermiso(id, descripcion, activo);
        }
        
        public System.Threading.Tasks.Task editPermisoAsync(int id, string descripcion, bool activo) {
            return base.Channel.editPermisoAsync(id, descripcion, activo);
        }
        
        public void editRol(int id, string descripcion) {
            base.Channel.editRol(id, descripcion);
        }
        
        public System.Threading.Tasks.Task editRolAsync(int id, string descripcion) {
            return base.Channel.editRolAsync(id, descripcion);
        }
        
        public void editDepartamento(int id, string descripcion) {
            base.Channel.editDepartamento(id, descripcion);
        }
        
        public System.Threading.Tasks.Task editDepartamentoAsync(int id, string descripcion) {
            return base.Channel.editDepartamentoAsync(id, descripcion);
        }
        
        public void editUsuario(int talentoHumano, string email, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, System.DateTime fechaIngreso) {
            base.Channel.editUsuario(talentoHumano, email, primerNombre, segundoNombre, primerApellido, segundoApellido, fechaIngreso);
        }
        
        public System.Threading.Tasks.Task editUsuarioAsync(int talentoHumano, string email, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, System.DateTime fechaIngreso) {
            return base.Channel.editUsuarioAsync(talentoHumano, email, primerNombre, segundoNombre, primerApellido, segundoApellido, fechaIngreso);
        }
        
        public void deletePermiso(int id) {
            base.Channel.deletePermiso(id);
        }
        
        public System.Threading.Tasks.Task deletePermisoAsync(int id) {
            return base.Channel.deletePermisoAsync(id);
        }
        
        public bool confirmarLogin(string email, string password) {
            return base.Channel.confirmarLogin(email, password);
        }
        
        public System.Threading.Tasks.Task<bool> confirmarLoginAsync(string email, string password) {
            return base.Channel.confirmarLoginAsync(email, password);
        }
        
        public ASKI_VACACIONES.ServiceReference1.Permisos getPermiso(int id) {
            return base.Channel.getPermiso(id);
        }
        
        public System.Threading.Tasks.Task<ASKI_VACACIONES.ServiceReference1.Permisos> getPermisoAsync(int id) {
            return base.Channel.getPermisoAsync(id);
        }
        
        public ASKI_VACACIONES.ServiceReference1.Roles getRol(int id) {
            return base.Channel.getRol(id);
        }
        
        public System.Threading.Tasks.Task<ASKI_VACACIONES.ServiceReference1.Roles> getRolAsync(int id) {
            return base.Channel.getRolAsync(id);
        }
        
        public ASKI_VACACIONES.ServiceReference1.Departamento getDepartamento(int id) {
            return base.Channel.getDepartamento(id);
        }
        
        public System.Threading.Tasks.Task<ASKI_VACACIONES.ServiceReference1.Departamento> getDepartamentoAsync(int id) {
            return base.Channel.getDepartamentoAsync(id);
        }
        
        public ASKI_VACACIONES.ServiceReference1.Usuario getUsuario(int talento_humano) {
            return base.Channel.getUsuario(talento_humano);
        }
        
        public System.Threading.Tasks.Task<ASKI_VACACIONES.ServiceReference1.Usuario> getUsuarioAsync(int talento_humano) {
            return base.Channel.getUsuarioAsync(talento_humano);
        }
    }
}
