Imports System
Imports System.Threading.Tasks
Imports System.Collections.Generic
Imports System.Numerics
Imports Nethereum.Hex.HexTypes
Imports Nethereum.ABI.FunctionEncoding.Attributes
Imports Nethereum.Web3
Imports Nethereum.RPC.Eth.DTOs
Imports Nethereum.Contracts.CQS
Imports Nethereum.Contracts
Imports System.Threading
Namespace .workspaces.Contracts.ABI.ContractDefinition

    
    
    Public Partial Class ABIDeployment
     Inherits ABIDeploymentBase
    
        Public Sub New()
            MyBase.New(DEFAULT_BYTECODE)
        End Sub
        
        Public Sub New(ByVal byteCode As String)
            MyBase.New(byteCode)
        End Sub
    
    End Class

    Public Class ABIDeploymentBase 
            Inherits ContractDeploymentMessage
        
        Public Shared DEFAULT_BYTECODE As String = "0x"
        
        Public Sub New()
            MyBase.New(DEFAULT_BYTECODE)
        End Sub
        
        Public Sub New(ByVal byteCode As String)
            MyBase.New(byteCode)
        End Sub
        

    
    End Class    
    
    Public Partial Class EndGrantAuthenticationFunction
        Inherits EndGrantAuthenticationFunctionBase
    End Class

        <[Function]("endGrantAuthentication")>
    Public Class EndGrantAuthenticationFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "addr", 1)>
        Public Overridable Property [Addr] As String
    
    End Class
    
    
    Public Partial Class GrantInitialAuthenticationFunction
        Inherits GrantInitialAuthenticationFunctionBase
    End Class

        <[Function]("grantInitialAuthentication")>
    Public Class GrantInitialAuthenticationFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "authAddress", 1)>
        Public Overridable Property [AuthAddress] As String
    
    End Class
    
    
    Public Partial Class RegisterProxyFunction
        Inherits RegisterProxyFunctionBase
    End Class

        <[Function]("registerProxy", "address")>
    Public Class RegisterProxyFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class RenounceOwnershipFunction
        Inherits RenounceOwnershipFunctionBase
    End Class

        <[Function]("renounceOwnership")>
    Public Class RenounceOwnershipFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class RevokeAuthenticationFunction
        Inherits RevokeAuthenticationFunctionBase
    End Class

        <[Function]("revokeAuthentication")>
    Public Class RevokeAuthenticationFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "addr", 1)>
        Public Overridable Property [Addr] As String
    
    End Class
    
    
    Public Partial Class StartGrantAuthenticationFunction
        Inherits StartGrantAuthenticationFunctionBase
    End Class

        <[Function]("startGrantAuthentication")>
    Public Class StartGrantAuthenticationFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "addr", 1)>
        Public Overridable Property [Addr] As String
    
    End Class
    
    
    Public Partial Class TransferOwnershipFunction
        Inherits TransferOwnershipFunctionBase
    End Class

        <[Function]("transferOwnership")>
    Public Class TransferOwnershipFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "newOwner", 1)>
        Public Overridable Property [NewOwner] As String
    
    End Class
    
    
    Public Partial Class ContractsFunction
        Inherits ContractsFunctionBase
    End Class

        <[Function]("contracts", "bool")>
    Public Class ContractsFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class
    
    
    Public Partial Class DELAY_PERIODFunction
        Inherits DELAY_PERIODFunctionBase
    End Class

        <[Function]("DELAY_PERIOD", "uint256")>
    Public Class DELAY_PERIODFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class DelegateProxyImplementationFunction
        Inherits DelegateProxyImplementationFunctionBase
    End Class

        <[Function]("delegateProxyImplementation", "address")>
    Public Class DelegateProxyImplementationFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class InitialAddressSetFunction
        Inherits InitialAddressSetFunctionBase
    End Class

        <[Function]("initialAddressSet", "bool")>
    Public Class InitialAddressSetFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class NameFunction
        Inherits NameFunctionBase
    End Class

        <[Function]("name", "string")>
    Public Class NameFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class OwnerFunction
        Inherits OwnerFunctionBase
    End Class

        <[Function]("owner", "address")>
    Public Class OwnerFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class PendingFunction
        Inherits PendingFunctionBase
    End Class

        <[Function]("pending", "uint256")>
    Public Class PendingFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class
    
    
    Public Partial Class ProxiesFunction
        Inherits ProxiesFunctionBase
    End Class

        <[Function]("proxies", "address")>
    Public Class ProxiesFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class
    
    
    Public Partial Class OwnershipRenouncedEventDTO
        Inherits OwnershipRenouncedEventDTOBase
    End Class

    <[Event]("OwnershipRenounced")>
    Public Class OwnershipRenouncedEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("address", "previousOwner", 1, true)>
        Public Overridable Property [PreviousOwner] As String
    
    End Class    
    
    Public Partial Class OwnershipTransferredEventDTO
        Inherits OwnershipTransferredEventDTOBase
    End Class

    <[Event]("OwnershipTransferred")>
    Public Class OwnershipTransferredEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("address", "previousOwner", 1, true)>
        Public Overridable Property [PreviousOwner] As String
        <[Parameter]("address", "newOwner", 2, true)>
        Public Overridable Property [NewOwner] As String
    
    End Class    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    Public Partial Class ContractsOutputDTO
        Inherits ContractsOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class ContractsOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("bool", "", 1)>
        Public Overridable Property [ReturnValue1] As Boolean
    
    End Class    
    
    Public Partial Class DELAY_PERIODOutputDTO
        Inherits DELAY_PERIODOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class DELAY_PERIODOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "", 1)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class    
    
    Public Partial Class DelegateProxyImplementationOutputDTO
        Inherits DelegateProxyImplementationOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class DelegateProxyImplementationOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class    
    
    Public Partial Class InitialAddressSetOutputDTO
        Inherits InitialAddressSetOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class InitialAddressSetOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("bool", "", 1)>
        Public Overridable Property [ReturnValue1] As Boolean
    
    End Class    
    
    Public Partial Class NameOutputDTO
        Inherits NameOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class NameOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("string", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class    
    
    Public Partial Class OwnerOutputDTO
        Inherits OwnerOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class OwnerOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class    
    
    Public Partial Class PendingOutputDTO
        Inherits PendingOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class PendingOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "", 1)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class    
    
    Public Partial Class ProxiesOutputDTO
        Inherits ProxiesOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class ProxiesOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class
End Namespace
