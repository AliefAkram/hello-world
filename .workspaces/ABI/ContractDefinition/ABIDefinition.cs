using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace .workspaces.Contracts.ABI.ContractDefinition
{


    public partial class ABIDeployment : ABIDeploymentBase
    {
        public ABIDeployment() : base(BYTECODE) { }
        public ABIDeployment(string byteCode) : base(byteCode) { }
    }

    public class ABIDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x";
        public ABIDeploymentBase() : base(BYTECODE) { }
        public ABIDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class EndGrantAuthenticationFunction : EndGrantAuthenticationFunctionBase { }

    [Function("endGrantAuthentication")]
    public class EndGrantAuthenticationFunctionBase : FunctionMessage
    {
        [Parameter("address", "addr", 1)]
        public virtual string Addr { get; set; }
    }

    public partial class GrantInitialAuthenticationFunction : GrantInitialAuthenticationFunctionBase { }

    [Function("grantInitialAuthentication")]
    public class GrantInitialAuthenticationFunctionBase : FunctionMessage
    {
        [Parameter("address", "authAddress", 1)]
        public virtual string AuthAddress { get; set; }
    }

    public partial class RegisterProxyFunction : RegisterProxyFunctionBase { }

    [Function("registerProxy", "address")]
    public class RegisterProxyFunctionBase : FunctionMessage
    {

    }

    public partial class RenounceOwnershipFunction : RenounceOwnershipFunctionBase { }

    [Function("renounceOwnership")]
    public class RenounceOwnershipFunctionBase : FunctionMessage
    {

    }

    public partial class RevokeAuthenticationFunction : RevokeAuthenticationFunctionBase { }

    [Function("revokeAuthentication")]
    public class RevokeAuthenticationFunctionBase : FunctionMessage
    {
        [Parameter("address", "addr", 1)]
        public virtual string Addr { get; set; }
    }

    public partial class StartGrantAuthenticationFunction : StartGrantAuthenticationFunctionBase { }

    [Function("startGrantAuthentication")]
    public class StartGrantAuthenticationFunctionBase : FunctionMessage
    {
        [Parameter("address", "addr", 1)]
        public virtual string Addr { get; set; }
    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public virtual string NewOwner { get; set; }
    }

    public partial class ContractsFunction : ContractsFunctionBase { }

    [Function("contracts", "bool")]
    public class ContractsFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class DELAY_PERIODFunction : DELAY_PERIODFunctionBase { }

    [Function("DELAY_PERIOD", "uint256")]
    public class DELAY_PERIODFunctionBase : FunctionMessage
    {

    }

    public partial class DelegateProxyImplementationFunction : DelegateProxyImplementationFunctionBase { }

    [Function("delegateProxyImplementation", "address")]
    public class DelegateProxyImplementationFunctionBase : FunctionMessage
    {

    }

    public partial class InitialAddressSetFunction : InitialAddressSetFunctionBase { }

    [Function("initialAddressSet", "bool")]
    public class InitialAddressSetFunctionBase : FunctionMessage
    {

    }

    public partial class NameFunction : NameFunctionBase { }

    [Function("name", "string")]
    public class NameFunctionBase : FunctionMessage
    {

    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class PendingFunction : PendingFunctionBase { }

    [Function("pending", "uint256")]
    public class PendingFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class ProxiesFunction : ProxiesFunctionBase { }

    [Function("proxies", "address")]
    public class ProxiesFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class OwnershipRenouncedEventDTO : OwnershipRenouncedEventDTOBase { }

    [Event("OwnershipRenounced")]
    public class OwnershipRenouncedEventDTOBase : IEventDTO
    {
        [Parameter("address", "previousOwner", 1, true )]
        public virtual string PreviousOwner { get; set; }
    }

    public partial class OwnershipTransferredEventDTO : OwnershipTransferredEventDTOBase { }

    [Event("OwnershipTransferred")]
    public class OwnershipTransferredEventDTOBase : IEventDTO
    {
        [Parameter("address", "previousOwner", 1, true )]
        public virtual string PreviousOwner { get; set; }
        [Parameter("address", "newOwner", 2, true )]
        public virtual string NewOwner { get; set; }
    }















    public partial class ContractsOutputDTO : ContractsOutputDTOBase { }

    [FunctionOutput]
    public class ContractsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class DELAY_PERIODOutputDTO : DELAY_PERIODOutputDTOBase { }

    [FunctionOutput]
    public class DELAY_PERIODOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class DelegateProxyImplementationOutputDTO : DelegateProxyImplementationOutputDTOBase { }

    [FunctionOutput]
    public class DelegateProxyImplementationOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class InitialAddressSetOutputDTO : InitialAddressSetOutputDTOBase { }

    [FunctionOutput]
    public class InitialAddressSetOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class NameOutputDTO : NameOutputDTOBase { }

    [FunctionOutput]
    public class NameOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class PendingOutputDTO : PendingOutputDTOBase { }

    [FunctionOutput]
    public class PendingOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class ProxiesOutputDTO : ProxiesOutputDTOBase { }

    [FunctionOutput]
    public class ProxiesOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }
}
