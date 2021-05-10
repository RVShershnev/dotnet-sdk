//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Yandex.Cloud.Generated
{
    
    
    public class Services_Vpc : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Vpc(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "vpc")
        {
        }
        
        public virtual Yandex.Cloud.Vpc.V1.AddressService.AddressServiceClient AddressService
        {
            get
            {
                return new Yandex.Cloud.Vpc.V1.AddressService.AddressServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Vpc.V1.NetworkService.NetworkServiceClient NetworkService
        {
            get
            {
                return new Yandex.Cloud.Vpc.V1.NetworkService.NetworkServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Vpc.V1.RouteTableService.RouteTableServiceClient RouteTableService
        {
            get
            {
                return new Yandex.Cloud.Vpc.V1.RouteTableService.RouteTableServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Vpc.V1.SecurityGroupService.SecurityGroupServiceClient SecurityGroupService
        {
            get
            {
                return new Yandex.Cloud.Vpc.V1.SecurityGroupService.SecurityGroupServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Vpc.V1.SubnetService.SubnetServiceClient SubnetService
        {
            get
            {
                return new Yandex.Cloud.Vpc.V1.SubnetService.SubnetServiceClient(this.GetChannel());
            }
        }
    }
    
    public class Services_Serverless_Triggers : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Serverless_Triggers(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "serverless-triggers")
        {
        }
        
        public virtual Yandex.Cloud.Serverless.Triggers.V1.TriggerService.TriggerServiceClient TriggerService
        {
            get
            {
                return new Yandex.Cloud.Serverless.Triggers.V1.TriggerService.TriggerServiceClient(this.GetChannel());
            }
        }
    }
    
    public class Services_Serverless_Functions : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Serverless_Functions(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "serverless-functions")
        {
        }
        
        public virtual Yandex.Cloud.Serverless.Functions.V1.FunctionService.FunctionServiceClient FunctionService
        {
            get
            {
                return new Yandex.Cloud.Serverless.Functions.V1.FunctionService.FunctionServiceClient(this.GetChannel());
            }
        }
    }
    
    public class Services_Serverless : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Serverless(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "serverless")
        {
        }
        
        public virtual Services_Serverless_Triggers Triggers
        {
            get
            {
                return new Services_Serverless_Triggers(this.Sdk());
            }
        }
        
        public virtual Services_Serverless_Functions Functions
        {
            get
            {
                return new Services_Serverless_Functions(this.Sdk());
            }
        }
    }
    
    public class Services_Resourcemanager : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Resourcemanager(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "resource-manager")
        {
        }
        
        public virtual Yandex.Cloud.Resourcemanager.V1.CloudService.CloudServiceClient CloudService
        {
            get
            {
                return new Yandex.Cloud.Resourcemanager.V1.CloudService.CloudServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Resourcemanager.V1.FolderService.FolderServiceClient FolderService
        {
            get
            {
                return new Yandex.Cloud.Resourcemanager.V1.FolderService.FolderServiceClient(this.GetChannel());
            }
        }
    }
    
    public class Services_Operation : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Operation(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "operation")
        {
        }
        
        public virtual Yandex.Cloud.Operation.OperationService.OperationServiceClient OperationService
        {
            get
            {
                return new Yandex.Cloud.Operation.OperationService.OperationServiceClient(this.GetChannel());
            }
        }
    }
    
    public class Services_Mdb_Redis : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Mdb_Redis(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "unknown")
        {
            throw new System.Exception("service Services_Mdb_Redis is not supported at this moment");
        }
        
        public virtual Yandex.Cloud.Mdb.Redis.V1.BackupService.BackupServiceClient BackupService
        {
            get
            {
                return new Yandex.Cloud.Mdb.Redis.V1.BackupService.BackupServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Mdb.Redis.V1.ClusterService.ClusterServiceClient ClusterService
        {
            get
            {
                return new Yandex.Cloud.Mdb.Redis.V1.ClusterService.ClusterServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Mdb.Redis.V1.ResourcePresetService.ResourcePresetServiceClient ResourcePresetService
        {
            get
            {
                return new Yandex.Cloud.Mdb.Redis.V1.ResourcePresetService.ResourcePresetServiceClient(this.GetChannel());
            }
        }
    }
    
    public class Services_Mdb_Postgresql : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Mdb_Postgresql(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "unknown")
        {
            throw new System.Exception("service Services_Mdb_Postgresql is not supported at this moment");
        }
        
        public virtual Yandex.Cloud.Mdb.Postgresql.V1.BackupService.BackupServiceClient BackupService
        {
            get
            {
                return new Yandex.Cloud.Mdb.Postgresql.V1.BackupService.BackupServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Mdb.Postgresql.V1.ClusterService.ClusterServiceClient ClusterService
        {
            get
            {
                return new Yandex.Cloud.Mdb.Postgresql.V1.ClusterService.ClusterServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Mdb.Postgresql.V1.DatabaseService.DatabaseServiceClient DatabaseService
        {
            get
            {
                return new Yandex.Cloud.Mdb.Postgresql.V1.DatabaseService.DatabaseServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Mdb.Postgresql.V1.ResourcePresetService.ResourcePresetServiceClient ResourcePresetService
        {
            get
            {
                return new Yandex.Cloud.Mdb.Postgresql.V1.ResourcePresetService.ResourcePresetServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Mdb.Postgresql.V1.UserService.UserServiceClient UserService
        {
            get
            {
                return new Yandex.Cloud.Mdb.Postgresql.V1.UserService.UserServiceClient(this.GetChannel());
            }
        }
    }
    
    public class Services_Mdb_Mysql : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Mdb_Mysql(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "unknown")
        {
            throw new System.Exception("service Services_Mdb_Mysql is not supported at this moment");
        }
        
        public virtual Yandex.Cloud.Mdb.Mysql.V1.BackupService.BackupServiceClient BackupService
        {
            get
            {
                return new Yandex.Cloud.Mdb.Mysql.V1.BackupService.BackupServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Mdb.Mysql.V1.ClusterService.ClusterServiceClient ClusterService
        {
            get
            {
                return new Yandex.Cloud.Mdb.Mysql.V1.ClusterService.ClusterServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Mdb.Mysql.V1.DatabaseService.DatabaseServiceClient DatabaseService
        {
            get
            {
                return new Yandex.Cloud.Mdb.Mysql.V1.DatabaseService.DatabaseServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Mdb.Mysql.V1.ResourcePresetService.ResourcePresetServiceClient ResourcePresetService
        {
            get
            {
                return new Yandex.Cloud.Mdb.Mysql.V1.ResourcePresetService.ResourcePresetServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Mdb.Mysql.V1.UserService.UserServiceClient UserService
        {
            get
            {
                return new Yandex.Cloud.Mdb.Mysql.V1.UserService.UserServiceClient(this.GetChannel());
            }
        }
    }
    
    public class Services_Mdb_Mongodb : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Mdb_Mongodb(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "unknown")
        {
            throw new System.Exception("service Services_Mdb_Mongodb is not supported at this moment");
        }
        
        public virtual Yandex.Cloud.Mdb.Mongodb.V1.BackupService.BackupServiceClient BackupService
        {
            get
            {
                return new Yandex.Cloud.Mdb.Mongodb.V1.BackupService.BackupServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Mdb.Mongodb.V1.ClusterService.ClusterServiceClient ClusterService
        {
            get
            {
                return new Yandex.Cloud.Mdb.Mongodb.V1.ClusterService.ClusterServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Mdb.Mongodb.V1.DatabaseService.DatabaseServiceClient DatabaseService
        {
            get
            {
                return new Yandex.Cloud.Mdb.Mongodb.V1.DatabaseService.DatabaseServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Mdb.Mongodb.V1.ResourcePresetService.ResourcePresetServiceClient ResourcePresetService
        {
            get
            {
                return new Yandex.Cloud.Mdb.Mongodb.V1.ResourcePresetService.ResourcePresetServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Mdb.Mongodb.V1.UserService.UserServiceClient UserService
        {
            get
            {
                return new Yandex.Cloud.Mdb.Mongodb.V1.UserService.UserServiceClient(this.GetChannel());
            }
        }
    }
    
    public class Services_Mdb_Clickhouse : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Mdb_Clickhouse(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "unknown")
        {
            throw new System.Exception("service Services_Mdb_Clickhouse is not supported at this moment");
        }
        
        public virtual Yandex.Cloud.Mdb.Clickhouse.V1.BackupService.BackupServiceClient BackupService
        {
            get
            {
                return new Yandex.Cloud.Mdb.Clickhouse.V1.BackupService.BackupServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Mdb.Clickhouse.V1.ClusterService.ClusterServiceClient ClusterService
        {
            get
            {
                return new Yandex.Cloud.Mdb.Clickhouse.V1.ClusterService.ClusterServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Mdb.Clickhouse.V1.DatabaseService.DatabaseServiceClient DatabaseService
        {
            get
            {
                return new Yandex.Cloud.Mdb.Clickhouse.V1.DatabaseService.DatabaseServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Mdb.Clickhouse.V1.FormatSchemaService.FormatSchemaServiceClient FormatSchemaService
        {
            get
            {
                return new Yandex.Cloud.Mdb.Clickhouse.V1.FormatSchemaService.FormatSchemaServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Mdb.Clickhouse.V1.MlModelService.MlModelServiceClient MlModelService
        {
            get
            {
                return new Yandex.Cloud.Mdb.Clickhouse.V1.MlModelService.MlModelServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Mdb.Clickhouse.V1.ResourcePresetService.ResourcePresetServiceClient ResourcePresetService
        {
            get
            {
                return new Yandex.Cloud.Mdb.Clickhouse.V1.ResourcePresetService.ResourcePresetServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Mdb.Clickhouse.V1.UserService.UserServiceClient UserService
        {
            get
            {
                return new Yandex.Cloud.Mdb.Clickhouse.V1.UserService.UserServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Mdb.Clickhouse.V1.VersionsService.VersionsServiceClient VersionsService
        {
            get
            {
                return new Yandex.Cloud.Mdb.Clickhouse.V1.VersionsService.VersionsServiceClient(this.GetChannel());
            }
        }
    }
    
    public class Services_Mdb : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Mdb(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "unknown")
        {
            throw new System.Exception("service Services_Mdb is not supported at this moment");
        }
        
        public virtual Services_Mdb_Redis Redis
        {
            get
            {
                return new Services_Mdb_Redis(this.Sdk());
            }
        }
        
        public virtual Services_Mdb_Postgresql Postgresql
        {
            get
            {
                return new Services_Mdb_Postgresql(this.Sdk());
            }
        }
        
        public virtual Services_Mdb_Mysql Mysql
        {
            get
            {
                return new Services_Mdb_Mysql(this.Sdk());
            }
        }
        
        public virtual Services_Mdb_Mongodb Mongodb
        {
            get
            {
                return new Services_Mdb_Mongodb(this.Sdk());
            }
        }
        
        public virtual Services_Mdb_Clickhouse Clickhouse
        {
            get
            {
                return new Services_Mdb_Clickhouse(this.Sdk());
            }
        }
    }
    
    public class Services_Marketplace_Metering : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Marketplace_Metering(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "unknown")
        {
            throw new System.Exception("service Services_Marketplace_Metering is not supported at this moment");
        }
        
        public virtual Yandex.Cloud.Marketplace.V1.Metering.ImageProductUsageService.ImageProductUsageServiceClient ImageProductUsageService
        {
            get
            {
                return new Yandex.Cloud.Marketplace.V1.Metering.ImageProductUsageService.ImageProductUsageServiceClient(this.GetChannel());
            }
        }
    }
    
    public class Services_Marketplace : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Marketplace(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "unknown")
        {
            throw new System.Exception("service Services_Marketplace is not supported at this moment");
        }
        
        public virtual Services_Marketplace_Metering Metering
        {
            get
            {
                return new Services_Marketplace_Metering(this.Sdk());
            }
        }
    }
    
    public class Services_Loadbalancer : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Loadbalancer(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "load-balancer")
        {
        }
        
        public virtual Yandex.Cloud.Loadbalancer.V1.NetworkLoadBalancerService.NetworkLoadBalancerServiceClient NetworkLoadBalancerService
        {
            get
            {
                return new Yandex.Cloud.Loadbalancer.V1.NetworkLoadBalancerService.NetworkLoadBalancerServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Loadbalancer.V1.TargetGroupService.TargetGroupServiceClient TargetGroupService
        {
            get
            {
                return new Yandex.Cloud.Loadbalancer.V1.TargetGroupService.TargetGroupServiceClient(this.GetChannel());
            }
        }
    }
    
    public class Services_Kms : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Kms(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "kms")
        {
        }
        
        public virtual Yandex.Cloud.Kms.V1.SymmetricCryptoService.SymmetricCryptoServiceClient SymmetricCryptoService
        {
            get
            {
                return new Yandex.Cloud.Kms.V1.SymmetricCryptoService.SymmetricCryptoServiceClient(this.GetChannel("kms-crypto"));
            }
        }
        
        public virtual Yandex.Cloud.Kms.V1.SymmetricKeyService.SymmetricKeyServiceClient SymmetricKeyService
        {
            get
            {
                return new Yandex.Cloud.Kms.V1.SymmetricKeyService.SymmetricKeyServiceClient(this.GetChannel());
            }
        }
    }
    
    public class Services_K8S : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_K8S(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "managed-kubernetes")
        {
        }
        
        public virtual Yandex.Cloud.K8S.V1.ClusterService.ClusterServiceClient ClusterService
        {
            get
            {
                return new Yandex.Cloud.K8S.V1.ClusterService.ClusterServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.K8S.V1.NodeGroupService.NodeGroupServiceClient NodeGroupService
        {
            get
            {
                return new Yandex.Cloud.K8S.V1.NodeGroupService.NodeGroupServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.K8S.V1.VersionService.VersionServiceClient VersionService
        {
            get
            {
                return new Yandex.Cloud.K8S.V1.VersionService.VersionServiceClient(this.GetChannel());
            }
        }
    }
    
    public class Services_Iot_Devices : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Iot_Devices(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "iot-devices")
        {
        }
        
        public virtual Yandex.Cloud.Iot.Devices.V1.DeviceDataService.DeviceDataServiceClient DeviceDataService
        {
            get
            {
                return new Yandex.Cloud.Iot.Devices.V1.DeviceDataService.DeviceDataServiceClient(this.GetChannel("iot-data"));
            }
        }
        
        public virtual Yandex.Cloud.Iot.Devices.V1.DeviceService.DeviceServiceClient DeviceService
        {
            get
            {
                return new Yandex.Cloud.Iot.Devices.V1.DeviceService.DeviceServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Iot.Devices.V1.RegistryDataService.RegistryDataServiceClient RegistryDataService
        {
            get
            {
                return new Yandex.Cloud.Iot.Devices.V1.RegistryDataService.RegistryDataServiceClient(this.GetChannel("iot-data"));
            }
        }
        
        public virtual Yandex.Cloud.Iot.Devices.V1.RegistryService.RegistryServiceClient RegistryService
        {
            get
            {
                return new Yandex.Cloud.Iot.Devices.V1.RegistryService.RegistryServiceClient(this.GetChannel());
            }
        }
    }
    
    public class Services_Iot : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Iot(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "iot")
        {
        }
        
        public virtual Services_Iot_Devices Devices
        {
            get
            {
                return new Services_Iot_Devices(this.Sdk());
            }
        }
    }
    
    public class Services_Iam_Awscompatibility : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Iam_Awscompatibility(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "unknown")
        {
            throw new System.Exception("service Services_Iam_Awscompatibility is not supported at this moment");
        }
        
        public virtual Yandex.Cloud.Iam.V1.Awscompatibility.AccessKeyService.AccessKeyServiceClient AccessKeyService
        {
            get
            {
                return new Yandex.Cloud.Iam.V1.Awscompatibility.AccessKeyService.AccessKeyServiceClient(this.GetChannel());
            }
        }
    }
    
    public class Services_Iam : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Iam(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "iam")
        {
        }
        
        public virtual Yandex.Cloud.Iam.V1.ApiKeyService.ApiKeyServiceClient ApiKeyService
        {
            get
            {
                return new Yandex.Cloud.Iam.V1.ApiKeyService.ApiKeyServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Iam.V1.IamTokenService.IamTokenServiceClient IamTokenService
        {
            get
            {
                return new Yandex.Cloud.Iam.V1.IamTokenService.IamTokenServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Iam.V1.KeyService.KeyServiceClient KeyService
        {
            get
            {
                return new Yandex.Cloud.Iam.V1.KeyService.KeyServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Iam.V1.RoleService.RoleServiceClient RoleService
        {
            get
            {
                return new Yandex.Cloud.Iam.V1.RoleService.RoleServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Iam.V1.ServiceAccountService.ServiceAccountServiceClient ServiceAccountService
        {
            get
            {
                return new Yandex.Cloud.Iam.V1.ServiceAccountService.ServiceAccountServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Iam.V1.UserAccountService.UserAccountServiceClient UserAccountService
        {
            get
            {
                return new Yandex.Cloud.Iam.V1.UserAccountService.UserAccountServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Iam.V1.YandexPassportUserAccountService.YandexPassportUserAccountServiceClient YandexPassportUserAccountService
        {
            get
            {
                return new Yandex.Cloud.Iam.V1.YandexPassportUserAccountService.YandexPassportUserAccountServiceClient(this.GetChannel());
            }
        }
        
        public virtual Services_Iam_Awscompatibility Awscompatibility
        {
            get
            {
                return new Services_Iam_Awscompatibility(this.Sdk());
            }
        }
    }
    
    public class Services_Endpoint : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Endpoint(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "endpoint")
        {
        }
        
        public virtual Yandex.Cloud.Endpoint.ApiEndpointService.ApiEndpointServiceClient ApiEndpointService
        {
            get
            {
                return new Yandex.Cloud.Endpoint.ApiEndpointService.ApiEndpointServiceClient(this.GetChannel());
            }
        }
    }
    
    public class Services_Dataproc_Manager : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Dataproc_Manager(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "unknown")
        {
            throw new System.Exception("service Services_Dataproc_Manager is not supported at this moment");
        }
        
        public virtual Yandex.Cloud.Dataproc.Manager.V1.JobService.JobServiceClient JobService
        {
            get
            {
                return new Yandex.Cloud.Dataproc.Manager.V1.JobService.JobServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Dataproc.Manager.V1.DataprocManagerService.DataprocManagerServiceClient DataprocManagerService
        {
            get
            {
                return new Yandex.Cloud.Dataproc.Manager.V1.DataprocManagerService.DataprocManagerServiceClient(this.GetChannel());
            }
        }
    }
    
    public class Services_Dataproc : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Dataproc(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "unknown")
        {
            throw new System.Exception("service Services_Dataproc is not supported at this moment");
        }
        
        public virtual Yandex.Cloud.Dataproc.V1.ClusterService.ClusterServiceClient ClusterService
        {
            get
            {
                return new Yandex.Cloud.Dataproc.V1.ClusterService.ClusterServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Dataproc.V1.JobService.JobServiceClient JobService
        {
            get
            {
                return new Yandex.Cloud.Dataproc.V1.JobService.JobServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Dataproc.V1.ResourcePresetService.ResourcePresetServiceClient ResourcePresetService
        {
            get
            {
                return new Yandex.Cloud.Dataproc.V1.ResourcePresetService.ResourcePresetServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Dataproc.V1.SubclusterService.SubclusterServiceClient SubclusterService
        {
            get
            {
                return new Yandex.Cloud.Dataproc.V1.SubclusterService.SubclusterServiceClient(this.GetChannel());
            }
        }
        
        public virtual Services_Dataproc_Manager Manager
        {
            get
            {
                return new Services_Dataproc_Manager(this.Sdk());
            }
        }
    }
    
    public class Services_Containerregistry : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Containerregistry(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "container-registry")
        {
        }
        
        public virtual Yandex.Cloud.Containerregistry.V1.ImageService.ImageServiceClient ImageService
        {
            get
            {
                return new Yandex.Cloud.Containerregistry.V1.ImageService.ImageServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Containerregistry.V1.LifecyclePolicyService.LifecyclePolicyServiceClient LifecyclePolicyService
        {
            get
            {
                return new Yandex.Cloud.Containerregistry.V1.LifecyclePolicyService.LifecyclePolicyServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Containerregistry.V1.RegistryService.RegistryServiceClient RegistryService
        {
            get
            {
                return new Yandex.Cloud.Containerregistry.V1.RegistryService.RegistryServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Containerregistry.V1.RepositoryService.RepositoryServiceClient RepositoryService
        {
            get
            {
                return new Yandex.Cloud.Containerregistry.V1.RepositoryService.RepositoryServiceClient(this.GetChannel());
            }
        }
    }
    
    public class Services_Compute_Instancegroup : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Compute_Instancegroup(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "compute")
        {
        }
        
        public virtual Yandex.Cloud.Compute.V1.Instancegroup.InstanceGroupService.InstanceGroupServiceClient InstanceGroupService
        {
            get
            {
                return new Yandex.Cloud.Compute.V1.Instancegroup.InstanceGroupService.InstanceGroupServiceClient(this.GetChannel());
            }
        }
    }
    
    public class Services_Compute : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Compute(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "compute")
        {
        }
        
        public virtual Yandex.Cloud.Compute.V1.DiskPlacementGroupService.DiskPlacementGroupServiceClient DiskPlacementGroupService
        {
            get
            {
                return new Yandex.Cloud.Compute.V1.DiskPlacementGroupService.DiskPlacementGroupServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Compute.V1.DiskService.DiskServiceClient DiskService
        {
            get
            {
                return new Yandex.Cloud.Compute.V1.DiskService.DiskServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Compute.V1.DiskTypeService.DiskTypeServiceClient DiskTypeService
        {
            get
            {
                return new Yandex.Cloud.Compute.V1.DiskTypeService.DiskTypeServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Compute.V1.HostGroupService.HostGroupServiceClient HostGroupService
        {
            get
            {
                return new Yandex.Cloud.Compute.V1.HostGroupService.HostGroupServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Compute.V1.HostTypeService.HostTypeServiceClient HostTypeService
        {
            get
            {
                return new Yandex.Cloud.Compute.V1.HostTypeService.HostTypeServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Compute.V1.ImageService.ImageServiceClient ImageService
        {
            get
            {
                return new Yandex.Cloud.Compute.V1.ImageService.ImageServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Compute.V1.InstanceService.InstanceServiceClient InstanceService
        {
            get
            {
                return new Yandex.Cloud.Compute.V1.InstanceService.InstanceServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Compute.V1.PlacementGroupService.PlacementGroupServiceClient PlacementGroupService
        {
            get
            {
                return new Yandex.Cloud.Compute.V1.PlacementGroupService.PlacementGroupServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Compute.V1.SnapshotService.SnapshotServiceClient SnapshotService
        {
            get
            {
                return new Yandex.Cloud.Compute.V1.SnapshotService.SnapshotServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Compute.V1.ZoneService.ZoneServiceClient ZoneService
        {
            get
            {
                return new Yandex.Cloud.Compute.V1.ZoneService.ZoneServiceClient(this.GetChannel());
            }
        }
        
        public virtual Services_Compute_Instancegroup Instancegroup
        {
            get
            {
                return new Services_Compute_Instancegroup(this.Sdk());
            }
        }
    }
    
    public class Services_Certificatemanager : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Certificatemanager(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "unknown")
        {
            throw new System.Exception("service Services_Certificatemanager is not supported at this moment");
        }
        
        public virtual Yandex.Cloud.Certificatemanager.V1.CertificateContentService.CertificateContentServiceClient CertificateContentService
        {
            get
            {
                return new Yandex.Cloud.Certificatemanager.V1.CertificateContentService.CertificateContentServiceClient(this.GetChannel());
            }
        }
        
        public virtual Yandex.Cloud.Certificatemanager.V1.CertificateService.CertificateServiceClient CertificateService
        {
            get
            {
                return new Yandex.Cloud.Certificatemanager.V1.CertificateService.CertificateServiceClient(this.GetChannel());
            }
        }
    }
    
    public class Services_Ai_Vision : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Ai_Vision(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "ai-vision")
        {
        }
        
        public virtual Yandex.Cloud.Ai.Vision.V1.VisionService.VisionServiceClient VisionService
        {
            get
            {
                return new Yandex.Cloud.Ai.Vision.V1.VisionService.VisionServiceClient(this.GetChannel());
            }
        }
    }
    
    public class Services_Ai_Translate : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Ai_Translate(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "ai-translate")
        {
        }
        
        public virtual Yandex.Cloud.Ai.Translate.V2.TranslationService.TranslationServiceClient TranslationService
        {
            get
            {
                return new Yandex.Cloud.Ai.Translate.V2.TranslationService.TranslationServiceClient(this.GetChannel());
            }
        }
    }
    
    public class Services_Ai_Stt : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Ai_Stt(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "ai-stt")
        {
        }
        
        public virtual Yandex.Cloud.Ai.Stt.V2.SttService.SttServiceClient SttService
        {
            get
            {
                return new Yandex.Cloud.Ai.Stt.V2.SttService.SttServiceClient(this.GetChannel());
            }
        }
    }
    
    public class Services_Ai : Yandex.Cloud.ServiceRegistry
    {
        
        public Services_Ai(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "ai")
        {
        }
        
        public virtual Services_Ai_Vision Vision
        {
            get
            {
                return new Services_Ai_Vision(this.Sdk());
            }
        }
        
        public virtual Services_Ai_Translate Translate
        {
            get
            {
                return new Services_Ai_Translate(this.Sdk());
            }
        }
        
        public virtual Services_Ai_Stt Stt
        {
            get
            {
                return new Services_Ai_Stt(this.Sdk());
            }
        }
    }
    
    public class Services : Yandex.Cloud.ServiceRegistry
    {
        
        public Services(Yandex.Cloud.Sdk sdk) : 
                base(sdk, "")
        {
        }
        
        public virtual Services_Vpc Vpc
        {
            get
            {
                return new Services_Vpc(this.Sdk());
            }
        }
        
        public virtual Services_Serverless Serverless
        {
            get
            {
                return new Services_Serverless(this.Sdk());
            }
        }
        
        public virtual Services_Resourcemanager Resourcemanager
        {
            get
            {
                return new Services_Resourcemanager(this.Sdk());
            }
        }
        
        public virtual Services_Operation Operation
        {
            get
            {
                return new Services_Operation(this.Sdk());
            }
        }
        
        public virtual Services_Mdb Mdb
        {
            get
            {
                return new Services_Mdb(this.Sdk());
            }
        }
        
        public virtual Services_Marketplace Marketplace
        {
            get
            {
                return new Services_Marketplace(this.Sdk());
            }
        }
        
        public virtual Services_Loadbalancer Loadbalancer
        {
            get
            {
                return new Services_Loadbalancer(this.Sdk());
            }
        }
        
        public virtual Services_Kms Kms
        {
            get
            {
                return new Services_Kms(this.Sdk());
            }
        }
        
        public virtual Services_K8S K8S
        {
            get
            {
                return new Services_K8S(this.Sdk());
            }
        }
        
        public virtual Services_Iot Iot
        {
            get
            {
                return new Services_Iot(this.Sdk());
            }
        }
        
        public virtual Services_Iam Iam
        {
            get
            {
                return new Services_Iam(this.Sdk());
            }
        }
        
        public virtual Services_Endpoint Endpoint
        {
            get
            {
                return new Services_Endpoint(this.Sdk());
            }
        }
        
        public virtual Services_Dataproc Dataproc
        {
            get
            {
                return new Services_Dataproc(this.Sdk());
            }
        }
        
        public virtual Services_Containerregistry Containerregistry
        {
            get
            {
                return new Services_Containerregistry(this.Sdk());
            }
        }
        
        public virtual Services_Compute Compute
        {
            get
            {
                return new Services_Compute(this.Sdk());
            }
        }
        
        public virtual Services_Certificatemanager Certificatemanager
        {
            get
            {
                return new Services_Certificatemanager(this.Sdk());
            }
        }
        
        public virtual Services_Ai Ai
        {
            get
            {
                return new Services_Ai(this.Sdk());
            }
        }
    }
}
